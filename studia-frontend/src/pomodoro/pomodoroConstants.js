/**
 * pomodoroConstants.js
 *
 * Enums y constantes que replican 1:1 el contrato del backend C#.
 * Ver: StudIA.Data.Entities.Pomodoro.cs
 */

// ── FasePomodoro ────────────────────────────────────────────────────────────
// Espejo del enum FasePomodoro de C#. Los valores numéricos coinciden
// con los que persiste el backend en la columna `estado_fase`.
export const FasePomodoro = Object.freeze({
  Pendiente:  0,
  EnCurso:    1,
  Pausado:    2,
  EnDescanso: 3,
  Completado: 4,
});

// ── AccionPomodoro ──────────────────────────────────────────────────────────
// Las 4 acciones que acepta el endpoint:
// POST /api/Pomodoros/{id}/accion/{tipoAccion}
// Los strings coinciden exactamente con lo que espera el switch del backend.
export const AccionPomodoro = Object.freeze({
  REANUDAR:    'reanudar',
  PAUSAR:      'pausar',
  FINALIZAR:   'finalizar',
  SALTAR_FASE: 'saltarfase',
});

// ── Etiquetas de UI ─────────────────────────────────────────────────────────
// Textos legibles para mostrar en badges, tooltips, status labels, etc.
export const EtiquetaFase = Object.freeze({
  [FasePomodoro.Pendiente]:  'Pendiente',
  [FasePomodoro.EnCurso]:    'En curso',
  [FasePomodoro.Pausado]:    'Pausado',
  [FasePomodoro.EnDescanso]: 'En descanso',
  [FasePomodoro.Completado]: 'Completado',
});
