/**
 * usePomodoroMachine.js
 *
 * Custom Hook que encapsula toda la lógica de la máquina de estados
 * del Pomodoro. Es la ÚNICA API que el componente de UI necesita consumir.
 *
 * Responsabilidades:
 *   1. Gestiona el reducer (estado + dispatch).
 *   2. Maneja el setInterval para el timer automático.
 *   3. Detecta cuando el timer llega a 0 y avanza la fase/ciclo.
 *   4. Expone acciones nombradas (reanudar, pausar, etc.).
 *   5. Expone validadores booleanos (puedeReanudar, puedePausar, etc.)
 *      para que la UI deshabilite botones de acciones ilegales.
 *
 * Nota: La creación del Pomodoro en el backend se hace AL FINALIZAR,
 * no al iniciar (decisión de negocio confirmada).
 */

import { useReducer, useEffect, useCallback, useRef } from 'react';
import { FasePomodoro, AccionPomodoro } from './pomodoroConstants';
import { esTransicionValida } from './pomodoroTransitions';
import {
  pomodoroReducer,
  crearEstadoInicial,
  REDUCER_ACTIONS,
} from './pomodoroReducer';

/**
 * @param {Object} [config]
 * @param {number} [config.duracionSesion=25]    - Minutos de estudio
 * @param {number} [config.duracionDescanso=5]   - Minutos de descanso
 * @param {number} [config.ciclosTotales=4]      - Cantidad de ciclos
 *
 * @returns {Object} API pública para el componente de UI
 */
export function usePomodoroMachine(config = {}) {
  const [state, dispatch] = useReducer(
    pomodoroReducer,
    config,
    crearEstadoInicial
  );

  const intervaloRef = useRef(null);

  // ── Timer automático ──────────────────────────────────────────────
  // Corre el setInterval solo cuando la fase es EnCurso o EnDescanso
  // y hay segundos restantes.
  useEffect(() => {
    const debeCorrer =
      (state.fase === FasePomodoro.EnCurso ||
       state.fase === FasePomodoro.EnDescanso) &&
      state.segundosRestantes > 0;

    if (debeCorrer) {
      intervaloRef.current = setInterval(() => {
        dispatch({ type: REDUCER_ACTIONS.TICK });
      }, 1000);
    }

    return () => {
      if (intervaloRef.current) {
        clearInterval(intervaloRef.current);
        intervaloRef.current = null;
      }
    };
  }, [state.fase, state.segundosRestantes > 0]);

  // ── Detección de timer agotado ────────────────────────────────────
  // Cuando el timer llega a 0, automáticamente avanzamos:
  //   - Si estaba EnCurso → SaltarFase (ir a descanso)
  //   - Si estaba EnDescanso → AVANZAR_CICLO (siguiente ciclo o completar)
  useEffect(() => {
    if (state.segundosRestantes !== 0) return;

    if (state.fase === FasePomodoro.EnCurso) {
      // Sesión de estudio terminó → ir a descanso
      dispatch({
        type: REDUCER_ACTIONS.TRANSICION,
        payload: { accion: AccionPomodoro.SALTAR_FASE },
      });
    } else if (state.fase === FasePomodoro.EnDescanso) {
      // Descanso terminó → avanzar ciclo (lógica local, no notifica backend)
      dispatch({ type: REDUCER_ACTIONS.AVANZAR_CICLO });
    }
  }, [state.segundosRestantes, state.fase]);

  // ── Ejecutor de transiciones ──────────────────────────────────────
  // Función interna que valida y despacha una transición.
  const ejecutarTransicion = useCallback(
    (accion) => {
      if (!esTransicionValida(state.fase, accion)) {
        console.warn(
          `[usePomodoroMachine] Transición bloqueada: fase=${state.fase} accion=${accion}`
        );
        return;
      }

      dispatch({
        type: REDUCER_ACTIONS.TRANSICION,
        payload: { accion },
      });
    },
    [state.fase]
  );

  // ── Acciones públicas ─────────────────────────────────────────────

  /** Iniciar desde Pendiente o reanudar desde Pausado */
  const reanudar = useCallback(
    () => ejecutarTransicion(AccionPomodoro.REANUDAR),
    [ejecutarTransicion]
  );

  /** Pausar el timer activo (solo válido en EnCurso) */
  const pausar = useCallback(
    () => ejecutarTransicion(AccionPomodoro.PAUSAR),
    [ejecutarTransicion]
  );

  /** Finalizar la sesión completa */
  const finalizar = useCallback(
    () => ejecutarTransicion(AccionPomodoro.FINALIZAR),
    [ejecutarTransicion]
  );

  /**
   * Saltar a la siguiente fase manualmente.
   *
   * Comportamiento según la fase actual:
   *   - EnCurso / Pausado / Pendiente → va a EnDescanso (tabla de transiciones).
   *   - EnDescanso → avanza al siguiente ciclo de estudio, o finaliza si era
   *     el último ciclo. Esta lógica es LOCAL (el backend no trackea ciclos).
   *     NO va directo a Completado como dicta la tabla del backend, porque
   *     esa transición es para la sesión completa sin ciclos múltiples.
   */
  const saltarFase = useCallback(() => {
    if (state.fase === FasePomodoro.EnDescanso) {
      // Avanzar ciclo localmente en vez de ir directo a Completado
      dispatch({ type: REDUCER_ACTIONS.AVANZAR_CICLO });
    } else {
      ejecutarTransicion(AccionPomodoro.SALTAR_FASE);
    }
  }, [state.fase, ejecutarTransicion]);

  /** Resetear todo al estado Pendiente (conserva configuración) */
  const resetear = useCallback(() => {
    dispatch({ type: REDUCER_ACTIONS.RESETEAR });
  }, []);

  /** Actualizar configuración de duración y ciclos */
  const configurar = useCallback((nuevaConfig) => {
    dispatch({
      type: REDUCER_ACTIONS.CONFIGURAR,
      payload: nuevaConfig,
    });
  }, []);

  /** Hidratar el estado local con datos del backend */
  const sincronizarConBackend = useCallback((pomodoro) => {
    dispatch({
      type: REDUCER_ACTIONS.SINCRONIZAR_BACKEND,
      payload: { pomodoro },
    });
  }, []);

  // ── API pública ──────────────────────────────────────────────────

  return {
    // ── Estado (lectura) ──
    fase:                       state.fase,
    segundosRestantes:          state.segundosRestantes,
    esDescanso:                 state.esDescanso,
    cicloActual:                state.cicloActual,
    ciclosTotales:              state.ciclosTotales,
    duracionSesion:             state.duracionSesion,
    duracionDescanso:           state.duracionDescanso,
    segundosAcumuladosEstudio:  state.segundosAcumuladosEstudio,
    segundosAcumuladosDescanso: state.segundosAcumuladosDescanso,
    error:                      state.error,

    // ── Derivados (helpers booleanos para la UI) ──
    estaActivo:      state.fase === FasePomodoro.EnCurso,
    estaEnDescanso:  state.fase === FasePomodoro.EnDescanso,
    estaPausado:     state.fase === FasePomodoro.Pausado,
    estaCompletado:  state.fase === FasePomodoro.Completado,
    estaPendiente:   state.fase === FasePomodoro.Pendiente,
    timerCorriendo:
      state.fase === FasePomodoro.EnCurso ||
      state.fase === FasePomodoro.EnDescanso,

    // ── Validadores (para habilitar/deshabilitar botones) ──
    puedeReanudar:   esTransicionValida(state.fase, AccionPomodoro.REANUDAR),
    puedePausar:     esTransicionValida(state.fase, AccionPomodoro.PAUSAR),
    puedeFinalizar:  esTransicionValida(state.fase, AccionPomodoro.FINALIZAR),
    puedeSaltarFase: esTransicionValida(state.fase, AccionPomodoro.SALTAR_FASE),

    // ── Acciones (escritura) ──
    reanudar,
    pausar,
    finalizar,
    saltarFase,
    resetear,
    configurar,
    sincronizarConBackend,
  };
}
