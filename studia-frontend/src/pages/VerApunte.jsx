import React, { useState, useRef, useEffect, useCallback } from 'react';
import { apunteService } from '../services/apunteService';
import { crearPomodoro, ejecutarAccion, actualizarPomodoro, eliminarPomodoro } from '../services/pomodoroService';

// ---------------------------------------------------------------------------
// Helpers
// ---------------------------------------------------------------------------
const queryCmd = (cmd) => document.queryCommandState(cmd);

const execCmd = (cmd, value = null) => {
    document.execCommand(cmd, false, value);
};

// ---------------------------------------------------------------------------
// Hook: estado activo de la toolbar
// ---------------------------------------------------------------------------
const useFormatState = (editorRef) => {
    const [activeFormats, setActiveFormats] = useState({
        bold: false,
        italic: false,
        underline: false,
        insertUnorderedList: false,
        insertOrderedList: false,
    });

    const updateFormats = useCallback(() => {
        setActiveFormats({
            bold: queryCmd('bold'),
            italic: queryCmd('italic'),
            underline: queryCmd('underline'),
            insertUnorderedList: queryCmd('insertUnorderedList'),
            insertOrderedList: queryCmd('insertOrderedList'),
        });
    }, []);

    useEffect(() => {
        const editor = editorRef.current;
        if (!editor) return;
        editor.addEventListener('keyup', updateFormats);
        editor.addEventListener('mouseup', updateFormats);
        editor.addEventListener('selectionchange', updateFormats);
        document.addEventListener('selectionchange', updateFormats);
        return () => {
            editor.removeEventListener('keyup', updateFormats);
            editor.removeEventListener('mouseup', updateFormats);
            editor.removeEventListener('selectionchange', updateFormats);
            document.removeEventListener('selectionchange', updateFormats);
        };
    }, [editorRef, updateFormats]);

    return activeFormats;
};

// ---------------------------------------------------------------------------
// Toast de feedback
// ---------------------------------------------------------------------------
const Toast = ({ status }) => {
    if (!status) return null;

    const styles = {
        loading: 'bg-white text-slate-600 border border-slate-200',
        success: 'bg-[#3A5A82] text-white',
        error: 'bg-red-500 text-white',
    };

    const icons = {
        loading: (
            <svg className="animate-spin h-4 w-4" viewBox="0 0 24 24" fill="none">
                <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4" />
                <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4z" />
            </svg>
        ),
        success: <span className="material-symbols-outlined text-[18px]">check_circle</span>,
        error: <span className="material-symbols-outlined text-[18px]">error</span>,
    };

    const messages = {
        loading: 'Guardando…',
        success: '¡Guardado correctamente!',
        error: 'Error al guardar. Intentá de nuevo.',
    };

    return (
        <div
            className={`fixed bottom-8 left-1/2 -translate-x-1/2 z-50 flex items-center gap-2 px-5 py-3 rounded-full shadow-xl font-semibold text-sm transition-all duration-300 ${styles[status]}`}
        >
            {icons[status]}
            {messages[status]}
        </div>
    );
};

// ---------------------------------------------------------------------------
// Componente principal
// ---------------------------------------------------------------------------
const VerApunte = ({ apunteSeleccionado, onVolver, onGuardar, materiaActiva = null, onEstadoPomodoroChange }) => {
    const editorRef = useRef(null);
    const tituloRef = useRef(null);
    const seleccionEditorRef = useRef(null);
    const activeFormats = useFormatState(editorRef);

    const [titulo, setTitulo] = useState('');
    const [saveStatus, setSaveStatus] = useState(null); // null | 'loading' | 'success' | 'error'
    const [hayCambiosSinGuardar, setHayCambiosSinGuardar] = useState(false);

    // -----------------------------------------------------------------------
    // Mini Pomodoro enlazado al apunte abierto
    // -----------------------------------------------------------------------
    const [tiempoSesion, setTiempoSesion] = useState(25);
    const [tiempoDescanso, setTiempoDescanso] = useState(5);
    const [ciclosTotales, setCiclosTotales] = useState(4);

    const [draftSesion, setDraftSesion] = useState(25);
    const [draftDescanso, setDraftDescanso] = useState(5);
    const [draftCiclos, setDraftCiclos] = useState(4);

    const [segundosPomodoro, setSegundosPomodoro] = useState(25 * 60);
    const [pomodoroActivo, setPomodoroActivo] = useState(false);
    const [pomodoroEnDescanso, setPomodoroEnDescanso] = useState(false);
    const [cicloActual, setCicloActual] = useState(1);
    const [pomodoroActivoId, setPomodoroActivoId] = useState(null);

    const [segundosEstudioAcumulados, setSegundosEstudioAcumulados] = useState(0);
    const [segundosDescansoAcumulados, setSegundosDescansoAcumulados] = useState(0);

    const [configPomodoroAbierta, setConfigPomodoroAbierta] = useState(false);
    const [editandoConfigPomodoro, setEditandoConfigPomodoro] = useState(false);
    const [modalPomodoroFinalizadoAbierto, setModalPomodoroFinalizadoAbierto] = useState(false);

    const POMODORO_APUNTE_STORAGE_KEY = 'pomodoroApunteActivoId';
    const BASE_URL = import.meta.env.VITE_API_URL || 'https://localhost:7068';

    const obtenerIdApunteActual = () => {
        return (
            apunteSeleccionado?.idApunte ||
            apunteSeleccionado?.IdApunte ||
            apunteSeleccionado?.id_apunte ||
            apunteSeleccionado?.id ||
            apunteSeleccionado?.Id ||
            null
        );
    };

    const obtenerIdMateriaActual = () => {
        return (
            apunteSeleccionado?.idMateria ||
            apunteSeleccionado?.IdMateria ||
            apunteSeleccionado?.id_materia ||
            materiaActiva?.idMateria ||
            materiaActiva?.IdMateria ||
            materiaActiva?.id_materia ||
            materiaActiva?.id ||
            materiaActiva?.Id ||
            null
        );
    };

    const formatearTiempoPomodoro = (totalSegundos) => {
        const total = Math.max(0, Math.floor(Number(totalSegundos) || 0));
        const minutos = Math.floor(total / 60);
        const segundos = total % 60;

        return `${minutos}:${segundos < 10 ? '0' : ''}${segundos}`;
    };

    const obtenerIdPomodoro = (pomodoro) => {
        return (
            pomodoro?.idPomodoro ||
            pomodoro?.IdPomodoro ||
            pomodoro?.id_pomodoro ||
            pomodoro?.id ||
            pomodoro?.Id ||
            null
        );
    };

    const notificarEstadoPomodoro = useCallback(() => {
        const hayPomodoroEnCurso =
            pomodoroActivo ||
            segundosEstudioAcumulados > 0 ||
            segundosDescansoAcumulados > 0;

        if (onEstadoPomodoroChange) {
            onEstadoPomodoroChange(hayPomodoroEnCurso);
        }
    }, [pomodoroActivo, segundosEstudioAcumulados, segundosDescansoAcumulados, onEstadoPomodoroChange]);

    useEffect(() => {
        notificarEstadoPomodoro();
    }, [notificarEstadoPomodoro]);

    useEffect(() => {
        return () => {
            if (onEstadoPomodoroChange) {
                onEstadoPomodoroChange(false);
            }
        };
    }, [onEstadoPomodoroChange]);

    useEffect(() => {
        const hayPomodoroEnCurso =
            pomodoroActivo ||
            segundosEstudioAcumulados > 0 ||
            segundosDescansoAcumulados > 0;

        if (!hayPomodoroEnCurso) return;

        const advertirRecarga = (event) => {
            event.preventDefault();
            event.returnValue = 'Hay un Pomodoro en curso. Si recargás la página, el progreso se perderá.';
            return event.returnValue;
        };

        const eliminarSiLaPaginaSeAbandona = () => {
            const idPomodoro = localStorage.getItem(POMODORO_APUNTE_STORAGE_KEY);

            if (!idPomodoro) return;

            try {
                fetch(`${BASE_URL}/api/Pomodoros/${idPomodoro}`, {
                    method: 'DELETE',
                    keepalive: true,
                });
            } catch (error) {
                console.error('Error al enviar eliminación del Pomodoro abandonado:', error);
            } finally {
                localStorage.removeItem(POMODORO_APUNTE_STORAGE_KEY);
            }
        };

        window.addEventListener('beforeunload', advertirRecarga);
        window.addEventListener('pagehide', eliminarSiLaPaginaSeAbandona);

        return () => {
            window.removeEventListener('beforeunload', advertirRecarga);
            window.removeEventListener('pagehide', eliminarSiLaPaginaSeAbandona);
        };
    }, [pomodoroActivo, segundosEstudioAcumulados, segundosDescansoAcumulados, BASE_URL]);

    const cerrarModalPomodoroFinalizado = () => {
        setModalPomodoroFinalizadoAbierto(false);
    };

    const eliminarPomodoroSinGuardar = async (idPomodoro) => {
        if (!idPomodoro) return;

        try {
            await eliminarPomodoro(idPomodoro);
        } catch (error) {
            console.error('Error al eliminar Pomodoro sin guardar:', error);
        } finally {
            localStorage.removeItem(POMODORO_APUNTE_STORAGE_KEY);
        }
    };

    const actualizarTiemposPomodoro = async (idPomodoro) => {
        if (!idPomodoro) return;

        const idMateria = obtenerIdMateriaActual();
        const idApunte = obtenerIdApunteActual();

        await actualizarPomodoro(idPomodoro, {
            idPomodoro,
            idUsuario: parseInt(localStorage.getItem('idUsuario'), 10) || 1,
            idMateria: idMateria ? Number(idMateria) : null,
            idApunte: idApunte ? Number(idApunte) : null,
            fecha: new Date().toISOString(),
            duracionEstudio: segundosEstudioAcumulados,
            duracionDescanso: segundosDescansoAcumulados,
        });
    };

    const finalizarPomodoroMini = async () => {
        const idActual = pomodoroActivoId;

        setPomodoroActivo(false);

        try {
            if (idActual) {
                await actualizarTiemposPomodoro(idActual);
                await ejecutarAccion(idActual, 'finalizar');
                localStorage.removeItem(POMODORO_APUNTE_STORAGE_KEY);
            }

            setModalPomodoroFinalizadoAbierto(true);
        } catch (error) {
            console.error('Error al finalizar el Pomodoro del apunte:', error);
            alert(error.message || 'Error al finalizar el Pomodoro.');
        } finally {
            setPomodoroActivoId(null);
            setPomodoroEnDescanso(false);
            setCicloActual(1);
            setSegundosPomodoro(tiempoSesion * 60);
            setSegundosEstudioAcumulados(0);
            setSegundosDescansoAcumulados(0);
        }
    };

    const avanzarFasePomodoroMini = async () => {
        if (!pomodoroEnDescanso) {
            setPomodoroEnDescanso(true);
            setSegundosPomodoro(tiempoDescanso * 60);
            setPomodoroActivo(true);
            return;
        }

        if (cicloActual < ciclosTotales) {
            setPomodoroEnDescanso(false);
            setCicloActual((actual) => actual + 1);
            setSegundosPomodoro(tiempoSesion * 60);
            setPomodoroActivo(true);
            return;
        }

        await finalizarPomodoroMini();
    };

    useEffect(() => {
        if (!pomodoroActivo || segundosPomodoro <= 0) return;

        const intervalo = setInterval(() => {
            setSegundosPomodoro((actual) => Math.max(0, actual - 1));

            if (pomodoroEnDescanso) {
                setSegundosDescansoAcumulados((actual) => actual + 1);
            } else {
                setSegundosEstudioAcumulados((actual) => actual + 1);
            }
        }, 1000);

        return () => clearInterval(intervalo);
    }, [pomodoroActivo, segundosPomodoro, pomodoroEnDescanso]);

    useEffect(() => {
        if (segundosPomodoro !== 0) return;

        avanzarFasePomodoroMini();
        // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [segundosPomodoro]);

    const iniciarPomodoroMini = async () => {
        try {
            const idMateria = obtenerIdMateriaActual();
            const idApunte = obtenerIdApunteActual();

            if (!idMateria || !idApunte) {
                alert('No se encontró la materia o el apunte activo para iniciar el Pomodoro.');
                return;
            }

            if (!pomodoroActivoId) {
                const nuevoPomodoro = {
                    idUsuario: parseInt(localStorage.getItem('idUsuario'), 10) || 1,
                    idMateria: Number(idMateria),
                    idApunte: Number(idApunte),
                    fecha: new Date().toISOString(),
                    duracionEstudio: 0,
                    duracionDescanso: 0,
                    estadoFase: 0,
                };

                const creado = await crearPomodoro(nuevoPomodoro);
                const idCreado = obtenerIdPomodoro(creado);

                if (!idCreado) {
                    throw new Error('El backend no devolvió el ID del Pomodoro creado.');
                }

                setPomodoroActivoId(idCreado);
                localStorage.setItem(POMODORO_APUNTE_STORAGE_KEY, String(idCreado));
                await ejecutarAccion(idCreado, 'iniciar');
                setPomodoroActivo(true);
                return;
            }

            await ejecutarAccion(pomodoroActivoId, 'reanudar');
            setPomodoroActivo(true);
        } catch (error) {
            console.error('Error al iniciar/reanudar Pomodoro del apunte:', error);
            alert(error.message || 'Error al iniciar el Pomodoro.');
        }
    };

    const pausarPomodoroMini = async () => {
        try {
            if (pomodoroActivoId) {
                await actualizarTiemposPomodoro(pomodoroActivoId);
                await ejecutarAccion(pomodoroActivoId, 'pausar');
            }

            setPomodoroActivo(false);
        } catch (error) {
            console.error('Error al pausar Pomodoro del apunte:', error);
            alert(error.message || 'Error al pausar el Pomodoro.');
        }
    };

    const alternarPomodoroMini = async () => {
        if (pomodoroActivo) {
            await pausarPomodoroMini();
            return;
        }

        await iniciarPomodoroMini();
    };

    const saltarFasePomodoroMini = async () => {
        try {
            if (pomodoroActivoId) {
                await actualizarTiemposPomodoro(pomodoroActivoId);
            }

            // Se mantiene la misma lógica visual/local del Pomodoro principal:
            // saltar fase cambia entre estudio y descanso sin cerrar el registro
            // hasta que se completan todos los ciclos.
            await avanzarFasePomodoroMini();
        } catch (error) {
            console.error('Error al saltar fase del Pomodoro del apunte:', error);
            alert(error.message || 'Error al saltar la fase.');
        }
    };

    const resetearPomodoroMini = async () => {
        const idActual = pomodoroActivoId;

        setPomodoroActivo(false);
        setPomodoroEnDescanso(false);
        setCicloActual(1);
        setSegundosPomodoro(tiempoSesion * 60);
        setSegundosEstudioAcumulados(0);
        setSegundosDescansoAcumulados(0);
        setPomodoroActivoId(null);

        // Reiniciar NO debe guardar el Pomodoro en historial.
        // Si ya se había creado en la BD para manejar el State, se elimina.
        await eliminarPomodoroSinGuardar(idActual);
    };

    const abrirConfiguracionPomodoro = () => {
        setDraftSesion(tiempoSesion);
        setDraftDescanso(tiempoDescanso);
        setDraftCiclos(ciclosTotales);
        setEditandoConfigPomodoro(false);
        setConfigPomodoroAbierta(true);
    };

    const cerrarConfiguracionPomodoro = () => {
        setConfigPomodoroAbierta(false);
        setEditandoConfigPomodoro(false);
    };

    const alternarEdicionConfigPomodoro = () => {
        if (editandoConfigPomodoro) {
            setTiempoSesion(Math.max(1, Number(draftSesion) || 25));
            setTiempoDescanso(Math.max(1, Number(draftDescanso) || 5));
            setCiclosTotales(Math.max(1, Number(draftCiclos) || 4));
        } else {
            setDraftSesion(tiempoSesion);
            setDraftDescanso(tiempoDescanso);
            setDraftCiclos(ciclosTotales);
        }

        setEditandoConfigPomodoro((actual) => !actual);
    };

    const aplicarConfiguracionPomodoro = async () => {
        const nuevaSesion = Math.max(1, Number(draftSesion) || tiempoSesion);
        const nuevoDescanso = Math.max(1, Number(draftDescanso) || tiempoDescanso);
        const nuevosCiclos = Math.max(1, Number(draftCiclos) || ciclosTotales);

        if (pomodoroActivoId) {
            await eliminarPomodoroSinGuardar(pomodoroActivoId);
        }

        setTiempoSesion(nuevaSesion);
        setTiempoDescanso(nuevoDescanso);
        setCiclosTotales(nuevosCiclos);
        setSegundosPomodoro(nuevaSesion * 60);
        setCicloActual(1);
        setPomodoroEnDescanso(false);
        setPomodoroActivo(false);
        setPomodoroActivoId(null);
        setSegundosEstudioAcumulados(0);
        setSegundosDescansoAcumulados(0);
        setConfigPomodoroAbierta(false);
        setEditandoConfigPomodoro(false);
    };

    const obtenerRangoSeleccionEditor = () => {
        const editor = editorRef.current;
        const selection = window.getSelection();

        if (!editor || !selection || selection.rangeCount === 0) return null;

        const range = selection.getRangeAt(0);
        const empiezaDentro = editor.contains(range.startContainer);
        const terminaDentro = editor.contains(range.endContainer);

        if (!empiezaDentro || !terminaDentro) return null;

        return range.cloneRange();
    };

    const guardarSeleccionEditor = () => {
        const range = obtenerRangoSeleccionEditor();
        if (range) {
            seleccionEditorRef.current = range;
        }
    };

    // Cargar datos al montar o cuando cambia el apunte
    useEffect(() => {
        if (!apunteSeleccionado) return;

        const tituloInicial = apunteSeleccionado.titulo || apunteSeleccionado.Titulo || '';
        const contenidoInicial = apunteSeleccionado.contenido || apunteSeleccionado.Contenido || '';

        setTitulo(tituloInicial);

        if (editorRef.current) {
            editorRef.current.innerHTML = contenidoInicial;
        }

        setHayCambiosSinGuardar(false);
    }, [apunteSeleccionado]);

    // Ajustar alto del título cuando ocupa más de una línea
    useEffect(() => {
        const tituloEl = tituloRef.current;

        if (!tituloEl) return;

        tituloEl.style.height = 'auto';
        tituloEl.style.height = `${tituloEl.scrollHeight}px`;
    }, [titulo]);

    // Limpiar toast automáticamente
    useEffect(() => {
        if (saveStatus === 'success' || saveStatus === 'error') {
            const timer = setTimeout(() => setSaveStatus(null), 2500);
            return () => clearTimeout(timer);
        }
    }, [saveStatus]);

    useEffect(() => {
        const handleBeforeUnload = (e) => {
            if (!hayCambiosSinGuardar) return;

            e.preventDefault();
            e.returnValue = '';
        };

        window.addEventListener('beforeunload', handleBeforeUnload);

        return () => {
            window.removeEventListener('beforeunload', handleBeforeUnload);
        };
    }, [hayCambiosSinGuardar]);



    useEffect(() => {
        const guardarSeleccionGlobal = () => {
            guardarSeleccionEditor();
        };

        document.addEventListener('selectionchange', guardarSeleccionGlobal);

        return () => {
            document.removeEventListener('selectionchange', guardarSeleccionGlobal);
        };
    }, []);

    // -----------------------------------------------------------------------
    // Handlers de toolbar
    // -----------------------------------------------------------------------
    const handleBold = () => {
        editorRef.current?.focus();
        execCmd('bold');
        setHayCambiosSinGuardar(true);
    };

    const seleccionEstaEnCursiva = (range) => {
        const nodo = range.startContainer;
        const elemento = nodo.nodeType === Node.TEXT_NODE ? nodo.parentElement : nodo;

        if (!elemento || !editorRef.current?.contains(elemento)) return false;

        const estilo = window.getComputedStyle(elemento);
        return estilo.fontStyle === 'italic' || estilo.fontStyle === 'oblique';
    };

    const limpiarFontStyleDelFragmento = (fragmento) => {
        // Sacar font-style inline de cualquier elemento seleccionado
        fragmento.querySelectorAll?.('[style]').forEach((el) => {
            el.style.removeProperty('font-style');

            if (!el.getAttribute('style')) {
                el.removeAttribute('style');
            }
        });

        // Convertir <i> y <em> en <span> para que no sigan forzando cursiva
        fragmento.querySelectorAll?.('i, em').forEach((el) => {
            const span = document.createElement('span');

            while (el.firstChild) {
                span.appendChild(el.firstChild);
            }

            el.replaceWith(span);
        });
    };

    const handleItalic = () => {
        const editor = editorRef.current;
        const selection = window.getSelection();

        if (!editor || !selection) return;

        let range = obtenerRangoSeleccionEditor();

        if (!range && seleccionEditorRef.current) {
            range = seleccionEditorRef.current.cloneRange();
        }

        if (!range) return;

        editor.focus({ preventScroll: true });

        selection.removeAllRanges();
        selection.addRange(range);

        if (range.collapsed) {
            execCmd('italic');
            seleccionEditorRef.current = range.cloneRange();
            setHayCambiosSinGuardar(true);
            return;
        }

        const yaEstaEnCursiva = seleccionEstaEnCursiva(range);
        const contenidoSeleccionado = range.extractContents();

        limpiarFontStyleDelFragmento(contenidoSeleccionado);

        const span = document.createElement('span');

        span.style.setProperty(
            'font-style',
            yaEstaEnCursiva ? 'normal' : 'italic',
            'important'
        );

        span.appendChild(contenidoSeleccionado);
        range.insertNode(span);

        const nuevoRange = document.createRange();
        nuevoRange.selectNodeContents(span);

        selection.removeAllRanges();
        selection.addRange(nuevoRange);

        seleccionEditorRef.current = nuevoRange.cloneRange();

        setHayCambiosSinGuardar(true);
    };

    const handleUnderline = () => {
        editorRef.current?.focus();
        execCmd('underline');
        setHayCambiosSinGuardar(true);
    };

    const handleBulletList = () => {
        editorRef.current?.focus();
        execCmd('insertUnorderedList');
        setHayCambiosSinGuardar(true);
    };

    const handleNumberedList = () => {
        editorRef.current?.focus();
        execCmd('insertOrderedList');
        setHayCambiosSinGuardar(true);
    };

    const confirmarSalidaSinGuardar = () => {
    if (!hayCambiosSinGuardar) return true;

    return window.confirm(
        'Tenés cambios sin guardar. ¿Querés salir sin guardar?'
    );
};

    const handleVolver = () => {
        if (!confirmarSalidaSinGuardar()) return;
        onVolver?.();
    };

    const handleCambioTitulo = (e) => {
        setTitulo(e.target.value);
        setHayCambiosSinGuardar(true);
    };

    const handleCambioContenido = () => {
        setHayCambiosSinGuardar(true);
    };

    // -----------------------------------------------------------------------
    // Guardar
    // -----------------------------------------------------------------------
    const handleGuardar = async () => {
        if (!apunteSeleccionado) return;

        const contenidoActualizado = editorRef.current?.innerHTML || '';

        const id =
            apunteSeleccionado.id_apunte ||
            apunteSeleccionado.idApunte ||
            apunteSeleccionado.IdApunte ||
            apunteSeleccionado.id ||
            apunteSeleccionado.Id;

        if (!id) {
            console.error('No se encontró ID del apunte:', apunteSeleccionado);
            setSaveStatus('error');
            return;
        }

        setSaveStatus('loading');

        try {
            const apunteActualizado = {
                ...apunteSeleccionado,
                idApunte: id,
                titulo,
                Titulo: titulo,
                contenido: contenidoActualizado,
                Contenido: contenidoActualizado,
            };

            const ok = await apunteService.actualizar(id, apunteActualizado);

            if (!ok) {
                throw new Error('No se pudo actualizar el apunte');
            }

            setHayCambiosSinGuardar(false);
            setSaveStatus('success');
        } catch (err) {
            console.error('Error al guardar:', err);
            setSaveStatus('error');
        }
    };

    const formatearFechaCreacion = (apunte) => {
        const fecha =
            apunte.fecha_creacion ||
            apunte.fechaCreacion ||
            apunte.FechaCreacion ||
            apunte.createdAt ||
            apunte.CreatedAt;

        if (!fecha) return 'Creado sin fecha';

        const date = new Date(fecha);

        // Ajuste por zona horaria, igual que hiciste con modificación
        date.setHours(date.getHours() - 3);

        if (Number.isNaN(date.getTime())) return 'Creado sin fecha';

        const dia = String(date.getDate()).padStart(2, '0');
        const mes = String(date.getMonth() + 1).padStart(2, '0');
        const anio = date.getFullYear();

        const hora = String(date.getHours()).padStart(2, '0');
        const minutos = String(date.getMinutes()).padStart(2, '0');

        return `Creado ${dia}/${mes}/${anio} - ${hora}:${minutos}`;
    };




    // -----------------------------------------------------------------------
    // UI helpers
    // -----------------------------------------------------------------------
    const toolbarBtnClass = (active) =>
        `p-2 rounded-lg transition-all duration-150 ${
            active
                ? 'bg-[#3A5A82] text-white shadow-inner'
                : 'text-[#586064] hover:text-[#3A5A82] hover:bg-slate-100'
        }`;

    // -----------------------------------------------------------------------
    // Render sin apunte
    // -----------------------------------------------------------------------
    if (!apunteSeleccionado) {
        return (
            <div className="flex-1 p-8 text-center text-slate-500 font-['Inter']">
                <button onClick={onVolver} className="mb-4 text-[#3A5A82] hover:underline font-bold">
                    ← Volver a la lista
                </button>
                <p>No se seleccionó ningún apunte.</p>
            </div>
        );
    }

    const etiquetaPomodoroMini = pomodoroEnDescanso
        ? 'Descanso'
        : `Sesion ${cicloActual}/${ciclosTotales}`;

    const iconoPomodoroMini = pomodoroEnDescanso ? 'coffee' : 'timer';

    // -----------------------------------------------------------------------
    // Render principal
    // -----------------------------------------------------------------------
    return (
        <div className="flex-1 flex flex-col bg-[#f1f4f6] font-['Inter'] relative" style={{ minHeight: 0, overflow: 'hidden' }}>

            {/* Modales y toasts */}
            <Toast status={saveStatus} />

            {/* Acciones superiores (Volver + Guardar) */}
            <div className="absolute top-6 left-8 flex items-center gap-3 z-40">
                <button
                    onClick={handleVolver}
                    className="flex items-center gap-1.5 text-slate-500 hover:text-[#3A5A82] transition-colors font-semibold text-sm"
                >
                    <span className="material-symbols-outlined text-lg">arrow_back</span>
                    Volver
                </button>

                <span className="text-slate-300 select-none">|</span>

                <button
                    onClick={handleGuardar}
                    disabled={saveStatus === 'loading'}
                    className={`flex items-center gap-1.5 px-4 py-1.5 rounded-full text-sm font-semibold transition-all duration-200 shadow-sm
                        ${saveStatus === 'loading'
                            ? 'bg-[#3A5A82]/60 text-white cursor-not-allowed'
                            : 'bg-[#3A5A82] text-white hover:bg-[#2e4a6e] hover:shadow-md active:scale-95'
                        }`}
                >
                    {saveStatus === 'loading' ? (
                        <>
                            <svg className="animate-spin h-3.5 w-3.5" viewBox="0 0 24 24" fill="none">
                                <circle className="opacity-25" cx="12" cy="12" r="10" stroke="currentColor" strokeWidth="4" />
                                <path className="opacity-75" fill="currentColor" d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4z" />
                            </svg>
                            Guardando…
                        </>
                    ) : (
                        <>
                            <span className="material-symbols-outlined text-[16px]">save</span>
                            Guardar
                        </>
                    )}
                </button>

                <span className="text-sm font-semibold text-slate-500">
                    {formatearFechaCreacion(apunteSeleccionado)}
                </span>
            </div>

            {/* Pomodoro compacto del apunte */}
            <div className="absolute top-5 right-8 z-40 flex items-center gap-3 px-4 py-2 bg-[#eef3fb] border border-[#d6e3ff] rounded-xl shadow-sm">
                <span className="font-['Manrope'] text-sm font-semibold text-[#465365] whitespace-nowrap">
                    {etiquetaPomodoroMini}
                </span>

                <div className="flex items-center gap-2">
                    <span className={`material-symbols-outlined text-[#3A5A82] text-[20px] ${pomodoroActivo ? 'animate-pulse' : ''}`}>
                        {iconoPomodoroMini}
                    </span>
                    <span className="font-bold text-[#3A5A82] text-base tracking-tight">
                        {formatearTiempoPomodoro(segundosPomodoro)}
                    </span>
                </div>

                <div className="h-5 w-px bg-[#c8d5eb]" />

                <div className="flex items-center gap-1">
                    <button
                        type="button"
                        onClick={abrirConfiguracionPomodoro}
                        className="p-1 rounded-md text-[#3A5A82] hover:bg-[#d6e3ff] transition-colors"
                        title="Configuración de sesión"
                    >
                        <span className="material-symbols-outlined text-[20px]">settings</span>
                    </button>

                    <button
                        type="button"
                        onClick={alternarPomodoroMini}
                        className="p-1 rounded-md text-[#3A5A82] hover:bg-[#d6e3ff] transition-colors"
                        title={pomodoroActivo ? 'Pausar' : 'Iniciar'}
                    >
                        <span className="material-symbols-outlined text-[20px]">
                            {pomodoroActivo ? 'pause' : 'play_arrow'}
                        </span>
                    </button>

                    <button
                        type="button"
                        onClick={saltarFasePomodoroMini}
                        className="p-1 rounded-md text-[#3A5A82] hover:bg-[#d6e3ff] transition-colors"
                        title="Saltar fase"
                    >
                        <span className="material-symbols-outlined text-[20px]">skip_next</span>
                    </button>

                    <button
                        type="button"
                        onClick={resetearPomodoroMini}
                        className="p-1 rounded-md text-[#3A5A82] hover:bg-[#d6e3ff] transition-colors"
                        title="Reiniciar"
                    >
                        <span className="material-symbols-outlined text-[20px]">refresh</span>
                    </button>
                </div>
            </div>

            {modalPomodoroFinalizadoAbierto && (
                <div className="fixed inset-0 bg-slate-900/40 backdrop-blur-[2px] flex items-center justify-center z-[2100]">
                    <div className="w-full max-w-[420px] bg-white rounded-xl p-8 shadow-2xl text-center">
                        <div className="w-14 h-14 mx-auto mb-4 rounded-full bg-[#eef3fb] border border-[#d6e3ff] flex items-center justify-center">
                            <span className="material-symbols-outlined text-[#3A5A82] text-[30px]">check_circle</span>
                        </div>

                        <h3 className="text-xl font-extrabold text-[#2D3247] m-0 mb-2">
                            Pomodoro completado
                        </h3>

                        <p className="text-sm text-slate-500 leading-relaxed mb-6">
                            Terminaste todos los ciclos de estudio y descanso para este apunte.
                        </p>

                        <button
                            type="button"
                            onClick={cerrarModalPomodoroFinalizado}
                            className="bg-[#3A5A82] text-white border-none px-5 py-2.5 rounded-lg font-bold hover:bg-[#2e4a6e]"
                        >
                            Aceptar
                        </button>
                    </div>
                </div>
            )}

            {configPomodoroAbierta && (
                <div className="fixed inset-0 bg-slate-900/40 backdrop-blur-[2px] flex items-center justify-center z-[2000]">
                    <div className="w-full max-w-[440px] bg-white rounded-xl p-8 shadow-2xl">
                        <div className="flex items-start justify-between gap-4 mb-6">
                            <div>
                                <h3 className="text-xl font-bold text-[#2D3247] m-0">Configuración Pomodoro</h3>
                                <p className="text-sm text-slate-400 mt-1 mb-0">
                                    Ajusta tu sesión de trabajo profundo.
                                </p>
                            </div>

                            <button
                                type="button"
                                onClick={cerrarConfiguracionPomodoro}
                                className="text-slate-400 hover:text-slate-700 p-1 rounded-md"
                            >
                                <span className="material-symbols-outlined text-[20px]">close</span>
                            </button>
                        </div>

                        <div className="bg-[#f6f8fe] border border-[#e8ebff] rounded-xl p-5 mb-4">
                            <div className="flex items-center justify-between mb-5">
                                <div className="flex items-center gap-2 text-[#2D3247] font-bold">
                                    <span className="material-symbols-outlined text-[#3A5A82] text-[20px]">settings</span>
                                    Configuración activa
                                </div>
                                <span className="text-[0.65rem] font-extrabold tracking-[0.12em] text-[#3A56AF] bg-[#eef1ff] px-2 py-1 rounded">
                                    RECOMENDADA
                                </span>
                            </div>

                            <div className="grid grid-cols-3 gap-3">
                                <div className="text-center">
                                    <p className="text-[0.68rem] uppercase tracking-[0.08em] text-slate-400 font-bold mb-2">
                                        Sesión (min)
                                    </p>
                                    {editandoConfigPomodoro ? (
                                        <input
                                            type="number"
                                            min="1"
                                            value={draftSesion}
                                            onChange={(e) => setDraftSesion(e.target.value)}
                                            className="w-full rounded-lg border border-[#d6e3ff] text-center font-bold text-[#2D3247]"
                                        />
                                    ) : (
                                        <p className="text-2xl font-extrabold text-[#2D3247] m-0">{tiempoSesion}</p>
                                    )}
                                </div>

                                <div className="text-center">
                                    <p className="text-[0.68rem] uppercase tracking-[0.08em] text-slate-400 font-bold mb-2">
                                        Descanso (min)
                                    </p>
                                    {editandoConfigPomodoro ? (
                                        <input
                                            type="number"
                                            min="1"
                                            value={draftDescanso}
                                            onChange={(e) => setDraftDescanso(e.target.value)}
                                            className="w-full rounded-lg border border-[#d6e3ff] text-center font-bold text-[#2D3247]"
                                        />
                                    ) : (
                                        <p className="text-2xl font-extrabold text-[#2D3247] m-0">{tiempoDescanso}</p>
                                    )}
                                </div>

                                <div className="text-center">
                                    <p className="text-[0.68rem] uppercase tracking-[0.08em] text-slate-400 font-bold mb-2">
                                        Ciclos
                                    </p>
                                    {editandoConfigPomodoro ? (
                                        <input
                                            type="number"
                                            min="1"
                                            value={draftCiclos}
                                            onChange={(e) => setDraftCiclos(e.target.value)}
                                            className="w-full rounded-lg border border-[#d6e3ff] text-center font-bold text-[#2D3247]"
                                        />
                                    ) : (
                                        <p className="text-2xl font-extrabold text-[#2D3247] m-0">{ciclosTotales}</p>
                                    )}
                                </div>
                            </div>
                        </div>

                        <button
                            type="button"
                            onClick={alternarEdicionConfigPomodoro}
                            className="w-full flex items-center justify-center gap-2 mb-5 py-2.5 rounded-lg border border-[#d6e3ff] text-[#3A5A82] font-bold hover:bg-[#eef3fb] transition-colors"
                        >
                            <span className="material-symbols-outlined text-[18px]">
                                {editandoConfigPomodoro ? 'check' : 'edit'}
                            </span>
                            {editandoConfigPomodoro ? 'Confirmar valores' : 'Editar preajuste'}
                        </button>

                        <div className="flex justify-end gap-3">
                            <button
                                type="button"
                                onClick={aplicarConfiguracionPomodoro}
                                className="bg-[#3A5A82] text-white border-none px-5 py-2.5 rounded-lg font-bold hover:bg-[#2e4a6e]"
                            >
                                Aplicar configuración
                            </button>

                            <button
                                type="button"
                                onClick={cerrarConfiguracionPomodoro}
                                className="bg-transparent text-slate-500 border-none px-4 py-2.5 font-bold"
                            >
                                Cancelar
                            </button>
                        </div>
                    </div>
                </div>
            )}

            {/* Lienzo principal */}
            <section className="flex-1 overflow-y-auto" style={{ minHeight: 0 }}>
                <div className="max-w-3xl mx-auto py-16 px-8">

                    {/* Toolbar flotante (Glassmorphism) */}
                    <div className="glass-toolbar sticky top-4 mb-12 p-1 rounded-full border border-white/40 shadow-xl flex items-center gap-1 justify-center max-w-fit mx-auto z-30 bg-white/80 backdrop-blur-md">

                        {/* Formato básico */}
                        <div className="flex items-center px-2 border-r border-[#abb3b7]/20">
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleBold(); }}
                                className={toolbarBtnClass(activeFormats.bold)}
                                title="Negrita"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_bold</span>
                            </button>
                            <button
                                onMouseDown={(e) => { e.preventDefault(); guardarSeleccionEditor(); handleItalic(); }}
                                className={toolbarBtnClass(activeFormats.italic)}
                                title="Cursiva"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_italic</span>
                            </button>
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleUnderline(); }}
                                className={toolbarBtnClass(activeFormats.underline)}
                                title="Subrayado"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_underlined</span>
                            </button>
                        </div>

                        {/* Listas */}
                        <div className="flex items-center px-2">
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleBulletList(); }}
                                className={toolbarBtnClass(activeFormats.insertUnorderedList)}
                                title="Lista de viñetas"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_list_bulleted</span>
                            </button>
                            <button
                                onMouseDown={(e) => { e.preventDefault(); handleNumberedList(); }}
                                className={toolbarBtnClass(activeFormats.insertOrderedList)}
                                title="Lista numerada"
                            >
                                <span className="material-symbols-outlined text-[20px]">format_list_numbered</span>
                            </button>
                        </div>
                    </div>

                    {/* Título editable */}
                    <textarea
                        ref={tituloRef}
                        className="w-full bg-transparent border-none focus:ring-0 font-extrabold font-['Manrope'] tracking-tight text-[#2b3437] mb-8 block outline-none placeholder-slate-300 resize-none overflow-hidden"
                        value={titulo}
                        onChange={handleCambioTitulo}
                        placeholder="Sin título"
                        rows={1}
                        style={{
                            fontSize: 'clamp(2rem, 5vw, 3rem)',
                            lineHeight: 1.12,
                            wordBreak: 'break-word',
                            overflowWrap: 'anywhere',
                            padding: 0,
                        }}
                    />

                    {/* Cuerpo editable */}
                    <div
                        ref={editorRef}
                        contentEditable
                        suppressContentEditableWarning
                        spellCheck
                        onMouseUp={guardarSeleccionEditor}
                        onKeyUp={guardarSeleccionEditor}
                        onBlur={guardarSeleccionEditor}
                        onInput={(e) => {
                            guardarSeleccionEditor();
                            handleCambioContenido(e);
                        }}
                        data-placeholder="Empezá a escribir tu apunte…"
                        className="
                            prose prose-slate max-w-none text-lg text-[#465365] leading-relaxed font-body
                            focus:outline-none min-h-[300px]
                            [&_a]:text-[#3A5A82] [&_a]:underline
                            [&_em]:italic [&_i]:italic
                            [&_strong]:font-bold [&_b]:font-bold
                            [&_u]:underline
                            [&_blockquote]:border-l-4 [&_blockquote]:border-[#3A5A82]
                            [&_blockquote]:pl-4 [&_blockquote]:italic [&_blockquote]:text-[#586064]
                            [&_blockquote]:bg-[#eef1f4] [&_blockquote]:rounded-r-lg [&_blockquote]:py-2
                            [&_ul]:list-disc [&_ul]:pl-6
                            [&_ol]:list-decimal [&_ol]:pl-6
                            empty:before:content-[attr(data-placeholder)] empty:before:text-slate-400
                        "
                        style={{ caretColor: '#3A5A82' }}
                    />

                </div>
            </section>
        </div>
    );
};

export default VerApunte;