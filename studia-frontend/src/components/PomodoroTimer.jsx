import React, { useState, useEffect } from 'react';

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
    

    // --- NUEVO: ACUMULADORES DE TIEMPO REAL ---
    const [segundosAcumuladosEstudio, setSegundosAcumuladosEstudio] = useState(0);
    const [segundosAcumuladosDescanso, setSegundosAcumuladosDescanso] = useState(0)
    
    // --- ESTADOS DE MODALES ---
    const [isConfigModalOpen, setIsConfigModalOpen] = useState(false);
    const [isEditing, setIsEditing] = useState(false); 
    
    // NUEVOS ESTADOS PARA EL MODAL DE BORRAR
    const [isDeleteModalOpen, setIsDeleteModalOpen] = useState(false);
    const [itemToDelete, setItemToDelete] = useState(null);

    // --- NUEVO: FORMATEADOR DE TIEMPO PARA EL HISTORIAL ---
    const formatearTiempoHistorial = (totalSegundos) => {
        const mins = Math.floor(totalSegundos / 60);
        const secs = totalSegundos % 60;
        
        if (mins === 0) return `${secs} seg`;
        if (secs === 0) return `${mins} min`;
        return `${mins}m ${secs}s`;
    };

   const [historial, setHistorial] = useState([]);
   // --- CARGA INICIAL DESDE LA BASE DE DATOS (NUEVO) ---
    useEffect(() => {
        const cargarHistorial = async () => {
            try {
                // Le pegamos al endpoint que armaste hoy
                const response = await fetch('https://localhost:7068/api/Pomodoros');
                if (response.ok) {
                    const data = await response.json();
                    
                    // Mapeamos el JSON de tu backend al formato que armó Karen para las tarjetas
                    const opcionesFecha = { day: 'numeric', month: 'long', year: 'numeric' };
                    const historialMapeado = data.map(item => ({
                    id: item.idPomodoro,
                    fecha: new Date(item.fecha).toLocaleDateString('es-ES', opcionesFecha),
                    tiempoConcentrado: formatearTiempoHistorial(item.duracionEstudio), // <- CAMBIO ACÁ
                    tiempoDescanso: formatearTiempoHistorial(item.duracionDescanso)    // <- CAMBIO ACÁ
                }));
                    
                    // Invertimos el array para que el más nuevo salga primero
                    setHistorial(historialMapeado.reverse());
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
   // --- LÓGICA DEL HISTORIAL (CONECTADA AL BACKEND) ---
    // --- LÓGICA DEL HISTORIAL (CONECTADA AL BACKEND) ---
    const guardarEnHistorial = async () => {
        const nuevoPomodoroDB = {
            idUsuario: parseInt(localStorage.getItem('idUsuario')) || 1, 
            idMateria: 1, 
            fecha: new Date().toISOString(),
            // AHORA MANDAMOS LOS SEGUNDOS EXACTOS:
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
                    // USAMOS EL FORMATEADOR PARA LA TARJETA NUEVA:
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
    
    // LÓGICA DEL NUEVO MODAL DE ELIMINACIÓN
    const intentarEliminar = (id) => {
        setItemToDelete(id);
        setIsDeleteModalOpen(true);
    };

   // LÓGICA DEL NUEVO MODAL DE ELIMINACIÓN (CONECTADA AL BACK)
    const confirmarEliminacion = async () => {
        try {
            // Le pegamos al endpoint DELETE que acabás de crear, pasándole el ID
            const response = await fetch(`https://localhost:7068/api/Pomodoros/${itemToDelete}`, {
                method: 'DELETE'
            });

            if (response.ok) {
                // Si la BD lo borró con éxito, recién ahí lo sacamos de la pantalla
                const nuevoHistorial = historial.filter(item => item.id !== itemToDelete);
                setHistorial(nuevoHistorial);
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
                
                // NUEVO: Sumar 1 segundo al acumulador que corresponda
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
            setDraftSesion(tiempoSesion);
            setDraftDescanso(tiempoDescanso);
            setDraftCiclos(ciclosTotales);
        }
        setIsEditing(!isEditing);
    };

    const aplicarConfiguracion = () => {
        if (isEditing) {
            setTiempoSesion(draftSesion);
            setTiempoDescanso(draftDescanso);
            setCiclosTotales(draftCiclos);
            
            setEstaActivo(false);
            setEsDescanso(false);
            setSegundos(draftSesion * 60);
            setSesionActual(1);
        }
        setIsEditing(false);
        setIsConfigModalOpen(false);
        setSegundosAcumuladosEstudio(0);
        setSegundosAcumuladosDescanso(0);
    };

    // --- CÁLCULOS SVG ---
    const radio = 90;
    const circunferencia = 2 * Math.PI * radio;
    const tiempoTotalFaseActual = esDescanso ? (tiempoDescanso * 60) : (tiempoSesion * 60);
    const porcentaje = segundos / tiempoTotalFaseActual;
    const offset = circunferencia - porcentaje * circunferencia;

    return (
        <div style={estilos.pomodoroContainer}>
            
            {/* --- ZONA PRINCIPAL DEL RELOJ --- */}
            <span style={{
                ...estilos.sessionBadge, 
                backgroundColor: esDescanso ? '#E5F6ED' : '#D6E0FF', 
                color: esDescanso ? '#219653' : '#3A56AF'
            }}>
                {esDescanso ? "TIEMPO DE DESCANSO" : "SESIÓN DE TRABAJO"}
            </span>
            <h1 style={estilos.taskTitle}>Estudiando Neurociencia</h1>
            <p style={estilos.taskSubtitle}>Capítulo 4: Plasticidad Neuronal y Memoria</p>

            <div style={estilos.sessionCounter}>{sesionActual}/{ciclosTotales}</div>

            <div style={estilos.timerCircleContainer}>
                <svg width="220" height="220" style={estilos.svgCircle}>
                    <circle cx="110" cy="110" r={radio} stroke="#E8EBFF" strokeWidth="8" fill="transparent" />
                    <circle 
                        cx="110" cy="110" r={radio} 
                        stroke={esDescanso ? "#219653" : "#3A56AF"} 
                        strokeWidth="8" fill="transparent" 
                        strokeDasharray={circunferencia}
                        strokeDashoffset={offset}
                        strokeLinecap="round"
                        style={{ transition: 'stroke-dashoffset 1s linear, stroke 0.5s ease' }} 
                    />
                </svg>
                <div style={estilos.timeDisplay}>
                    <div style={{...estilos.clockText, color: esDescanso ? "#219653" : "#3A56AF"}}>
                        {formatearTiempo(segundos)}
                    </div>
                    <div style={estilos.statusLabel}>{estaActivo ? "EN CURSO" : "PAUSADO"}</div>
                </div>
            </div>

            <div style={estilos.controlsRow}>
                <button style={estilos.iconBtn} onClick={abrirConfig} title="Configuración">⊞</button>
                <button style={estilos.playBtn} onClick={() => setEstaActivo(!estaActivo)}>
                    {estaActivo ? "II" : "▶"}
                </button>
                <button style={estilos.iconBtn} onClick={avanzarFase} title="Saltar Fase">⏭</button>
                <button style={estilos.iconBtn} onClick={resetearReloj} title="Reiniciar">↺</button>
            </div>

            {/* --- HISTORIAL INTEGRADO --- */}
            <div style={estilos.historySection}>
                <h3 style={estilos.historyTitle}>Historial de Enfoque</h3>
                <div style={estilos.historyListContainerInline}>
                    {historial.length === 0 ? (
                        <p style={estilos.emptyHistory}>No hay sesiones completadas aún.</p>
                    ) : (
                        historial.map((item) => (
                            <div key={item.id} style={estilos.historyCard}>
                                <div style={estilos.historyInfo}>
                                    <p style={estilos.historyDate}>🗓️ {item.fecha}</p>
                                    <div style={estilos.historyTimes}>
                                        <span style={estilos.timeBadgeFocus}>🎯 {item.tiempoConcentrado}</span>
                                        <span style={estilos.timeBadgeBreak}>☕ {item.tiempoDescanso}</span>
                                    </div>
                                </div>
                                <button 
                                    style={estilos.deleteBtn} 
                                    onClick={() => intentarEliminar(item.id)}
                                    title="Eliminar registro"
                                >
                                    🗑️
                                </button>
                            </div>
                        ))
                    )}
                </div>
            </div>

            <footer style={estilos.quoteSection}>
                <div style={estilos.quoteLine}></div>
                <p style={estilos.quoteText}>“La profundidad de tu enfoque determina el nivel de tu maestría.”</p>
                <p style={estilos.quoteAuthor}>FILOSOFÍA SANCTUARY</p>
            </footer>

            {/* --- MODAL DE CONFIGURACIÓN --- */}
            {isConfigModalOpen && (
                <div style={estilos.modalOverlay}>
                    <div style={estilos.modalContent}>
                        <div style={estilos.modalHeader}>
                            <div>
                                <h3 style={estilos.modalTitle}>Configuración Pomodoro</h3>
                                <p style={estilos.modalSubtitle}>Configura tu sesión de trabajo profundo.</p>
                            </div>
                            <button style={estilos.closeModalBtn} onClick={cerrarConfig}>✕</button>
                        </div>

                        <div style={estilos.presetCard}>
                            <div style={estilos.presetHeader}>
                                <div style={estilos.presetTitleWrap}>
                                    <span style={estilos.presetIcon}>⚙️</span>
                                    <span style={estilos.presetName}>Configuración</span>
                                </div>
                                <span style={estilos.badgeRecomendado}>RECOMENDADA</span>
                            </div>

                            <div style={estilos.presetGrid}>
                                <div style={estilos.gridItemCenter}>
                                    <p style={estilos.presetLabel}>SESIONES (min)</p>
                                    {isEditing ? (
                                        <input type="number" value={draftSesion} onChange={(e) => setDraftSesion(Number(e.target.value))} style={estilos.inputEdit} min="1"/>
                                    ) : (
                                        <p style={estilos.presetValue}>{tiempoSesion} min</p>
                                    )}
                                </div>
                                <div style={estilos.gridItemCenter}>
                                    <p style={estilos.presetLabel}>DESCANSOS (min)</p>
                                    {isEditing ? (
                                        <input type="number" value={draftDescanso} onChange={(e) => setDraftDescanso(Number(e.target.value))} style={estilos.inputEdit} min="1"/>
                                    ) : (
                                        <p style={estilos.presetValue}>{tiempoDescanso} min</p>
                                    )}
                                </div>
                                <div style={estilos.ciclosWrap}>
                                    <p style={estilos.presetLabel}>CICLOS</p>
                                    {isEditing ? (
                                        <input type="number" value={draftCiclos} onChange={(e) => setDraftCiclos(Number(e.target.value))} style={estilos.inputEdit} min="1"/>
                                    ) : (
                                        <p style={estilos.presetValue}>{ciclosTotales}</p>
                                    )}
                                </div>
                            </div>
                        </div>

                        <button style={estilos.crearPresetBtn} onClick={activarModoEdicion}>
                            <span style={estilos.plusIcon}>{isEditing ? "✓" : "+"}</span> 
                            {isEditing ? "Confirmar valores" : "Editar preajuste"}
                        </button>

                        <div style={estilos.modalActions}>
                            <button style={estilos.btnAplicar} onClick={aplicarConfiguracion}>Aplicar</button>
                            <button style={estilos.btnCancelar} onClick={cerrarConfig}>Cancelar</button>
                        </div>
                    </div>
                </div>
            )}

            {/* --- MODAL DE CONFIRMACIÓN DE BORRADO --- */}
            {isDeleteModalOpen && (
                <div style={estilos.modalOverlay}>
                    <div style={estilos.deleteModalContent}>
                        <div style={estilos.deleteWarningIcon}>⚠️</div>
                        <h3 style={estilos.modalTitle}>¿Eliminar registro?</h3>
                        <p style={{...estilos.modalSubtitle, marginBottom: '25px', textAlign: 'center'}}>
                            Esta acción eliminará el registro de tu historial y no se puede deshacer.
                        </p>
                        
                        <div style={estilos.deleteModalActions}>
                            <button style={estilos.btnCancelarBorrado} onClick={cancelarEliminacion}>
                                Cancelar
                            </button>
                            <button style={estilos.btnConfirmarBorrado} onClick={confirmarEliminacion}>
                                Eliminar
                            </button>
                        </div>
                    </div>
                </div>
            )}
        </div>
    );
};

// --- ESTILOS ENCAPSULADOS ---
const estilos = {
    pomodoroContainer: { width: '100%', height: '100%', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'flex-start', padding: '20px', boxSizing: 'border-box', overflowY: 'auto' },
    sessionBadge: { padding: '6px 15px', borderRadius: '20px', fontSize: '0.75rem', fontWeight: '800', letterSpacing: '1px', marginBottom: '20px', transition: 'all 0.5s ease' },
    taskTitle: { fontSize: '2.5rem', fontWeight: '800', color: '#2D3247', margin: '0 0 5px 0', textAlign: 'center' },
    taskSubtitle: { fontSize: '1.1rem', color: '#9EA5BA', margin: '0 0 30px 0', textAlign: 'center' },
    sessionCounter: { backgroundColor: '#F0F3FF', color: '#3A56AF', padding: '5px 15px', borderRadius: '8px', fontWeight: '700', marginBottom: '30px' },
    timerCircleContainer: { position: 'relative', width: '220px', height: '220px', display: 'flex', justifyContent: 'center', alignItems: 'center', marginBottom: '30px' },
    svgCircle: { transform: 'rotate(-90deg)' },
    timeDisplay: { position: 'absolute', textAlign: 'center', display: 'flex', flexDirection: 'column', alignItems: 'center' },
    clockText: { fontSize: '4rem', fontWeight: '400', letterSpacing: '-2px', lineHeight: '1', transition: 'color 0.5s ease' },
    statusLabel: { fontSize: '0.75rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1.5px', marginTop: '10px' },
    controlsRow: { display: 'flex', alignItems: 'center', gap: '25px', backgroundColor: 'white', padding: '15px 35px', borderRadius: '20px', boxShadow: '0 10px 40px rgba(0,0,0,0.05)', marginBottom: '40px' },
    iconBtn: { background: 'none', border: 'none', color: '#9EA5BA', fontSize: '1.4rem', cursor: 'pointer', transition: 'color 0.2s' },
    playBtn: { width: '55px', height: '55px', borderRadius: '15px', border: 'none', backgroundColor: 'white', boxShadow: '0 8px 25px rgba(58, 86, 175, 0.15)', color: '#3A56AF', fontSize: '1.2rem', cursor: 'pointer', display: 'flex', justifyContent: 'center', alignItems: 'center', transition: 'transform 0.1s' },
    
    // Historial
    historySection: { width: '100%', maxWidth: '500px', marginBottom: '40px' },
    historyTitle: { fontSize: '1.1rem', fontWeight: '700', color: '#2D3247', marginBottom: '15px', paddingLeft: '5px' },
    historyListContainerInline: { maxHeight: '220px', overflowY: 'auto', paddingRight: '5px' },
    emptyHistory: { textAlign: 'center', color: '#9EA5BA', fontStyle: 'italic', padding: '20px 0', backgroundColor: 'transparent' },
    historyCard: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', backgroundColor: 'white', padding: '15px', borderRadius: '15px', marginBottom: '12px', boxShadow: '0 4px 15px rgba(0,0,0,0.02)', border: '1px solid #F0F3FF' },
    historyInfo: { display: 'flex', flexDirection: 'column', gap: '8px' },
    historyDate: { fontSize: '0.9rem', fontWeight: '700', color: '#2D3247', margin: 0 },
    historyTimes: { display: 'flex', gap: '10px' },
    timeBadgeFocus: { backgroundColor: '#F0F3FF', color: '#3A56AF', padding: '4px 8px', borderRadius: '6px', fontSize: '0.75rem', fontWeight: '700' },
    timeBadgeBreak: { backgroundColor: '#E5F6ED', color: '#219653', padding: '4px 8px', borderRadius: '6px', fontSize: '0.75rem', fontWeight: '700' },
    deleteBtn: { background: 'transparent', border: 'none', color: '#FF4D4D', fontSize: '1.1rem', cursor: 'pointer', padding: '8px', transition: 'transform 0.2s', opacity: 0.7 },

    quoteSection: { textAlign: 'center', marginTop: 'auto', paddingTop: '20px' },
    quoteLine: { width: '40px', height: '2px', backgroundColor: '#E8EBFF', margin: '0 auto 20px auto' },
    quoteText: { fontStyle: 'italic', color: '#9EA5BA', fontSize: '1.05rem', maxWidth: '450px', margin: '0 auto 10px auto', lineHeight: '1.6' },
    quoteAuthor: { fontSize: '0.75rem', fontWeight: '800', color: '#9EA5BA', letterSpacing: '2px', opacity: 0.7 },

    // Modales Generales
    modalOverlay: { position: 'fixed', top: 0, left: 0, right: 0, bottom: 0, backgroundColor: 'rgba(215, 220, 228, 0.85)', backdropFilter: 'blur(3px)', display: 'flex', justifyContent: 'center', alignItems: 'center', zIndex: 1000 },
    modalContent: { backgroundColor: 'white', width: '100%', maxWidth: '450px', borderRadius: '20px', padding: '35px', boxShadow: '0 20px 50px rgba(0,0,0,0.1)', boxSizing: 'border-box' },
    modalHeader: { display: 'flex', justifyContent: 'space-between', alignItems: 'flex-start', marginBottom: '25px' },
    modalTitle: { fontSize: '1.4rem', fontWeight: '700', color: '#2D3247', margin: '0 0 5px 0', textAlign: 'center' },
    modalSubtitle: { fontSize: '0.85rem', color: '#9EA5BA', margin: 0 },
    closeModalBtn: { background: 'none', border: 'none', fontSize: '1.2rem', color: '#9EA5BA', cursor: 'pointer', padding: 0 },
    presetCard: { backgroundColor: '#F6F8FE', borderRadius: '15px', padding: '20px', marginBottom: '20px' },
    presetHeader: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '20px' },
    presetTitleWrap: { display: 'flex', alignItems: 'center', gap: '8px' },
    presetIcon: { color: '#3A56AF' },
    presetName: { fontSize: '0.95rem', fontWeight: '700', color: '#3A56AF' },
    badgeRecomendado: { backgroundColor: '#D6E0FF', color: '#3A56AF', padding: '4px 10px', borderRadius: '15px', fontSize: '0.65rem', fontWeight: '800' },
    presetGrid: { display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '20px' },
    gridItemCenter: { textAlign: 'center' },
    ciclosWrap: { gridColumn: 'span 2', textAlign: 'center' },
    presetLabel: { fontSize: '0.65rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', margin: '0 0 5px 0' },
    presetValue: { fontSize: '1.1rem', fontWeight: '700', color: '#2D3247', margin: 0 },
    inputEdit: { width: '60px', textAlign: 'center', padding: '5px', fontSize: '1rem', fontWeight: '700', color: '#2D3247', border: '1px solid #D6E0FF', borderRadius: '5px', backgroundColor: 'white', outline: 'none' },
    crearPresetBtn: { width: '100%', backgroundColor: 'transparent', border: '1.5px dashed #D6E0FF', borderRadius: '12px', padding: '15px', color: '#6B728E', fontSize: '0.9rem', fontWeight: '600', cursor: 'pointer', display: 'flex', justifyContent: 'center', alignItems: 'center', gap: '8px', marginBottom: '30px' },
    plusIcon: { backgroundColor: '#6B728E', color: 'white', width: '16px', height: '16px', borderRadius: '50%', display: 'flex', justifyContent: 'center', alignItems: 'center', fontSize: '0.8rem' },
    modalActions: { display: 'flex', flexDirection: 'column', gap: '15px' },
    btnAplicar: { backgroundColor: '#3A56AF', color: 'white', border: 'none', borderRadius: '10px', padding: '14px', fontSize: '1rem', fontWeight: '700', cursor: 'pointer', boxShadow: '0 4px 15px rgba(58, 86, 175, 0.2)' },
    btnCancelar: { backgroundColor: 'transparent', color: '#6B728E', border: 'none', fontSize: '0.9rem', fontWeight: '600', cursor: 'pointer' },

    // Estilos Específicos del Modal de Borrado
    deleteModalContent: { backgroundColor: 'white', width: '100%', maxWidth: '380px', borderRadius: '20px', padding: '35px 25px', boxShadow: '0 20px 50px rgba(0,0,0,0.15)', boxSizing: 'border-box', display: 'flex', flexDirection: 'column', alignItems: 'center' },
    deleteWarningIcon: { fontSize: '3rem', marginBottom: '15px' },
    deleteModalActions: { display: 'flex', width: '100%', gap: '15px', marginTop: '10px' },
    btnCancelarBorrado: { flex: 1, backgroundColor: '#F0F3FF', color: '#3A56AF', border: 'none', borderRadius: '10px', padding: '12px', fontSize: '0.95rem', fontWeight: '700', cursor: 'pointer' },
    btnConfirmarBorrado: { flex: 1, backgroundColor: '#FF4D4D', color: 'white', border: 'none', borderRadius: '10px', padding: '12px', fontSize: '0.95rem', fontWeight: '700', cursor: 'pointer', boxShadow: '0 4px 15px rgba(255, 77, 77, 0.2)' }
};

export default PomodoroTimer;