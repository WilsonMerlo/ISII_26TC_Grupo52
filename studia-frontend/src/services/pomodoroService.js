// ─────────────────────────────────────────────────────────────────────────────
// pomodoroService.js
// Capa de servicio para la API de Pomodoros — StudIA
//
// Centraliza TODAS las llamadas HTTP al backend. El componente PomodoroTimer
// no debe tener ningún `fetch` directo; siempre usa estas funciones.
//
// Patrón State del backend — acciones disponibles:
//   "iniciar"    → Pendiente  → EnCurso
//   "pausar"     → EnCurso   → Pausado
//   "reanudar"   → Pausado   → EnCurso
//   "saltarfase" → EnCurso / Pausado → EnDescanso  |  EnDescanso → Completado
//   "finalizar"  → EnCurso / Pausado / EnDescanso → Completado
// ─────────────────────────────────────────────────────────────────────────────

const BASE_URL = import.meta.env.VITE_API_URL || "https://localhost:7068";

// Helper interno: lanza un error claro si la respuesta no es OK.
// Para acciones del State Pattern, captura el mensaje de error del backend
// (400 Bad Request cuando la transición es ilegal).
async function handleResponse(response) {
  if (response.ok) {
    // 204 No Content (DELETE exitoso) no tiene cuerpo
    if (response.status === 204) return true;
    return response.json();
  }

  // El backend devuelve { error: "mensaje" } en los 400
  let mensaje = `Error ${response.status}`;
  try {
    const body = await response.json();
    mensaje = body.error || body.mensaje || mensaje;
  } catch {
    // si el cuerpo no es JSON, usamos el mensaje genérico
  }
  throw new Error(mensaje);
}

// ─────────────────────────────────────────────────────────────────
// GET /api/Pomodoros/usuario/{idUsuario}
// Devuelve el historial de pomodoros del usuario, ordenado por fecha DESC.
// ─────────────────────────────────────────────────────────────────
export async function obtenerPomodorosPorUsuario(idUsuario) {
  const response = await fetch(
    `${BASE_URL}/api/Pomodoros/usuario/${idUsuario}`
  );
  return handleResponse(response);
}

// ─────────────────────────────────────────────────────────────────
// POST /api/Pomodoros
// Crea un nuevo pomodoro en estado "Pendiente" (estadoFase: 0).
// El body debe incluir: idUsuario, idMateria (opcional), idApunte (opcional),
// fecha, duracionEstudio, duracionDescanso, estadoFase.
// ─────────────────────────────────────────────────────────────────
export async function crearPomodoro(datosPomodoro) {
  const response = await fetch(`${BASE_URL}/api/Pomodoros`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(datosPomodoro),
  });
  return handleResponse(response);
}

// ─────────────────────────────────────────────────────────────────
// DELETE /api/Pomodoros/{id}
// Elimina un registro del historial. Devuelve `true` si tuvo éxito.
// ─────────────────────────────────────────────────────────────────
export async function eliminarPomodoro(idPomodoro) {
  const response = await fetch(`${BASE_URL}/api/Pomodoros/${idPomodoro}`, {
    method: "DELETE",
  });
  return handleResponse(response); // true (204) o lanza Error
}

// ─────────────────────────────────────────────────────────────────
// POST /api/Pomodoros/{id}/accion/{tipoAccion}
// Ejecuta una transición del patrón State en el backend.
// Si la transición es ilegal, el backend responde 400 y esta función lanza Error.
// ─────────────────────────────────────────────────────────────────
export async function ejecutarAccion(idPomodoro, tipoAccion) {
  const response = await fetch(
    `${BASE_URL}/api/Pomodoros/${idPomodoro}/accion/${tipoAccion}`,
    { method: "POST" }
  );
  return handleResponse(response); // devuelve el Pomodoro actualizado
}