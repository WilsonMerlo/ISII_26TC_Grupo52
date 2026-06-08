/**
 * pomodoroTransitions.js
 *
 * Tabla de transiciones declarativa que replica exactamente las reglas
 * del Patrón State implementado en el backend C#.
 *
 * Fuente de verdad: StudIA.Data.Entities.Pomodoro.cs (líneas 96-137)
 *   - EstadoPendiente, EstadoEnCurso, EstadoPausado,
 *     EstadoEnDescanso, EstadoCompletado
 *
 * Convención:
 *   - Valor numérico (FasePomodoro) → transición válida hacia esa fase.
 *   - null → transición inválida (equivale al throw InvalidOperationException del backend).
 */

import { FasePomodoro, AccionPomodoro } from './pomodoroConstants';

// ── Tabla de transiciones ───────────────────────────────────────────────────
// Map<FaseActual, Map<Accion, FaseSiguiente | null>>

export const TRANSITIONS = new Map([
  // EstadoPendiente
  [FasePomodoro.Pendiente, new Map([
    [AccionPomodoro.REANUDAR,    FasePomodoro.EnCurso],     // Reanudar() → EnCurso
    [AccionPomodoro.PAUSAR,      null],                     // Pausar()   → ❌ "No se puede pausar sin iniciar"
    [AccionPomodoro.FINALIZAR,   null],                     // Finalizar()→ ❌ "No se puede finalizar sin iniciar"
    [AccionPomodoro.SALTAR_FASE, FasePomodoro.EnDescanso],  // SaltarFase()→ EnDescanso
  ])],

  // EstadoEnCurso
  [FasePomodoro.EnCurso, new Map([
    [AccionPomodoro.REANUDAR,    null],                     // Reanudar() → ❌ "Ya está corriendo"
    [AccionPomodoro.PAUSAR,      FasePomodoro.Pausado],     // Pausar()   → Pausado
    [AccionPomodoro.FINALIZAR,   FasePomodoro.Completado],  // Finalizar()→ Completado
    [AccionPomodoro.SALTAR_FASE, FasePomodoro.EnDescanso],  // SaltarFase()→ EnDescanso
  ])],

  // EstadoPausado
  [FasePomodoro.Pausado, new Map([
    [AccionPomodoro.REANUDAR,    FasePomodoro.EnCurso],     // Reanudar() → EnCurso
    [AccionPomodoro.PAUSAR,      null],                     // Pausar()   → ❌ "Ya está pausado"
    [AccionPomodoro.FINALIZAR,   FasePomodoro.Completado],  // Finalizar()→ Completado
    [AccionPomodoro.SALTAR_FASE, FasePomodoro.EnDescanso],  // SaltarFase()→ EnDescanso
  ])],

  // EstadoEnDescanso
  [FasePomodoro.EnDescanso, new Map([
    [AccionPomodoro.REANUDAR,    null],                     // Reanudar() → ❌ "Ya estás en descanso"
    [AccionPomodoro.PAUSAR,      null],                     // Pausar()   → ❌ "No se puede pausar el descanso"
    [AccionPomodoro.FINALIZAR,   FasePomodoro.Completado],  // Finalizar()→ Completado
    [AccionPomodoro.SALTAR_FASE, FasePomodoro.Completado],  // SaltarFase()→ Completado
  ])],

  // EstadoCompletado (estado absorbente: ninguna acción es válida)
  [FasePomodoro.Completado, new Map([
    [AccionPomodoro.REANUDAR,    null],  // ❌ "Ya finalizó"
    [AccionPomodoro.PAUSAR,      null],  // ❌ "Ya finalizó"
    [AccionPomodoro.FINALIZAR,   null],  // ❌ "Ya finalizó"
    [AccionPomodoro.SALTAR_FASE, null],  // ❌ "Ya finalizó"
  ])],
]);

// ── Funciones de consulta ───────────────────────────────────────────────────

/**
 * Consulta si una acción es válida en la fase actual.
 * Útil para la UI: deshabilitar botones de acciones ilegales.
 *
 * @param {number} faseActual - FasePomodoro actual
 * @param {string} accion - AccionPomodoro a evaluar
 * @returns {boolean}
 */
export function esTransicionValida(faseActual, accion) {
  const accionesFase = TRANSITIONS.get(faseActual);
  if (!accionesFase) return false;

  const destino = accionesFase.get(accion);
  return destino !== null && destino !== undefined;
}

/**
 * Obtiene la fase resultante de aplicar una acción al estado actual.
 * Retorna null si la transición es inválida.
 *
 * @param {number} faseActual - FasePomodoro actual
 * @param {string} accion - AccionPomodoro a aplicar
 * @returns {number|null} FasePomodoro destino o null
 */
export function obtenerSiguienteFase(faseActual, accion) {
  const accionesFase = TRANSITIONS.get(faseActual);
  if (!accionesFase) return null;

  const destino = accionesFase.get(accion);
  return destino ?? null;
}
