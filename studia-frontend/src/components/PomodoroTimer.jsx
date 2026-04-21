import React, { useState, useEffect } from 'react';

// ── SVG ICONS ──────────────────────────────────────────────────────────────
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

// ──────────────────────────────────────────────────────────────────────────

const PomodoroTimer = () => {
    // --- ESTADOS DE CONFIGURACIÓN ---
    const [tiempoSesion, setTiempoSesion] = useState(25);
    const [tiempoDescanso, setTiempoDescanso] = useState(5);
    const [ciclosTotales, setCiclosTotales] = useState(4);

    const [draftSesion, setDraftSesion] = useState(25);
    const [draftDescanso, setDraftDescanso] = useState(5);
    const [draftCiclos, setDraftCiclos] = useState(4);

    // --- ESTADOS DEL TEMPORIZADOR ---
    const [segundos, setSegundos] = useState(tiempoSesion * 60);
    const [estaActivo, setEstaActivo] = useState(false);
    const [sesionActual, setSesionActual] = useState(1);
    const [esDescanso, setEsDescanso] = useState(false);

    // --- ACUMULADORES DE TIEMPO REAL ---
    const [segundosAcumuladosEstudio, setSegundosAcumuladosEstudio] = useState(0);
    const [segundosAcumuladosDescanso, setSegundosAcumuladosDescanso] = useState(0);

    // --- ESTADOS DE MODALES ---
    const [isConfigModalOpen, setIsConfigModalOpen] = useState(false);
    const [isEditing, setIsEditing] = useState(false);

    const [isDeleteModalOpen, setIsDeleteModalOpen] = useState(false);
    const [itemToDelete, setItemToDelete] = useState(null);

    // --- FORMATEADOR DE TIEMPO PARA EL HISTORIAL ---
    const formatearTiempoHistorial = (totalSegundos) => {
        const mins = Math.floor(totalSegundos / 60);
        const secs = totalSegundos % 60;
        if (mins === 0) return `${secs} seg`;
        if (secs === 0) return `${mins} min`;
        return `${mins}m ${secs}s`;
    };

    const [historial, setHistorial] = useState([]);

    // --- CARGA INICIAL DESDE LA BASE DE DATOS ---
    useEffect(() => {
        const cargarHistorial = async () => {
            try {
                const idUsuarioActual = parseInt(localStorage.getItem('idUsuario')) || 1;
                const response = await fetch(`https://localhost:7068/api/Pomodoros/usuario/${idUsuarioActual}`);

                if (response.ok) {
                    const data = await response.json();
                    const opcionesFecha = { day: 'numeric', month: 'long', year: 'numeric' };
                    const historialMapeado = data.map(item => ({
                        id: item.idPomodoro,
                        fecha: new Date(item.fecha).toLocaleDateString('es-ES', opcionesFecha),
                        tiempoConcentrado: formatearTiempoHistorial(item.duracionEstudio),
                        tiempoDescanso: formatearTiempoHistorial(item.duracionDescanso)
                    }));
                    setHistorial(historialMapeado);
                }
            } catch (error) {
                console.error("Error al cargar el historial desde la API:", error);
            }
        };
        cargarHistorial();
    }, []);

    // --- LÓGICA DE FASES ---
    const avanzarFase = () => {
        setEstaActivo(true);
        if (!esDescanso) {
            setEsDescanso(true);
            setSegundos(tiempoDescanso * 60);
        } else {
            setEsDescanso(false);
            setSegundos(tiempoSesion * 60);
            if (sesionActual < ciclosTotales) {
                setSesionActual(s => s + 1);
            } else {
                setEstaActivo(false);
                setSesionActual(1);
                guardarEnHistorial();
                alert("¡Felicidades! Completaste todos tus ciclos y se guardó en tu historial.");
            }
        }
    };

    // --- LÓGICA DEL HISTORIAL ---
    const guardarEnHistorial = async () => {
        const nuevoPomodoroDB = {
            idUsuario: parseInt(localStorage.getItem('idUsuario')) || 1,
            idMateria: 1,
            fecha: new Date().toISOString(),
            duracionEstudio: segundosAcumuladosEstudio,
            duracionDescanso: segundosAcumuladosDescanso,
            estado: false
        };

        try {
            const response = await fetch('https://localhost:7068/api/Pomodoros', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(nuevoPomodoroDB)
            });

            if (response.ok) {
                const data = await response.json();
                const opcionesFecha = { day: 'numeric', month: 'long', year: 'numeric' };
                const registroVisual = {
                    id: data.idPomodoro,
                    fecha: new Date(data.fecha).toLocaleDateString('es-ES', opcionesFecha),
                    tiempoConcentrado: formatearTiempoHistorial(data.duracionEstudio),
                    tiempoDescanso: formatearTiempoHistorial(data.duracionDescanso)
                };
                setHistorial([registroVisual, ...historial]);
                setSegundosAcumuladosEstudio(0);
                setSegundosAcumuladosDescanso(0);
            } else {
                console.error("El servidor rechazó el guardado.");
            }
        } catch (error) {
            console.error("Error de conexión al guardar el pomodoro:", error);
        }
    };

    // --- MODAL DE ELIMINACIÓN ---
    const intentarEliminar = (id) => {
        setItemToDelete(id);
        setIsDeleteModalOpen(true);
    };

    const confirmarEliminacion = async () => {
        try {
            const response = await fetch(`https://localhost:7068/api/Pomodoros/${itemToDelete}`, {
                method: 'DELETE'
            });
            if (response.ok) {
                setHistorial(historial.filter(item => item.id !== itemToDelete));
                setIsDeleteModalOpen(false);
                setItemToDelete(null);
            } else {
                console.error("El servidor no pudo borrar el registro.");
                alert("Hubo un error al borrar el Pomodoro.");
            }
        } catch (error) {
            console.error("Error de conexión al intentar borrar:", error);
        }
    };

    const cancelarEliminacion = () => {
        setIsDeleteModalOpen(false);
        setItemToDelete(null);
    };

    // --- LÓGICA DEL RELOJ ---
    useEffect(() => {
        let intervalo = null;
        if (estaActivo && segundos > 0) {
            intervalo = setInterval(() => {
                setSegundos((s) => s - 1);
                if (esDescanso) {
                    setSegundosAcumuladosDescanso(prev => prev + 1);
                } else {
                    setSegundosAcumuladosEstudio(prev => prev + 1);
                }
            }, 1000);
        } else if (segundos === 0) {
            clearInterval(intervalo);
            avanzarFase();
        } else {
            clearInterval(intervalo);
        }
        return () => clearInterval(intervalo);
    }, [estaActivo, segundos, esDescanso, sesionActual, ciclosTotales]);

    const formatearTiempo = (s) => {
        const mins = Math.floor(s / 60);
        const secs = s % 60;
        return `${mins}:${secs < 10 ? '0' : ''}${secs}`;
    };

    const resetearReloj = () => {
        setEstaActivo(false);
        setEsDescanso(false);
        setSegundos(tiempoSesion * 60);
        setSesionActual(1);
        setSegundosAcumuladosEstudio(0);
        setSegundosAcumuladosDescanso(0);
    };

    // --- FUNCIONES DEL MODAL CONFIG ---
    const abrirConfig = () => { setIsEditing(false); setIsConfigModalOpen(true); };
    const cerrarConfig = () => { setIsConfigModalOpen(false); setIsEditing(false); };

  const activarModoEdicion = () => {
        if (!isEditing) {
            // Si entra a editar, copiamos los valores actuales a los borradores
            setDraftSesion(tiempoSesion);
            setDraftDescanso(tiempoDescanso);
            setDraftCiclos(ciclosTotales);
        } else {
            // Si hace clic en "Confirmar valores", guardamos los borradores como los nuevos valores activos
            setTiempoSesion(draftSesion);
            setTiempoDescanso(draftDescanso);
            setCiclosTotales(draftCiclos);
        }
        // Invertimos el estado (abre o cierra la edición)
        setIsEditing(!isEditing);
    };

   const aplicarConfiguracion = () => {
        // Ya no importa si estaba en edición o no, usamos los valores principales
        setEstaActivo(false);
        setEsDescanso(false);
        setSegundos(tiempoSesion * 60);
        setSesionActual(1);
        setIsEditing(false);
        setIsConfigModalOpen(false);
        setSegundosAcumuladosEstudio(0);
        setSegundosAcumuladosDescanso(0);
    };

    // --- CÁLCULOS SVG ---
    const radio = 110;
    const circunferencia = 2 * Math.PI * radio;
    const tiempoTotalFaseActual = esDescanso ? (tiempoDescanso * 60) : (tiempoSesion * 60);
    const porcentaje = segundos / tiempoTotalFaseActual;
    const offset = circunferencia - porcentaje * circunferencia;

    const colorActivo = esDescanso ? '#219653' : '#3A56AF';
    const bgBadge = esDescanso ? '#E5F6ED' : '#EEF1FF';
    const colorBadge = esDescanso ? '#219653' : '#3A56AF';

    return (
        <>
            <style>{`
                @import url('https://fonts.googleapis.com/css2?family=IBM+Plex+Sans:wght@400;500;600;700&family=IBM+Plex+Mono:wght@300;400&display=swap');

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

                /* Badge de estado */
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

                /* Título y subtítulo */
                .task-title {
                    font-size: 2rem;
                    font-weight: 700;
                    color: #2D3247;
                    margin: 0 0 6px 0;
                    text-align: center;
                    letter-spacing: -0.03em;
                }
                .task-subtitle {
                    font-size: 0.9rem;
                    color: #9EA5BA;
                    margin: 0 0 20px 0;
                    text-align: center;
                }

                /* Contador de sesión */
                .session-counter {
                    background-color: #EEF1FF;
                    color: #3A56AF;
                    padding: 4px 14px;
                    border-radius: 4px;
                    font-weight: '700';
                    font-size: 0.82rem;
                    margin-bottom: 28px;
                }

               /* Círculo SVG */
                .timer-circle-wrap {
                    position: relative;
                    width: 240px;  /* <-- Cambiar a 240px */
                    height: 240px; /* <-- Cambiar a 240px */
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

                /* Controles */
                .controls-row {
                    display: flex;
                    align-items: center;
                    gap: 8px;
                    background-color: white;
                    padding: 12px 24px;
                    border-radius: 8px;
                    border: 1px solid #E8EBFF;
                    margin-bottom: 36px;
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
                .ctrl-icon-btn:hover { color: #3A56AF; background-color: #F0F3FF; }
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
                    transition: background-color 0.15s;
                    margin: 0 8px;
                }
                .play-btn:hover { background-color: #2F469A; }

                /* Historial */
                .history-section {
                    width: 100%;
                    margin-bottom: 36px;
                }
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
                    gap: '8px';
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
                    margin-bottom: 8px;
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
                .history-times { display: flex; gap: 8px; }
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
                }
                .delete-btn:hover { color: #E53E3E; background-color: #FFF5F5; }

                /* Cita footer */
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
                .modal-subtitle {
                    font-size: 0.83rem;
                    color: #9EA5BA;
                    margin: 0;
                }
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
                .preset-title-wrap {
                    display: flex;
                    align-items: center;
                    gap: 8px;
                }
                .preset-name {
                    font-size: 0.88rem;
                    font-weight: 700;
                    color: #3A56AF;
                }
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

                .modal-actions {
                    display: flex;
                    flex-direction: column;
                    gap: '12px';
                }
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
                    margin-bottom: 10px;
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

                /* Modal borrado */
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
                .delete-modal-actions {
                    display: flex;
                    width: 100%;
                    gap: 12px;
                }
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

                    {/* Badge estado */}
                    <span
                        className="session-badge"
                        style={{ backgroundColor: bgBadge, color: colorBadge }}
                    >
                        {esDescanso ? "Tiempo de Descanso" : "Sesión de Trabajo"}
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
                                style={{ transition: 'stroke-dashoffset 1s linear, stroke 0.4s ease' }}
                            />
                        </svg>
                        <div className="time-display">
                            <div className="clock-text" style={{ color: colorActivo }}>
                                {formatearTiempo(segundos)}
                            </div>
                            <div className="status-label">
                                {estaActivo ? "En curso" : "Pausado"}
                            </div>
                        </div>
                    </div>

                    {/* Controles */}
                    <div className="controls-row">
                        <button className="ctrl-icon-btn" onClick={abrirConfig} title="Configuración">
                            <IconConfig />
                        </button>
                        <button className="play-btn" onClick={() => setEstaActivo(!estaActivo)}>
                            {estaActivo ? <IconPause /> : <IconPlay />}
                        </button>
                        <button className="ctrl-icon-btn" onClick={avanzarFase} title="Saltar fase">
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
                                <p className="empty-history">No hay sesiones completadas aún.</p>
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
                        <p className="quote-text">
                            La profundidad de tu enfoque determina el nivel de tu maestría.
                        </p>
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
                                    <button className="close-modal-btn" onClick={cerrarConfig}>
                                        <IconClose />
                                    </button>
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
                                            {isEditing ? (
                                                <input
                                                    type="number"
                                                    value={draftSesion}
                                                    onChange={(e) => setDraftSesion(Number(e.target.value))}
                                                    className="input-edit"
                                                    min="1"
                                                />
                                            ) : (
                                                <p className="preset-value">{tiempoSesion}</p>
                                            )}
                                        </div>
                                        <div className="grid-item-center">
                                            <p className="preset-label">Descanso (min)</p>
                                            {isEditing ? (
                                                <input
                                                    type="number"
                                                    value={draftDescanso}
                                                    onChange={(e) => setDraftDescanso(Number(e.target.value))}
                                                    className="input-edit"
                                                    min="1"
                                                />
                                            ) : (
                                                <p className="preset-value">{tiempoDescanso}</p>
                                            )}
                                        </div>
                                        <div className="ciclos-wrap">
                                            <p className="preset-label">Ciclos</p>
                                            {isEditing ? (
                                                <input
                                                    type="number"
                                                    value={draftCiclos}
                                                    onChange={(e) => setDraftCiclos(Number(e.target.value))}
                                                    className="input-edit"
                                                    min="1"
                                                />
                                            ) : (
                                                <p className="preset-value">{ciclosTotales}</p>
                                            )}
                                        </div>
                                    </div>
                                </div>

                                <button className="edit-preset-btn" onClick={activarModoEdicion}>
                                    {isEditing ? <IconCheck /> : <IconEdit />}
                                    {isEditing ? "Confirmar valores" : "Editar preajuste"}
                                </button>

                                <div className="modal-actions">
                                    <button className="btn-aplicar" onClick={aplicarConfiguracion}>
                                        Aplicar configuración
                                    </button>
                                    <button className="btn-cancelar" onClick={cerrarConfig}>
                                        Cancelar
                                    </button>
                                </div>
                            </div>
                        </div>
                    )}

                    {/* ── MODAL BORRADO ── */}
                    {isDeleteModalOpen && (
                        <div className="modal-overlay">
                            <div className="delete-modal-content">
                                <div className="delete-icon-wrap">
                                    <IconWarning />
                                </div>
                                <h3 className="delete-modal-title">¿Eliminar registro?</h3>
                                <p className="delete-modal-subtitle">
                                    Esta acción eliminará el registro de tu historial y no se puede deshacer.
                                </p>
                                <div className="delete-modal-actions">
                                    <button className="btn-cancelar-borrado" onClick={cancelarEliminacion}>
                                        Cancelar
                                    </button>
                                    <button className="btn-confirmar-borrado" onClick={confirmarEliminacion}>
                                        Eliminar
                                    </button>
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
