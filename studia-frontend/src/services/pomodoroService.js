const RAW_BASE_URL = import.meta.env.VITE_API_URL || "https://localhost:7068";

const API_BASE_URL = RAW_BASE_URL.endsWith("/api")
  ? RAW_BASE_URL
  : `${RAW_BASE_URL}/api`;

async function handleResponse(response) {
  if (response.ok) {
    if (response.status === 204) return true;
    return response.json();
  }

  let mensaje = `Error ${response.status}`;

  try {
    const body = await response.json();
    mensaje = body.error || body.mensaje || mensaje;
  } catch {
    try {
      const text = await response.text();
      mensaje = text || mensaje;
    } catch {
      // Se mantiene el mensaje genérico.
    }
  }

  throw new Error(mensaje);
}

export async function obtenerPomodorosPorUsuario(idUsuario) {
  const response = await fetch(
    `${API_BASE_URL}/Pomodoros/usuario/${idUsuario}`
  );

  return handleResponse(response);
}

export async function crearPomodoro(datosPomodoro) {
  const response = await fetch(`${API_BASE_URL}/Pomodoros`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(datosPomodoro),
  });

  return handleResponse(response);
}

export async function eliminarPomodoro(idPomodoro) {
  const response = await fetch(`${API_BASE_URL}/Pomodoros/${idPomodoro}`, {
    method: "DELETE",
  });

  return handleResponse(response);
}

export async function ejecutarAccion(idPomodoro, tipoAccion, duraciones = {}) {
  const body = {};

  if (duraciones.duracionEstudio !== undefined) {
    body.duracionEstudio = Number(duraciones.duracionEstudio) || 0;
  }

  if (duraciones.duracionDescanso !== undefined) {
    body.duracionDescanso = Number(duraciones.duracionDescanso) || 0;
  }

  const response = await fetch(
    `${API_BASE_URL}/Pomodoros/${idPomodoro}/accion/${tipoAccion}`,
    {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(body),
    }
  );

  return handleResponse(response);
}

export async function actualizarPomodoro(idPomodoro, datosActualizados) {
  const response = await fetch(`${API_BASE_URL}/Pomodoros/${idPomodoro}`, {
    method: "PUT",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(datosActualizados),
  });

  return handleResponse(response);
}