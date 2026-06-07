import React, { useState, useEffect, useRef, useCallback } from "react";
import {
  obtenerPomodorosPorUsuario,
  crearPomodoro,
  eliminarPomodoro,
  ejecutarAccion,
} from "../services/pomodoroService";

// ══════════════════════════════════════════════════════════════════
// CONSTANTES — Mapa del patrón State del backend
// ══════════════════════════════════════════════════════════════════
const FASE = {
  PENDIENTE: 0,
  EN_CURSO: 1,
  PAUSADO: 2,
  EN_DESCANSO: 3,
  COMPLETADO: 4,
};

// ══════════════════════════════════════════════════════════════════
// SVG ICONS (sin cambios respecto al original)
// ══════════════════════════════════════════════════════════════════
const IconPlay = () => (
  <svg viewBox="0 0 20 20" fill="currentColor" width="20" height="20">
    <path d="M6.3 4.5a1 1 0 011.4 0l7 5.5a1 1 0 010 1.6l-7 5.5A1 1 0 016 16.5v-13a1 1 0 01.3-.7V4.5z" />
  </svg>
);
const IconPause = () => (
  <svg viewBox="0 0 20 20" fill="currentColor" width="20" height="20">
    <path d="M5 4h3v12H5zM12 4h3v12h-3z" />
  </svg>
);
const IconSkip = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.8" width="18" height="18">
    <path strokeLinecap="round" strokeLinejoin="round" d="M5 5l7 5-7 5V5zM15 5v10" />
  </svg>
);
const IconReset = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.8" width="18" height="18">
    <path strokeLinecap="round" strokeLinejoin="round" d="M4 10a6 6 0 106-6H7" />
    <path strokeLinecap="round" strokeLinejoin="round" d="M7 7L4 4 4 7" />
  </svg>
);
const IconConfig = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.6" width="18" height="18">
    <circle cx="10" cy="10" r="2.5" />
    <path strokeLinecap="round" d="M10 2v1.5M10 16.5V18M2 10h1.5M16.5 10H18M4.1 4.1l1.1 1.1M14.8 14.8l1.1 1.1M4.1 15.9l1.1-1.1M14.8 5.2l1.1-1.1" />
  </svg>
);
const IconCalendar = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="13" height="13">
    <rect x="3" y="4" width="14" height="13" rx="1.5" />
    <path strokeLinecap="round" d="M7 2v3M13 2v3M3 8h14" />
  </svg>
);
const IconTarget = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="12" height="12">
    <circle cx="10" cy="10" r="7" />
    <circle cx="10" cy="10" r="3.5" />
    <circle cx="10" cy="10" r="1" fill="currentColor" stroke="none" />
  </svg>
);
const IconCoffee = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="12" height="12">
    <path strokeLinecap="round" strokeLinejoin="round" d="M4 6h9v7a3 3 0 01-3 3H7a3 3 0 01-3-3V6z" />
    <path strokeLinecap="round" strokeLinejoin="round" d="M13 8h1.5a2 2 0 010 4H13" />
  </svg>
);
const IconTrash = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="15" height="15">
    <path strokeLinecap="round" strokeLinejoin="round" d="M4 5h12M8 5V3h4v2M6 5v11a1 1 0 001 1h6a1 1 0 001-1V5" />
    <path strokeLinecap="round" d="M8 9v4M12 9v4" />
  </svg>
);
const IconWarning = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="28" height="28">
    <path strokeLinecap="round" strokeLinejoin="round" d="M10 3L2 17h16L10 3z" />
    <path strokeLinecap="round" d="M10 9v4M10 14.5v.5" />
  </svg>
);
const IconEdit = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="14" height="14">
    <path strokeLinecap="round" strokeLinejoin="round" d="M13 3l4 4-9 9H4v-4l9-9z" />
  </svg>
);
const IconCheck = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="2" width="14" height="14">
    <path strokeLinecap="round" strokeLinejoin="round" d="M4 10l4 4 8-8" />
  </svg>
);
const IconClose = () => (
  <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="2" width="16" height="16">
    <path strokeLinecap="round" d="M5 5l10 10M15 5L5 15" />
  </svg>
);

// ══════════════════════════════════════════════════════════════════
// HELPERS
// ══════════════════════════════════════════════════════════════════
const formatearTiempo = (s) => {
  const mins = Math.floor(s / 60);
  const secs = s % 60;
  return `${mins}:${secs < 10 ? "0" : ""}${secs}`;
};

const formatearTiempoHistorial = (totalSegundos) => {
  const mins = Math.floor(totalSegundos / 60);
  const secs = totalSegundos % 60;
  if (mins === 0) return `${secs} seg`;
  if (secs === 0) return `${mins} min`;
  return `${mins}m ${secs}s`;
};

const mapearItemHistorial = (item) => ({
  id: item.idPomodoro,
  fecha: new Date(item.fecha).toLocaleDateString("es-ES", {
    day: "numeric",
    month: "long",
    year: "numeric",
  }),
  tiempoConcentrado: formatearTiempoHistorial(item.duracionEstudio),
  tiempoDescanso: formatearTiempoHistorial(item.duracionDescanso),
  estadoFase: item.estadoFase,
});

// Etiqueta legible para el badge de estado del historial
const etiquetaFase = (estadoFase) => {
  switch (estadoFase) {
    case FASE.PENDIENTE:    return "Iniciado";
    case FASE.EN_CURSO:     return "En Curso";
    case FASE.PAUSADO:      return "Pausado";
    case FASE.EN_DESCANSO:  return "En Descanso";
    case FASE.COMPLETADO:   return "Completado";
    default:                return "—";
  }
};

// ══════════════════════════════════════════════════════════════════
// COMPONENTE PRINCIPAL
// ══════════════════════════════════════════════════════════════════
const PomodoroTimer = () => {
  const idUsuario = parseInt(localStorage.getItem("idUsuario")) || 1;

  // ── CONFIGURACIÓN ──────────────────────────────────────────────
  const [tiempoSesion,   setTiempoSesion]   = useState(25);
  const [tiempoDescanso, setTiempoDescanso] = useState(5);
  const [ciclosTotales,  setCiclosTotales]  = useState(4);
  const [draftSesion,    setDraftSesion]    = useState(25);
  const [draftDescanso,  setDraftDescanso]  = useState(5);
  const [draftCiclos,    setDraftCiclos]    = useState(4);

  // ── TEMPORIZADOR (frontend-only, sin cambios) ──────────────────
  const [segundos,    setSegundos]    = useState(25 * 60);
  const [estaActivo,  setEstaActivo]  = useState(false);
  const [sesionActual, setSesionActual] = useState(1);
  const [esDescanso,  setEsDescanso]  = useState(false);

  // ── ACUMULADORES (calculados en frontend, enviados al guardar) ─
  const [segundosAcumuladosEstudio,  setSegundosAcumuladosEstudio]  = useState(0);
  const [segundosAcumuladosDescanso, setSegundosAcumuladosDescanso] = useState(0);

  // ── ESTADO DEL PATRÓN STATE ────────────────────────────────────
  // pomodoroActivo: { id, estadoFase } del pomodoro en curso en el backend.
  // Null si aún no se presionó Play en esta sesión.
  const [pomodoroActivo, setPomodoroActivo] = useState(null);

  // ── UI / MODALES ───────────────────────────────────────────────
  const [historial,          setHistorial]          = useState([]);
  const [isConfigModalOpen,  setIsConfigModalOpen]  = useState(false);
  const [isEditing,          setIsEditing]          = useState(false);
  const [isDeleteModalOpen,  setIsDeleteModalOpen]  = useState(false);
  const [itemToDelete,       setItemToDelete]       = useState(null);

  // Loading/error por operación para updates optimistas
  const [accionEnCurso,  setAccionEnCurso]  = useState(false);
  const [errorAccion,    setErrorAccion]    = useState(null);

  // Ref para no capturar valores stale en el useEffect del countdown
  const pomodoroActivoRef = useRef(pomodoroActivo);
  useEffect(() => { pomodoroActivoRef.current = pomodoroActivo; }, [pomodoroActivo]);

  // ── CARGA INICIAL ──────────────────────────────────────────────
  useEffect(() => {
    const cargarHistorial = async () => {
      try {
        const data = await obtenerPomodorosPorUsuario(idUsuario);
        setHistorial(data.map(mapearItemHistorial));
      } catch (err) {
        console.error("Error al cargar el historial:", err);
      }
    };
    cargarHistorial();
  }, []);

  // ══════════════════════════════════════════════════════════════
  // LÓGICA DEL COUNTDOWN (solo gestiona el tiempo, igual que antes)
  // ══════════════════════════════════════════════════════════════
  useEffect(() => {
    let intervalo = null;

    if (estaActivo && segundos > 0) {
      intervalo = setInterval(() => {
        setSegundos((s) => s - 1);
        if (esDescanso) {
          setSegundosAcumuladosDescanso((prev) => prev + 1);
        } else {
          setSegundosAcumuladosEstudio((prev) => prev + 1);
        }
      }, 1000);
    } else if (segundos === 0) {
      // El tiempo se agotó naturalmente → avanzar fase
      clearInterval(intervalo);
      manejarFinDeFase();
    } else {
      clearInterval(intervalo);
    }

    return () => clearInterval(intervalo);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [estaActivo, segundos, esDescanso, sesionActual, ciclosTotales]);

  // ══════════════════════════════════════════════════════════════
  // HELPERS DE ESTADO INTERNO
  // ══════════════════════════════════════════════════════════════
  const resetearEstadoLocal = () => {
    setEstaActivo(false);
    setEsDescanso(false);
    setSegundos(tiempoSesion * 60);
    setSesionActual(1);
    setSegundosAcumuladosEstudio(0);
    setSegundosAcumuladosDescanso(0);
    setPomodoroActivo(null);
    setErrorAccion(null);
  };

  // ══════════════════════════════════════════════════════════════
  // ACCIÓN: PLAY / PAUSE
  // ══════════════════════════════════════════════════════════════
  const manejarPlayPause = async () => {
    if (accionEnCurso) return;
    setErrorAccion(null);

    // ─ CASO 1: Primer play de la sesión → crear + iniciar ──────
    if (!pomodoroActivo) {
      setAccionEnCurso(true);
      // Update optimista: arrancamos el timer visualmente de inmediato
      setEstaActivo(true);
      try {
        // 1a. Crear el Pomodoro en estado Pendiente (estadoFase = 0)
        const nuevoPomodoro = await crearPomodoro({
          idUsuario,
          idMateria: null,   // General — sin materia vinculada por ahora
          idApunte:  null,
          fecha: new Date().toISOString(),
          duracionEstudio:  0,
          duracionDescanso: 0,
          estadoFase: FASE.PENDIENTE,
        });

        // 1b. Iniciar → transiciona a EnCurso
        const pomodoroIniciado = await ejecutarAccion(nuevoPomodoro.idPomodoro, "iniciar");
        setPomodoroActivo({
          id: pomodoroIniciado.idPomodoro,
          estadoFase: pomodoroIniciado.estadoFase,
        });
      } catch (err) {
        // Rollback optimista
        setEstaActivo(false);
        setErrorAccion(err.message);
        console.error("Error al iniciar pomodoro:", err);
      } finally {
        setAccionEnCurso(false);
      }
      return;
    }

    // ─ CASO 2: Ya hay un pomodoro activo → Pausar o Reanudar ───
    const accion = estaActivo ? "pausar" : "reanudar";

    // Update optimista
    setEstaActivo(!estaActivo);
    setAccionEnCurso(true);

    try {
      const pomodoroActualizado = await ejecutarAccion(pomodoroActivo.id, accion);
      setPomodoroActivo({
        id: pomodoroActualizado.idPomodoro,
        estadoFase: pomodoroActualizado.estadoFase,
      });
    } catch (err) {
      // Rollback
      setEstaActivo(estaActivo);
      setErrorAccion(err.message);
      console.error(`Error al ejecutar '${accion}':`, err);
    } finally {
      setAccionEnCurso(false);
    }
  };

  // ══════════════════════════════════════════════════════════════
  // ACCIÓN: SALTAR FASE (botón Skip)
  // ══════════════════════════════════════════════════════════════
  const manejarSaltarFase = useCallback(async () => {
    if (accionEnCurso) return;
    setErrorAccion(null);

    const pom = pomodoroActivoRef.current;

    if (!pom) {
      // Si no se inició aún, solo avanzamos la UI localmente
      avanzarFaseLocal();
      return;
    }

    setAccionEnCurso(true);

    // El backend determina si la siguiente fase es EnDescanso o Completado.
    // Nosotros actualizamos la UI optimistamente y sincronizamos con la respuesta.
    try {
      const pomodoroActualizado = await ejecutarAccion(pom.id, "saltarfase");
      const nuevaFase = pomodoroActualizado.estadoFase;

      if (nuevaFase === FASE.COMPLETADO) {
        await finalizarYGuardar(pom.id);
      } else if (nuevaFase === FASE.EN_DESCANSO) {
        // Entramos al descanso
        setEsDescanso(true);
        setSegundos(tiempoDescanso * 60);
        setEstaActivo(true);
        setPomodoroActivo({ id: pomodoroActualizado.idPomodoro, estadoFase: nuevaFase });
      }
    } catch (err) {
      setErrorAccion(err.message);
      console.error("Error al saltar fase:", err);
    } finally {
      setAccionEnCurso(false);
    }
  // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [accionEnCurso, tiempoDescanso, tiempoSesion, sesionActual, ciclosTotales,
      segundosAcumuladosEstudio, segundosAcumuladosDescanso, historial]);

  // ══════════════════════════════════════════════════════════════
  // ACCIÓN: FIN DE FASE (timer llega a 0 naturalmente)
  // ══════════════════════════════════════════════════════════════
  const manejarFinDeFase = async () => {
    const pom = pomodoroActivoRef.current;

    if (!pom) {
      avanzarFaseLocal();
      return;
    }

    try {
      const pomodoroActualizado = await ejecutarAccion(pom.id, "saltarfase");
      const nuevaFase = pomodoroActualizado.estadoFase;

      if (nuevaFase === FASE.COMPLETADO) {
        await finalizarYGuardar(pom.id);
      } else if (nuevaFase === FASE.EN_DESCANSO) {
        setEsDescanso(true);
        setSegundos(tiempoDescanso * 60);
        setEstaActivo(true);
        setPomodoroActivo({ id: pomodoroActualizado.idPomodoro, estadoFase: nuevaFase });
      }
    } catch (err) {
      // Si falla la API, igual avanzamos localmente para no "trabar" al usuario
      console.error("Error al notificar fin de fase al backend:", err);
      avanzarFaseLocal();
    }
  };

  // ── Avance de fase puramente local (fallback sin backend) ──────
  const avanzarFaseLocal = () => {
    if (!esDescanso) {
      setEsDescanso(true);
      setSegundos(tiempoDescanso * 60);
      setEstaActivo(true);
    } else {
      setEsDescanso(false);
      setSegundos(tiempoSesion * 60);
      if (sesionActual < ciclosTotales) {
        setSesionActual((s) => s + 1);
        setEstaActivo(true);
      } else {
        setEstaActivo(false);
        setSesionActual(1);
        alert("¡Completaste todos tus ciclos! (sin conexión al servidor)");
      }
    }
  };

  // ══════════════════════════════════════════════════════════════
  // FINALIZAR Y GUARDAR EN HISTORIAL
  // Llamado cuando el backend responde con estadoFase = Completado.
  // Actualiza la duracion acumulada en el backend con un PATCH-like
  // (re-usando el POST de creación que ya tiene el id correcto,
  //  o simplemente refrescando el historial desde el servidor).
  // ══════════════════════════════════════════════════════════════
  const finalizarYGuardar = async (idPomodoro) => {
    // El ciclo se completó — verificamos si hay más ciclos
    const esUltimoCiclo = sesionActual >= ciclosTotales;

    if (!esUltimoCiclo) {
      // Aún hay ciclos: reseteamos para el próximo (UI local)
      // El pomodoro actual quedó "Completado" en el backend.
      // Creamos uno nuevo en el próximo Play.
      setEsDescanso(false);
      setSegundos(tiempoSesion * 60);
      setSesionActual((s) => s + 1);
      setEstaActivo(false);
      setPomodoroActivo(null);
      setSegundosAcumuladosEstudio(0);
      setSegundosAcumuladosDescanso(0);

      // Refrescar historial para mostrar el pomodoro recién completado
      try {
        const data = await obtenerPomodorosPorUsuario(idUsuario);
        setHistorial(data.map(mapearItemHistorial));
      } catch (err) {
        console.error("Error al refrescar historial:", err);
      }
      return;
    }

    // Es el último ciclo: cerramos todo y mostramos el historial actualizado
    setEstaActivo(false);
    setSesionActual(1);
    setEsDescanso(false);
    setSegundos(tiempoSesion * 60);
    setSegundosAcumuladosEstudio(0);
    setSegundosAcumuladosDescanso(0);
    setPomodoroActivo(null);

    // Refrescar historial desde el servidor (incluye el pomodoro recién completado)
    try {
      const data = await obtenerPomodorosPorUsuario(idUsuario);
      setHistorial(data.map(mapearItemHistorial));
    } catch (err) {
      console.error("Error al refrescar historial:", err);
    }

    alert("¡Felicidades! Completaste todos tus ciclos y quedó registrado en tu historial.");
  };

  // ══════════════════════════════════════════════════════════════
  // ACCIÓN: RESET
  // Finaliza el pomodoro activo en el backend si existe, y resetea la UI.
  // ══════════════════════════════════════════════════════════════
  const resetearReloj = async () => {
    if (pomodoroActivo) {
      try {
        // Intentamos finalizar el pomodoro en el backend (sesión abandonada)
        await ejecutarAccion(pomodoroActivo.id, "finalizar");
        // Refrescar historial para mostrar el pomodoro abandonado
        const data = await obtenerPomodorosPorUsuario(idUsuario);
        setHistorial(data.map(mapearItemHistorial));
      } catch (err) {
        // Si ya estaba en un estado que no permite finalizar (ej. Completado), ignoramos
        console.warn("No se pudo finalizar el pomodoro al resetear:", err.message);
      }
    }
    resetearEstadoLocal();
  };

  // ══════════════════════════════════════════════════════════════
  // HISTORIAL — ELIMINAR
  // ══════════════════════════════════════════════════════════════
  const intentarEliminar = (id) => {
    setItemToDelete(id);
    setIsDeleteModalOpen(true);
  };

  const confirmarEliminacion = async () => {
    try {
      await eliminarPomodoro(itemToDelete);
      setHistorial((prev) => prev.filter((item) => item.id !== itemToDelete));
      setIsDeleteModalOpen(false);
      setItemToDelete(null);
    } catch (err) {
      console.error("Error al eliminar pomodoro:", err);
      alert("Hubo un error al borrar el registro. Intentá de nuevo.");
    }
  };

  const cancelarEliminacion = () => {
    setIsDeleteModalOpen(false);
    setItemToDelete(null);
  };

  // ══════════════════════════════════════════════════════════════
  // MODAL CONFIG
  // ══════════════════════════════════════════════════════════════
  const abrirConfig = () => { setIsEditing(false); setIsConfigModalOpen(true); };
  const cerrarConfig = () => { setIsConfigModalOpen(false); setIsEditing(false); };

  const activarModoEdicion = () => {
    if (!isEditing) {
      setDraftSesion(tiempoSesion);
      setDraftDescanso(tiempoDescanso);
      setDraftCiclos(ciclosTotales);
    } else {
      setTiempoSesion(draftSesion);
      setTiempoDescanso(draftDescanso);
      setCiclosTotales(draftCiclos);
    }
    setIsEditing(!isEditing);
  };

  const aplicarConfiguracion = async () => {
    // Si hay un pomodoro activo, lo finalizamos antes de resetear
    if (pomodoroActivo) {
      try {
        await ejecutarAccion(pomodoroActivo.id, "finalizar");
      } catch (err) {
        console.warn("No se pudo finalizar el pomodoro al cambiar config:", err.message);
      }
    }
    setEstaActivo(false);
    setEsDescanso(false);
    setSegundos(tiempoSesion * 60);
    setSesionActual(1);
    setIsEditing(false);
    setIsConfigModalOpen(false);
    setSegundosAcumuladosEstudio(0);
    setSegundosAcumuladosDescanso(0);
    setPomodoroActivo(null);
    setErrorAccion(null);
  };

  // ══════════════════════════════════════════════════════════════
  // CÁLCULOS SVG (sin cambios)
  // ══════════════════════════════════════════════════════════════
  const radio = 110;
  const circunferencia = 2 * Math.PI * radio;
  const tiempoTotalFaseActual = esDescanso ? tiempoDescanso * 60 : tiempoSesion * 60;
  const porcentaje = segundos / tiempoTotalFaseActual;
  const offset = circunferencia - porcentaje * circunferencia;
  const colorActivo = esDescanso ? "#219653" : "#3A56AF";
  const bgBadge    = esDescanso ? "#E5F6ED" : "#EEF1FF";
  const colorBadge = esDescanso ? "#219653" : "#3A56AF";

  // ── Derivado del estadoFase del backend para el label del badge ─
  const labelEstado = () => {
    if (!pomodoroActivo) return esDescanso ? "Tiempo de Descanso" : "Sesión de Trabajo";
    switch (pomodoroActivo.estadoFase) {
      case FASE.PENDIENTE:   return "Listo para iniciar";
      case FASE.EN_CURSO:    return "Sesión de Trabajo";
      case FASE.PAUSADO:     return "Pausado";
      case FASE.EN_DESCANSO: return "Tiempo de Descanso";
      case FASE.COMPLETADO:  return "Completado";
      default:               return "Sesión de Trabajo";
    }
  };

  // ── Protección de botones según el estado del backend ──────────
  const puedePausar    = pomodoroActivo?.estadoFase === FASE.EN_CURSO;
  const puedeReanudar  = pomodoroActivo?.estadoFase === FASE.PAUSADO;
  const puedeSkip      = pomodoroActivo
    ? pomodoroActivo.estadoFase !== FASE.COMPLETADO
    : true;
  const playPauseBloqueado = accionEnCurso ||
    pomodoroActivo?.estadoFase === FASE.COMPLETADO ||
    pomodoroActivo?.estadoFase === FASE.EN_DESCANSO;

  // ══════════════════════════════════════════════════════════════
  // RENDER
  // ══════════════════════════════════════════════════════════════
  return (
    <>
      <style>{`
        .pom-root * { box-sizing: border-box; }
        .pom-root {
          font-family: 'IBM Plex Sans', 'Helvetica Neue', sans-serif;
          width: 100%;
          min-height: 100%;
          display: flex;
          justify-content: center;
          padding: 36px 24px 48px;
        }
        .pom-inner {
          width: 100%;
          max-width: 520px;
          display: flex;
          flex-direction: column;
          align-items: center;
        }
        .session-badge {
          display: inline-flex;
          align-items: center;
          padding: 5px 14px;
          border-radius: 4px;
          font-size: 0.7rem;
          font-weight: 700;
          letter-spacing: 0.08em;
          text-transform: uppercase;
          margin-bottom: 20px;
          transition: background-color 0.4s, color 0.4s;
        }
        .session-counter {
          background-color: #EEF1FF;
          color: #3A56AF;
          padding: 4px 14px;
          border-radius: 4px;
          font-size: 0.82rem;
          font-weight: 700;
          margin-bottom: 28px;
        }
        .timer-circle-wrap {
          position: relative;
          width: 240px;
          height: 240px;
          display: flex;
          justify-content: center;
          align-items: center;
          margin-bottom: 28px;
        }
        .timer-svg { transform: rotate(-90deg); }
        .time-display {
          position: absolute;
          display: flex;
          flex-direction: column;
          align-items: center;
        }
        .clock-text {
          font-family: 'IBM Plex Mono', monospace;
          font-size: 3.8rem;
          font-weight: 300;
          letter-spacing: -2px;
          line-height: 1;
          transition: color 0.4s;
        }
        .status-label {
          font-size: 0.68rem;
          color: #9EA5BA;
          font-weight: 700;
          letter-spacing: 0.12em;
          text-transform: uppercase;
          margin-top: 8px;
        }
        .controls-row {
          display: flex;
          align-items: center;
          gap: 8px;
          background-color: white;
          padding: 12px 24px;
          border-radius: 8px;
          border: 1px solid #E8EBFF;
          margin-bottom: 12px;
        }
        .ctrl-icon-btn {
          background: none;
          border: none;
          color: #B0B7CF;
          cursor: pointer;
          padding: 8px;
          display: flex;
          align-items: center;
          justify-content: center;
          border-radius: 6px;
          transition: color 0.15s, background-color 0.15s;
        }
        .ctrl-icon-btn:hover:not(:disabled) { color: #3A56AF; background-color: #F0F3FF; }
        .ctrl-icon-btn:disabled { opacity: 0.35; cursor: not-allowed; }
        .play-btn {
          width: 52px;
          height: 52px;
          border-radius: 8px;
          border: none;
          background-color: #3A56AF;
          color: white;
          cursor: pointer;
          display: flex;
          justify-content: center;
          align-items: center;
          box-shadow: 0 4px 14px rgba(58, 86, 175, 0.25);
          transition: background-color 0.15s, opacity 0.15s;
          margin: 0 8px;
        }
        .play-btn:hover:not(:disabled) { background-color: #2F469A; }
        .play-btn:disabled { opacity: 0.4; cursor: not-allowed; }

        /* Spinner de carga para acciones API */
        .action-loading {
          font-size: 0.75rem;
          color: #9EA5BA;
          margin-bottom: 20px;
          height: 16px;
          display: flex;
          align-items: center;
          gap: 6px;
        }
        .spinner {
          width: 10px;
          height: 10px;
          border: 2px solid #D0D7F0;
          border-top-color: #3A56AF;
          border-radius: 50%;
          animation: spin 0.7s linear infinite;
        }
        @keyframes spin { to { transform: rotate(360deg); } }

        /* Mensaje de error */
        .error-msg {
          font-size: 0.78rem;
          color: #E53E3E;
          background: #FFF5F5;
          border: 1px solid #FED7D7;
          border-radius: 4px;
          padding: 6px 12px;
          margin-bottom: 16px;
          width: 100%;
          text-align: center;
        }

        .history-section { width: 100%; margin-bottom: 36px; margin-top: 8px; }
        .history-header {
          display: flex;
          align-items: center;
          justify-content: space-between;
          margin-bottom: 12px;
        }
        .history-title {
          font-size: 0.88rem;
          font-weight: 700;
          color: #2D3247;
          letter-spacing: -0.01em;
        }
        .history-list {
          max-height: 220px;
          overflow-y: auto;
          display: flex;
          flex-direction: column;
          gap: 8px;
        }
        .empty-history {
          text-align: center;
          color: #B0B7CF;
          font-size: 0.88rem;
          padding: 24px 0;
          font-style: italic;
        }
        .history-card {
          display: flex;
          justify-content: space-between;
          align-items: center;
          background-color: white;
          padding: 13px 16px;
          border-radius: 6px;
          border: 1px solid #EEF1FF;
        }
        .history-info { display: flex; flex-direction: column; gap: 7px; }
        .history-date {
          display: flex;
          align-items: center;
          gap: 6px;
          font-size: 0.85rem;
          font-weight: 600;
          color: #2D3247;
        }
        .history-date svg { color: #9EA5BA; }
        .history-times { display: flex; gap: 8px; align-items: center; flex-wrap: wrap; }
        .time-badge-focus {
          display: inline-flex;
          align-items: center;
          gap: 5px;
          background-color: #EEF1FF;
          color: #3A56AF;
          padding: 3px 9px;
          border-radius: 4px;
          font-size: 0.72rem;
          font-weight: 700;
        }
        .time-badge-break {
          display: inline-flex;
          align-items: center;
          gap: 5px;
          background-color: #E5F6ED;
          color: #219653;
          padding: 3px 9px;
          border-radius: 4px;
          font-size: 0.72rem;
          font-weight: 700;
        }
        /* Badge de estadoFase en el historial */
        .fase-badge {
          font-size: 0.62rem;
          font-weight: 700;
          letter-spacing: 0.05em;
          padding: 2px 7px;
          border-radius: 3px;
          text-transform: uppercase;
          background-color: #F0F3FF;
          color: #9EA5BA;
        }
        .fase-badge.completado { background-color: #EEF1FF; color: #3A56AF; }
        .fase-badge.pausado    { background-color: #FFF8E1; color: #D68910; }
        .delete-btn {
          background: none;
          border: none;
          color: #C8CEDE;
          cursor: pointer;
          padding: 6px;
          display: flex;
          align-items: center;
          border-radius: 4px;
          transition: color 0.15s, background-color 0.15s;
          flex-shrink: 0;
        }
        .delete-btn:hover { color: #E53E3E; background-color: #FFF5F5; }
        .quote-section {
          text-align: center;
          padding-top: 20px;
          width: 100%;
        }
        .quote-line {
          width: 32px;
          height: 1px;
          background-color: #E8EBFF;
          margin: 0 auto 20px;
        }
        .quote-text {
          font-style: italic;
          color: #B0B7CF;
          font-size: 0.9rem;
          max-width: 420px;
          margin: 0 auto 8px;
          line-height: 1.6;
        }
        .quote-author {
          font-size: 0.68rem;
          font-weight: 700;
          color: #C8CEDE;
          letter-spacing: 0.1em;
          text-transform: uppercase;
        }

        /* ── MODALES ── */
        .modal-overlay {
          position: fixed;
          top: 0; left: 0; right: 0; bottom: 0;
          background-color: rgba(45, 50, 71, 0.4);
          backdrop-filter: blur(3px);
          display: flex;
          justify-content: center;
          align-items: center;
          z-index: 1000;
        }
        .modal-content {
          background-color: white;
          width: 100%;
          max-width: 440px;
          border-radius: 8px;
          padding: 32px;
          box-shadow: 0 16px 40px rgba(0,0,0,0.12);
        }
        .modal-header {
          display: flex;
          justify-content: space-between;
          align-items: flex-start;
          margin-bottom: 24px;
        }
        .modal-title {
          font-size: 1.2rem;
          font-weight: 700;
          color: #2D3247;
          margin: 0 0 4px 0;
          letter-spacing: -0.02em;
        }
        .modal-subtitle { font-size: 0.83rem; color: #9EA5BA; margin: 0; }
        .close-modal-btn {
          background: none;
          border: none;
          color: #9EA5BA;
          cursor: pointer;
          padding: 4px;
          display: flex;
          align-items: center;
          border-radius: 4px;
        }
        .close-modal-btn:hover { color: #2D3247; }
        .preset-card {
          background-color: #F6F8FE;
          border-radius: 6px;
          border: 1px solid #E8EBFF;
          padding: 20px;
          margin-bottom: 16px;
        }
        .preset-header {
          display: flex;
          justify-content: space-between;
          align-items: center;
          margin-bottom: 20px;
        }
        .preset-title-wrap { display: flex; align-items: center; gap: 8px; }
        .preset-name { font-size: 0.88rem; font-weight: 700; color: #3A56AF; }
        .badge-recomendado {
          background-color: #D6E0FF;
          color: #3A56AF;
          padding: 3px 9px;
          border-radius: 4px;
          font-size: 0.62rem;
          font-weight: 800;
          letter-spacing: 0.05em;
        }
        .preset-grid {
          display: grid;
          grid-template-columns: 1fr 1fr;
          gap: 16px;
        }
        .grid-item-center { text-align: center; }
        .ciclos-wrap { grid-column: span 2; text-align: center; }
        .preset-label {
          font-size: 0.62rem;
          color: #9EA5BA;
          font-weight: 700;
          letter-spacing: 0.08em;
          text-transform: uppercase;
          margin: 0 0 6px 0;
        }
        .preset-value {
          font-size: 1.05rem;
          font-weight: 700;
          color: #2D3247;
          margin: 0;
          font-family: 'IBM Plex Mono', monospace;
        }
        .input-edit {
          width: 64px;
          text-align: center;
          padding: 5px 8px;
          font-size: 1rem;
          font-weight: 700;
          color: #2D3247;
          border: 1px solid #D0D7F0;
          border-radius: 5px;
          background-color: white;
          outline: none;
          font-family: 'IBM Plex Mono', monospace;
        }
        .edit-preset-btn {
          width: 100%;
          background-color: transparent;
          border: 1.5px dashed #D0D7F0;
          border-radius: 6px;
          padding: 12px;
          color: #9EA5BA;
          font-size: 0.87rem;
          font-weight: 600;
          font-family: inherit;
          cursor: pointer;
          display: flex;
          justify-content: center;
          align-items: center;
          gap: 8px;
          margin-bottom: 24px;
          transition: border-color 0.15s, color 0.15s;
        }
        .edit-preset-btn:hover { border-color: #3A56AF; color: #3A56AF; }
        .modal-actions { display: flex; flex-direction: column; gap: 12px; }
        .btn-aplicar {
          width: 100%;
          background-color: #3A56AF;
          color: white;
          border: none;
          border-radius: 6px;
          padding: 13px;
          font-size: 0.93rem;
          font-weight: 600;
          font-family: inherit;
          cursor: pointer;
          box-shadow: 0 2px 8px rgba(58, 86, 175, 0.22);
        }
        .btn-aplicar:hover { background-color: #2F469A; }
        .btn-cancelar {
          width: 100%;
          background: none;
          border: none;
          color: #9EA5BA;
          font-size: 0.87rem;
          font-weight: 500;
          font-family: inherit;
          cursor: pointer;
          padding: 4px;
        }
        .delete-modal-content {
          background-color: white;
          width: 100%;
          max-width: 360px;
          border-radius: 8px;
          padding: 32px 28px;
          box-shadow: 0 16px 40px rgba(0,0,0,0.14);
          display: flex;
          flex-direction: column;
          align-items: center;
          text-align: center;
        }
        .delete-icon-wrap {
          width: 52px;
          height: 52px;
          border-radius: 8px;
          background-color: #FFF5F5;
          border: 1px solid #FED7D7;
          display: flex;
          align-items: center;
          justify-content: center;
          color: #E53E3E;
          margin-bottom: 16px;
        }
        .delete-modal-title {
          font-size: 1.1rem;
          font-weight: 700;
          color: #2D3247;
          margin: 0 0 8px 0;
        }
        .delete-modal-subtitle {
          font-size: 0.85rem;
          color: #9EA5BA;
          margin: 0 0 24px 0;
          line-height: 1.5;
        }
        .delete-modal-actions { display: flex; width: 100%; gap: 12px; }
        .btn-cancelar-borrado {
          flex: 1;
          background-color: #F0F3FF;
          color: #3A56AF;
          border: none;
          border-radius: 6px;
          padding: 11px;
          font-size: 0.9rem;
          font-weight: 600;
          font-family: inherit;
          cursor: pointer;
        }
        .btn-confirmar-borrado {
          flex: 1;
          background-color: #E53E3E;
          color: white;
          border: none;
          border-radius: 6px;
          padding: 11px;
          font-size: 0.9rem;
          font-weight: 600;
          font-family: inherit;
          cursor: pointer;
          box-shadow: 0 2px 8px rgba(229, 62, 62, 0.25);
        }
      `}</style>

      <div className="pom-root">
        <div className="pom-inner">

          {/* Badge de estado (ahora refleja estadoFase del backend) */}
          <span
            className="session-badge"
            style={{ backgroundColor: bgBadge, color: colorBadge }}
          >
            {labelEstado()}
          </span>

          <div className="session-counter">
            Ciclo {sesionActual} de {ciclosTotales}
          </div>

          {/* Círculo temporizador */}
          <div className="timer-circle-wrap">
            <svg width="240" height="240" className="timer-svg">
              <circle cx="120" cy="120" r={radio} stroke="#E8EBFF" strokeWidth="7" fill="transparent" />
              <circle
                cx="120" cy="120" r={radio}
                stroke={colorActivo}
                strokeWidth="7"
                fill="transparent"
                strokeDasharray={circunferencia}
                strokeDashoffset={offset}
                strokeLinecap="round"
                style={{ transition: "stroke-dashoffset 1s linear, stroke 0.4s ease" }}
              />
            </svg>
            <div className="time-display">
              <div className="clock-text" style={{ color: colorActivo }}>
                {formatearTiempo(segundos)}
              </div>
              <div className="status-label">
                {accionEnCurso ? "Sincronizando…" : estaActivo ? "En curso" : "Pausado"}
              </div>
            </div>
          </div>

          {/* Indicador de operación en vuelo */}
          <div className="action-loading">
            {accionEnCurso && (
              <>
                <span className="spinner" />
                <span>Sincronizando con el servidor…</span>
              </>
            )}
          </div>

          {/* Mensaje de error de acción */}
          {errorAccion && (
            <div className="error-msg">
              ⚠ {errorAccion}
            </div>
          )}

          {/* Controles */}
          <div className="controls-row">
            <button className="ctrl-icon-btn" onClick={abrirConfig} title="Configuración">
              <IconConfig />
            </button>

            {/* Play / Pause — deshabilitado durante EnDescanso y Completado */}
            <button
              className="play-btn"
              onClick={manejarPlayPause}
              disabled={playPauseBloqueado}
              title={estaActivo ? "Pausar" : "Iniciar / Reanudar"}
            >
              {estaActivo ? <IconPause /> : <IconPlay />}
            </button>

            {/* Skip — deshabilitado si el pomodoro ya está Completado */}
            <button
              className="ctrl-icon-btn"
              onClick={manejarSaltarFase}
              disabled={accionEnCurso || !puedeSkip}
              title="Saltar fase"
            >
              <IconSkip />
            </button>

            <button className="ctrl-icon-btn" onClick={resetearReloj} title="Reiniciar">
              <IconReset />
            </button>
          </div>

          {/* Historial */}
          <div className="history-section">
            <div className="history-header">
              <span className="history-title">Historial de Enfoque</span>
            </div>
            <div className="history-list">
              {historial.length === 0 ? (
                <p className="empty-history">No hay sesiones registradas aún.</p>
              ) : (
                historial.map((item) => (
                  <div key={item.id} className="history-card">
                    <div className="history-info">
                      <div className="history-date">
                        <IconCalendar />
                        {item.fecha}
                      </div>
                      <div className="history-times">
                        <span className="time-badge-focus">
                          <IconTarget /> {item.tiempoConcentrado}
                        </span>
                        <span className="time-badge-break">
                          <IconCoffee /> {item.tiempoDescanso}
                        </span>
                        {/* Badge de estadoFase — NUEVO */}
                        {item.estadoFase !== undefined && (
                          <span className={`fase-badge ${
                            item.estadoFase === FASE.COMPLETADO ? "completado" :
                            item.estadoFase === FASE.PAUSADO    ? "pausado"    : ""
                          }`}>
                            {etiquetaFase(item.estadoFase)}
                          </span>
                        )}
                      </div>
                    </div>
                    <button
                      className="delete-btn"
                      onClick={() => intentarEliminar(item.id)}
                      title="Eliminar registro"
                    >
                      <IconTrash />
                    </button>
                  </div>
                ))
              )}
            </div>
          </div>

          {/* Cita */}
          <footer className="quote-section">
            <div className="quote-line" />
            <p className="quote-text">La profundidad de tu enfoque determina el nivel de tu maestría.</p>
            <p className="quote-author">Filosofía StudIA</p>
          </footer>

          {/* ── MODAL CONFIGURACIÓN ── */}
          {isConfigModalOpen && (
            <div className="modal-overlay">
              <div className="modal-content">
                <div className="modal-header">
                  <div>
                    <h3 className="modal-title">Configuración Pomodoro</h3>
                    <p className="modal-subtitle">Ajusta tu sesión de trabajo profundo.</p>
                  </div>
                  <button className="close-modal-btn" onClick={cerrarConfig}><IconClose /></button>
                </div>
                <div className="preset-card">
                  <div className="preset-header">
                    <div className="preset-title-wrap">
                      <IconConfig />
                      <span className="preset-name">Configuración activa</span>
                    </div>
                    <span className="badge-recomendado">RECOMENDADA</span>
                  </div>
                  <div className="preset-grid">
                    <div className="grid-item-center">
                      <p className="preset-label">Sesión (min)</p>
                      {isEditing
                        ? <input type="number" value={draftSesion} onChange={(e) => setDraftSesion(Number(e.target.value))} className="input-edit" min="1" />
                        : <p className="preset-value">{tiempoSesion}</p>}
                    </div>
                    <div className="grid-item-center">
                      <p className="preset-label">Descanso (min)</p>
                      {isEditing
                        ? <input type="number" value={draftDescanso} onChange={(e) => setDraftDescanso(Number(e.target.value))} className="input-edit" min="1" />
                        : <p className="preset-value">{tiempoDescanso}</p>}
                    </div>
                    <div className="ciclos-wrap">
                      <p className="preset-label">Ciclos</p>
                      {isEditing
                        ? <input type="number" value={draftCiclos} onChange={(e) => setDraftCiclos(Number(e.target.value))} className="input-edit" min="1" />
                        : <p className="preset-value">{ciclosTotales}</p>}
                    </div>
                  </div>
                </div>
                <button className="edit-preset-btn" onClick={activarModoEdicion}>
                  {isEditing ? <IconCheck /> : <IconEdit />}
                  {isEditing ? "Confirmar valores" : "Editar preajuste"}
                </button>
                <div className="modal-actions">
                  <button className="btn-aplicar" onClick={aplicarConfiguracion}>Aplicar configuración</button>
                  <button className="btn-cancelar" onClick={cerrarConfig}>Cancelar</button>
                </div>
              </div>
            </div>
          )}

          {/* ── MODAL BORRADO ── */}
          {isDeleteModalOpen && (
            <div className="modal-overlay">
              <div className="delete-modal-content">
                <div className="delete-icon-wrap"><IconWarning /></div>
                <h3 className="delete-modal-title">¿Eliminar registro?</h3>
                <p className="delete-modal-subtitle">
                  Esta acción eliminará el registro de tu historial y no se puede deshacer.
                </p>
                <div className="delete-modal-actions">
                  <button className="btn-cancelar-borrado" onClick={cancelarEliminacion}>Cancelar</button>
                  <button className="btn-confirmar-borrado" onClick={confirmarEliminacion}>Eliminar</button>
                </div>
              </div>
            </div>
          )}

        </div>
      </div>
    </>
  );
};

export default PomodoroTimer;
