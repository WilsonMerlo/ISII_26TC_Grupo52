/**
 * pomodoroReducer.js
 *
 * Reducer puro que gobierna la máquina de estados del Pomodoro.
 * Toda transición de `fase` pasa obligatoriamente por la tabla TRANSITIONS,
 * garantizando paridad 1:1 con el Patrón State del backend C#.
 *
 * Decisiones de negocio incorporadas (confirmadas por el equipo):
 *   - El Pomodoro se crea en el backend al FINALIZAR, no al iniciar.
 *   - El avance de ciclos es puramente local (frontend).
 *   - El descanso NO se puede pausar (intencional).
 */

import { FasePomodoro } from './pomodoroConstants';
import { obtenerSiguienteFase } from './pomodoroTransitions';

// ── Tipos de acción del reducer ─────────────────────────────────────────────
// Son acciones internas del reducer, distintas de AccionPomodoro (que son
// las acciones del dominio / API).

export const REDUCER_ACTIONS = Object.freeze({
  /** Ejecutar una transición de la máquina de estados */
  TRANSICION:          'TRANSICION',
  /** Decrementar el timer 1 segundo */
  TICK:                'TICK',
  /** Avanzar al siguiente ciclo (tras finalizar un descanso) */
  AVANZAR_CICLO:       'AVANZAR_CICLO',
  /** Cambiar duración sesión / descanso / ciclos */
  CONFIGURAR:          'CONFIGURAR',
  /** Volver al estado Pendiente con la config actual */
  RESETEAR:            'RESETEAR',
  /** Hidratar el estado local con datos del backend */
  SINCRONIZAR_BACKEND: 'SINCRONIZAR_BACKEND',
});

// ── Estado inicial ──────────────────────────────────────────────────────────

/**
 * Crea el estado inicial del Pomodoro.
 *
 * @param {Object} [config]
 * @param {number} [config.duracionSesion=25]    - Minutos de estudio
 * @param {number} [config.duracionDescanso=5]   - Minutos de descanso
 * @param {number} [config.ciclosTotales=4]      - Cantidad de ciclos
 * @returns {Object} Estado inicial
 */
export function crearEstadoInicial(config = {}) {
  const duracionSesion   = config.duracionSesion   ?? 25;
  const duracionDescanso = config.duracionDescanso ?? 5;
  const ciclosTotales    = config.ciclosTotales    ?? 4;

  return {
    // ── Máquina de estados (espejo del backend) ──
    fase: FasePomodoro.Pendiente,

    // ── Timer ──
    segundosRestantes: duracionSesion * 60,
    esDescanso: false,

    // ── Configuración ──
    duracionSesion,       // minutos
    duracionDescanso,     // minutos
    ciclosTotales,

    // ── Progreso de ciclos (puramente local) ──
    cicloActual: 1,
    segundosAcumuladosEstudio: 0,
    segundosAcumuladosDescanso: 0,

    // ── Metadata ──
    error: null,          // Último error de transición inválida
  };
}

// ── Reducer ─────────────────────────────────────────────────────────────────

export function pomodoroReducer(state, action) {
  switch (action.type) {

    // ── TRANSICION ──────────────────────────────────────────────────
    // Ejecuta una transición validada contra la tabla de transiciones.
    case REDUCER_ACTIONS.TRANSICION: {
      const { accion } = action.payload;
      const siguienteFase = obtenerSiguienteFase(state.fase, accion);

      // Transición inválida: no muta el estado, solo registra el error.
      if (siguienteFase === null) {
        console.warn(
          `[PomodoroMachine] Transición inválida: fase=${state.fase} accion=${accion}`
        );
        return {
          ...state,
          error: `Acción "${accion}" no permitida en fase actual`,
        };
      }

      // Calcular nuevos valores según la fase destino
      let nuevosSegundos = state.segundosRestantes;
      let nuevaEsDescanso = state.esDescanso;

      if (siguienteFase === FasePomodoro.EnDescanso) {
        // Entrando a descanso: resetear timer al tiempo de descanso
        nuevosSegundos = state.duracionDescanso * 60;
        nuevaEsDescanso = true;
      } else if (
        siguienteFase === FasePomodoro.EnCurso &&
        state.fase === FasePomodoro.Pendiente
      ) {
        // Primer inicio: asegurar que el timer muestre la sesión completa
        nuevosSegundos = state.duracionSesion * 60;
        nuevaEsDescanso = false;
      } else if (siguienteFase === FasePomodoro.Completado) {
        // Completado: timer a 0
        nuevosSegundos = 0;
      }
      // Pausado→EnCurso o EnCurso→Pausado: se conserva segundosRestantes

      return {
        ...state,
        fase: siguienteFase,
        segundosRestantes: nuevosSegundos,
        esDescanso: nuevaEsDescanso,
        error: null,
      };
    }

    // ── TICK ─────────────────────────────────────────────────────────
    // Decrementar 1 segundo. Solo actúa en fases que corren el timer.
    case REDUCER_ACTIONS.TICK: {
      if (
        state.fase !== FasePomodoro.EnCurso &&
        state.fase !== FasePomodoro.EnDescanso
      ) {
        return state;
      }

      const nuevosSegundos = Math.max(0, state.segundosRestantes - 1);

      // Acumular en el contador correspondiente
      return {
        ...state,
        segundosRestantes: nuevosSegundos,
        ...(state.esDescanso
          ? { segundosAcumuladosDescanso: state.segundosAcumuladosDescanso + 1 }
          : { segundosAcumuladosEstudio: state.segundosAcumuladosEstudio + 1 }
        ),
      };
    }

    // ── AVANZAR_CICLO ───────────────────────────────────────────────
    // Se despacha cuando el descanso llega a 0.
    // Lógica puramente local (confirmado: el backend no se notifica).
    case REDUCER_ACTIONS.AVANZAR_CICLO: {
      const siguienteCiclo = state.cicloActual + 1;

      if (siguienteCiclo > state.ciclosTotales) {
        // Todos los ciclos completados → estado absorbente
        return {
          ...state,
          fase: FasePomodoro.Completado,
          segundosRestantes: 0,
        };
      }

      // Siguiente ciclo de estudio
      return {
        ...state,
        fase: FasePomodoro.EnCurso,
        cicloActual: siguienteCiclo,
        segundosRestantes: state.duracionSesion * 60,
        esDescanso: false,
      };
    }

    // ── CONFIGURAR ──────────────────────────────────────────────────
    // Actualiza duración de sesión, descanso y/o ciclos.
    // Si está en Pendiente, también actualiza el timer visible.
    case REDUCER_ACTIONS.CONFIGURAR: {
      const {
        duracionSesion   = state.duracionSesion,
        duracionDescanso = state.duracionDescanso,
        ciclosTotales    = state.ciclosTotales,
      } = action.payload;

      return {
        ...state,
        duracionSesion,
        duracionDescanso,
        ciclosTotales,
        segundosRestantes:
          state.fase === FasePomodoro.Pendiente
            ? duracionSesion * 60
            : state.segundosRestantes,
      };
    }

    // ── RESETEAR ────────────────────────────────────────────────────
    // Vuelve al estado Pendiente conservando la configuración actual.
    case REDUCER_ACTIONS.RESETEAR: {
      return crearEstadoInicial({
        duracionSesion:   state.duracionSesion,
        duracionDescanso: state.duracionDescanso,
        ciclosTotales:    state.ciclosTotales,
      });
    }

    // ── SINCRONIZAR_BACKEND ─────────────────────────────────────────
    // Hidrata el estado local con la respuesta del backend tras crear
    // o consultar un Pomodoro.
    case REDUCER_ACTIONS.SINCRONIZAR_BACKEND: {
      const { pomodoro } = action.payload;
      return {
        ...state,
        fase: pomodoro.estadoFase,
        segundosAcumuladosEstudio:
          pomodoro.duracionEstudio ?? state.segundosAcumuladosEstudio,
        segundosAcumuladosDescanso:
          pomodoro.duracionDescanso ?? state.segundosAcumuladosDescanso,
        error: null,
      };
    }

    default:
      return state;
  }
}
