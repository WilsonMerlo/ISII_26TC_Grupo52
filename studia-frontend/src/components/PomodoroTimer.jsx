import React, { useState, useEffect, useMemo } from 'react';

const PomodoroTimer = () => {
    // --- CONSTANTES DE DISEÑO ---
    const DURACION_ESTUDIO_MINUTOS = 25; // 25:00
    const DURACION_DESCANSO_MINUTOS = 5;
    const API_BASE_URL = "https://localhost:7068/api";

    // --- ESTADOS ---
    const [materias, setMaterias] = useState([]); // Lista de materias desde la API
    const [idMateriaSeleccionada, setIdMateriaSeleccionada] = useState(''); // Materia elegida
    const [segundos, setSegundos] = useState(DURACION_ESTUDIO_MINUTOS * 60); // 25 minutos
    const [estaActivo, setEstaActivo] = useState(false); // Estado del cronómetro (ejecutando/pausado)
    const [error, setError] = useState(null); // Para mensajes de error
    const [bloqueActual, setBloqueActual] = useState(1); // Spec: Capítulo 4, Bloque 1 de 4

    // --- LÓGICA DE DIBUJO DEL CÍRCULO SVG ---
    const diametro = 200; // Tamaño del círculo principal
    const radio = 85; // Radio del círculo interno
    const circunferencia = 2 * Math.PI * radio;
    const duracionInicialSegundos = DURACION_ESTUDIO_MINUTOS * 60;
    
    // Calculamos el desfase para el dibujo (progreso)
    const offsetCircular = useMemo(() => {
        const fraccionRestante = segundos / duracionInicialSegundos;
        return circunferencia * (1 - fraccionRestante);
    }, [segundos, circunferencia, duracionInicialSegundos]);

    // --- AYUDANTE PARA EL NOMBRE DE LA MATERIA ACTUAL ---
    const materiaActual = useMemo(() => {
        return materias.find(m => m.idMateria === parseInt(idMateriaSeleccionada));
    }, [materias, idMateriaSeleccionada]);

    // --- EFECTO 1: Cargar materias al montar ---
    useEffect(() => {
        const obtenerMaterias = async () => {
            try {
                const response = await fetch(`${API_BASE_URL}/Materias`);
                if (!response.ok) throw new Error("Error al obtener materias");
                const data = await response.json();
                setMaterias(data);
                
                // Seleccionamos la primera materia por defecto
                if (data.length > 0) setIdMateriaSeleccionada(data[0].idMateria);
            } catch (err) {
                setError("No se pudo conectar con el servidor backend.");
                console.error(err);
            }
        };

        obtenerMaterias();
    }, []);

    // --- EFECTO 2: Lógica del Temporizador ---
    useEffect(() => {
        let intervalo = null;

        if (estaActivo && segundos > 0) {
            intervalo = setInterval(() => {
                setSegundos((prev) => prev - 1);
            }, 1000);
        } else if (segundos === 0) {
            setEstaActivo(false);
            registrarPomodoro();
            clearInterval(intervalo);
        }

        return () => clearInterval(intervalo);
    }, [estaActivo, segundos]);

    // --- FUNCIÓN: POST a la API (Guardar progreso) ---
    const registrarPomodoro = async () => {
        // Leemos el ID del usuario desde el localStorage
        const idUsuarioReal = localStorage.getItem('idUsuario') || 1;

        const nuevoPomodoro = {
            idUsuario: parseInt(idUsuarioReal), // Ya no es un 1 fijo (hardcodeado)
            idMateria: parseInt(idMateriaSeleccionada),
            idApunte: null,
            fecha: new Date().toISOString(),
            duracionEstudio: 25,
            duracionDescanso: 5,
            estado: true
        };

        try {
            const response = await fetch(`${API_BASE_URL}/Pomodoros`, {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(nuevoPomodoro)
            });

            if (response.ok) {
                alert("¡Pomodoro terminado y guardado con éxito!");
                reiniciarPomodoro(true);
            } else {
                throw new Error("Error al guardar el pomodoro");
            }
        } catch (err) {
            setError("Error de red al intentar guardar.");
            console.error(err);
        }
    };

    // --- ACCIONES DE LOS CONTROLES ---
    const reiniciarPomodoro = (automatico = false) => {
        setEstaActivo(false);
        setSegundos(duracionInicialSegundos);
        if (!automatico) setBloqueActual(1); // Si lo hace el usuario, reinicia bloques
    };

    const saltarPomodoro = () => {
        // Para este MVP, saltamos al final y guardamos el progreso.
        registrarPomodoro();
    };

    // --- HELPERS: Formateo de tiempo (MM:SS) ---
    const formatearTiempo = () => {
        const minutos = Math.floor(segundos / 60);
        const secs = segundos % 60;
        return `${minutos.toString().padStart(2, '0')}:${secs.toString().padStart(2, '0')}`;
    };

    return (
        <div style={estilos.pomodoroContainer}>
            {/* 1. Header de sesión - Spec-Perfect */}
            <div style={estilos.sessionHeaderWrap}>
                <div style={estilos.sessionBadge}>SESIÓN DE TRABAJO</div>
                <h1 style={estilos.sessionTitle}>Estudiando Neurociencia</h1> {/* Placeholder de Neurociencia como el prototipo */}
                <p style={estilos.sessionSubtitle}>Capítulo 4: Plasticidad Neuronal y Memoria</p>
            </div>

            {error && <p style={estilos.error}>{error}</p>}

            {/* 2. Temporizador Circular MASTER - Spec-Perfect */}
            <div style={estilos.timerVisualSection}>
                <svg width={diametro} height={diametro} style={estilos.timerSvg}>
                    {/* Anillo de fondo (Spec: gris punteado) */}
                    <circle 
                        cx={diametro / 2} cy={diametro / 2} r={radio}
                        stroke="#E8EBFF" strokeWidth="8" fill="none"
                        strokeDasharray="10 5" // Hace los puntos/guiones
                    />
                    {/* Anillo de progreso (Spec: azul continuo) */}
                    <circle 
                        cx={diametro / 2} cy={diametro / 2} r={radio}
                        stroke="#3A56AF" strokeWidth="8" fill="none"
                        strokeDasharray={circunferencia}
                        strokeDashoffset={offsetCircular}
                        strokeLinecap="round" // Bordes redondeados
                        style={{ transition: 'stroke-dashoffset 0.5s linear' }} // Animación suave
                    />
                </svg>

                {/* Texto central del timer (Spec-Perfect) */}
                <div style={estilos.timerTextContainer}>
                    <div style={estilos.timerTime}>{formatearTiempo()}</div>
                    <div style={estilos.timerStatus}>EN CURSO</div> {/* Spec dice "EN CURSO" */}
                </div>
            </div>

            {/* 3. Controles del temporizador MASTER - Spec-Perfect */}
            <div style={estilos.controlsSectionMASTER}>
                {/* Spec: Reset (🔄) -> Pause/Start (||/|>) -> Skip (|>) */}
                <div style={estilos.controlsRowmaster}>
                    <button style={estilos.roundIconBtn} onClick={() => reiniciarPomodoro(false)}>
                        ↻
                    </button>
                    <button 
                        style={estilos.mainPauseBtnMASTER}
                        onClick={() => setEstaActivo(!estaActivo)}
                    >
                        {estaActivo ? "||" : "|>"} 
                    </button>
                    <button style={estilos.roundIconBtn} onClick={saltarPomodoro}>
                        {'|>'}
                    </button>
                </div>
            </div>

            {/* 4. Frase / Footer motivacional Spec-Perfect */}
            <div style={estilos.quoteFooterSection}>
                <p style={estilos.quoteText}>
                    “La profundidad de tu enfoque determina el nivel de tu maestría.”
                </p>
                <div style={estilos.quoteSource}>FILOSOFÍA SANCTUARY</div>
            </div>
        </div>
    );
};

// --- OBJETO DE ESTILOS CSS REVISADO (Totalmente Spec-Perfect para Sanctuary) ---
const estilos = {
    pomodoroContainer: { textAlign: 'center', width: '100%', maxWidth: '600px', margin: '0 auto', display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '40px 0' },
    
    // Header de sesión (Spec-Perfect)
    sessionHeaderWrap: { marginBottom: '40px' },
    sessionBadge: { display: 'inline-block', backgroundColor: '#E8EBFF', color: '#3A56AF', fontWeight: '700', fontSize: '0.75rem', letterSpacing: '1px', padding: '6px 12px', borderRadius: '20px', marginBottom: '15px' },
    sessionTitle: { fontSize: '2.5rem', fontWeight: '800', color: '#2D3247', margin: 0 },
    sessionSubtitle: { fontSize: '1.1rem', color: '#9EA5BA', fontWeight: '500', margin: '5px 0 0 0' },
    
    // Error
    error: { color: 'red', fontWeight: 'bold' },
    
    // Timer Circular master
    timerVisualSection: { position: 'relative', width: '200px', height: '200px', marginBottom: '40px' },
    timerSvg: { transform: 'rotate(-90deg)' },
    timerTextContainer: { position: 'absolute', top: 0, left: 0, width: '100%', height: '100%', display: 'flex', flexDirection: 'column', justifyContent: 'center', alignItems: 'center' },
    timerTime: { fontSize: '4rem', fontWeight: 'bold', color: '#2D3247' },
    timerStatus: { fontSize: '0.85rem', color: '#9EA5BA', fontWeight: '600', letterSpacing: '1px' },
    
    // Controles master
    controlsSectionMASTER: { marginBottom: '80px', width: '100%', display: 'flex', justifyContent: 'center' },
    controlsRowmaster: { display: 'flex', justifyContent: 'center', alignItems: 'center', gap: '30px' },
    roundIconBtn: { width: '50px', height: '50px', borderRadius: '50%', backgroundColor: 'white', border: '1px solid #E8EBFF', display: 'flex', justifyContent: 'center', alignItems: 'center', fontSize: '1.3rem', color: '#9EA5BA', cursor: 'pointer', boxShadow: '0 2px 5px rgba(0,0,0,0.05)' },
    mainPauseBtnMASTER: { width: '65px', height: '65px', borderRadius: '50%', backgroundColor: '#3A56AF', border: 'none', color: 'white', fontSize: '1.5rem', fontWeight: 'bold', cursor: 'pointer', boxShadow: '0 4px 10px rgba(58, 86, 175, 0.3)' },
    
    // Frase / Footer
    quoteFooterSection: { textAlign: 'center', maxWidth: '500px', marginTop: 'auto', padding: '0 20px' },
    quoteText: { fontStyle: 'italic', fontSize: '1.1rem', color: '#9EA5BA', lineHeight: '1.6', margin: '0 0 10px 0' },
    quoteSource: { fontSize: '0.75rem', color: '#9EA5BA', fontWeight: '700', letterSpacing: '1px', opacity: 0.6 }
};

export default PomodoroTimer;