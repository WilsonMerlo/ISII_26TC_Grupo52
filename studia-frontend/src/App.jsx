import React, { useEffect, useMemo, useState } from 'react';
import './App.css';
import {
    BrowserRouter,
    Navigate,
    Route,
    Routes,
    useLocation,
    useNavigate,
    useParams
} from 'react-router-dom';

// ── VIEWS ──
import Login from './pages/Login';
import Registro from './pages/Registro';
import RecuperarPassword from './pages/RecuperarPassword';

// ── DASHBOARD & COMPONENTS ──
import DashboardLayout from './components/DashboardLayout';
import PomodoroTimer from './components/PomodoroTimer';
import MateriasDashboard from './pages/MateriasDashboard';
import EditorApunte from './components/EditorApunte';
import ApuntesDashboard from './pages/ApuntesDashboard';
import VerApunte from './pages/VerApunte';
import EstadisticasDashboard from './pages/EstadisticasDashboard';
import MenuDashboard from './pages/MenuDashboard';
import MisDatosDashboard from './pages/MisDatosDashboard';

import { eliminarPomodoro } from './services/pomodoroService';
import { apunteService } from './services/apunteService';

const POMODORO_APUNTE_STORAGE_KEY = 'pomodoroApunteActivoId';

const obtenerIdMateria = (materia) => {
    return (
        materia?.idMateria ||
        materia?.IdMateria ||
        materia?.id_materia ||
        materia?.id ||
        materia?.Id ||
        null
    );
};

const obtenerNombreMateria = (materia) => {
    return (
        materia?.nombreMateria ||
        materia?.NombreMateria ||
        materia?.nombre_materia ||
        materia?.nombre ||
        materia?.Nombre ||
        'Materia'
    );
};

const obtenerIdApunte = (apunte) => {
    return (
        apunte?.idApunte ||
        apunte?.IdApunte ||
        apunte?.id_apunte ||
        apunte?.id ||
        apunte?.Id ||
        null
    );
};

const obtenerVistaDesdePath = (pathname) => {
    if (pathname.startsWith('/materias')) return 'materias';
    if (pathname.startsWith('/pomodoro')) return 'dashboard';
    if (pathname.startsWith('/estadisticas')) return 'estadisticas';
    if (pathname.startsWith('/mis-datos')) return 'misDatos';
    if (pathname.startsWith('/menu')) return 'menu';
    if (pathname.startsWith('/registro')) return 'registro';
    if (pathname.startsWith('/recuperar')) return 'recuperar';
    if (pathname.startsWith('/login')) return 'login';

    return 'menu';
};

const RutaPrivada = ({ children }) => {
    const idUsuario = localStorage.getItem('idUsuario');

    if (!idUsuario) {
        return <Navigate to="/login" replace />;
    }

    return children;
};

function App() {
    return (
        <BrowserRouter>
            <AppRoutes />
        </BrowserRouter>
    );
}


const RedireccionInicial = () => {
    const idUsuario = localStorage.getItem('idUsuario');

    if (idUsuario) {
        return <Navigate to="/menu" replace />;
    }

    return <Navigate to="/login" replace />;
};

const PaginaApuntes = ({ materiaActiva, navegarA, renderDashboard }) => {
    const { idMateria } = useParams();

    const materiaRuta =
        materiaActiva && String(obtenerIdMateria(materiaActiva)) === String(idMateria)
            ? materiaActiva
            : {
                idMateria: Number(idMateria),
                nombreMateria: obtenerNombreMateria(materiaActiva) || `Materia ${idMateria}`
            };

    return renderDashboard(
        <ApuntesDashboard
            materia={materiaRuta}
            onVolver={() => navegarA('materias')}
            onNuevoApunte={() => navegarA('editor', materiaRuta)}
            onVerApunte={(apunte) => navegarA('verApunte', { apunte, materia: materiaRuta })}
        />
    );
};

const PaginaEditorApunte = ({ materiaActiva, navegarA, renderDashboard }) => {
    const { idMateria } = useParams();

    const materiaRuta =
        materiaActiva && String(obtenerIdMateria(materiaActiva)) === String(idMateria)
            ? materiaActiva
            : {
                idMateria: Number(idMateria),
                nombreMateria: obtenerNombreMateria(materiaActiva) || `Materia ${idMateria}`
            };

    return renderDashboard(
        <EditorApunte
            idMateriaActiva={Number(idMateria)}
            nombreMateria={obtenerNombreMateria(materiaRuta)}
            onVolver={() => navegarA('apuntes', materiaRuta)}
        />
    );
};

const PaginaVerApunte = ({
    materiaActiva,
    apunteActivo,
    guardarApunteActivo,
    navegarA,
    renderDashboard,
    setPomodoroEnCurso
}) => {
    const { idMateria, idApunte } = useParams();

    const [apunteCargado, setApunteCargado] = useState(() => {
        if (apunteActivo && String(obtenerIdApunte(apunteActivo)) === String(idApunte)) {
            return apunteActivo;
        }

        return null;
    });

    const [cargandoApunte, setCargandoApunte] = useState(!apunteCargado);

    useEffect(() => {
        let activo = true;

        const cargarApunte = async () => {
            if (
                apunteActivo &&
                String(obtenerIdApunte(apunteActivo)) === String(idApunte)
            ) {
                setApunteCargado(apunteActivo);
                setCargandoApunte(false);
                return;
            }

            try {
                setCargandoApunte(true);
                const data = await apunteService.obtenerPorId(idApunte);

                if (!activo) return;

                if (data) {
                    setApunteCargado(data);
                    guardarApunteActivo(data);
                }
            } catch (error) {
                console.error('Error al cargar apunte por URL:', error);
            } finally {
                if (activo) {
                    setCargandoApunte(false);
                }
            }
        };

        cargarApunte();

        return () => {
            activo = false;
        };
    }, [idApunte]);

    const materiaRuta =
        materiaActiva && String(obtenerIdMateria(materiaActiva)) === String(idMateria)
            ? materiaActiva
            : {
                idMateria: Number(idMateria),
                nombreMateria:
                    apunteCargado?.nombreMateria ||
                    apunteCargado?.NombreMateria ||
                    obtenerNombreMateria(materiaActiva) ||
                    `Materia ${idMateria}`
            };

    if (cargandoApunte) {
        return renderDashboard(
            <div style={estilosCarga.contenedor}>
                <p style={estilosCarga.texto}>Cargando apunte...</p>
            </div>
        );
    }

    return renderDashboard(
        <VerApunte
            apunteSeleccionado={apunteCargado}
            materiaActiva={materiaRuta}
            onVolver={() => navegarA('apuntes', materiaRuta)}
            onEstadoPomodoroChange={setPomodoroEnCurso}
        />
    );
};

function AppRoutes() {
    const navigate = useNavigate();
    const location = useLocation();

    const vistaActual = useMemo(
        () => obtenerVistaDesdePath(location.pathname),
        [location.pathname]
    );

    const [materiaActiva, setMateriaActiva] = useState(() => {
        try {
            const materiaGuardada = localStorage.getItem('materiaActiva');
            return materiaGuardada ? JSON.parse(materiaGuardada) : null;
        } catch {
            return null;
        }
    });

    const [apunteActivo, setApunteActivo] = useState(() => {
        try {
            const apunteGuardado = localStorage.getItem('apunteActivo');
            return apunteGuardado ? JSON.parse(apunteGuardado) : null;
        } catch {
            return null;
        }
    });

    const [pomodoroEnCurso, setPomodoroEnCurso] = useState(false);
    const [avisoSalidaPomodoro, setAvisoSalidaPomodoro] = useState({
        abierto: false,
        tipo: null,
        vista: null,
        datosExtra: null,
    });

    const nombreParaAvatar = localStorage.getItem('nombreUsuario') || 'Usuario';
    const RAW_BASE_URL = import.meta.env.VITE_API_URL || 'https://localhost:7068';
    const API_BASE_URL = RAW_BASE_URL.endsWith('/api')
        ? RAW_BASE_URL
        : `${RAW_BASE_URL}/api`;

    const eliminarPomodoroActivoSinGuardar = async () => {
        const idPomodoro = localStorage.getItem(POMODORO_APUNTE_STORAGE_KEY);

        if (!idPomodoro) return;

        try {
            await eliminarPomodoro(idPomodoro);
        } catch (error) {
            console.error('Error al eliminar Pomodoro abandonado:', error);
        } finally {
            localStorage.removeItem(POMODORO_APUNTE_STORAGE_KEY);
        }
    };

    useEffect(() => {
        if (!pomodoroEnCurso) return;

        const advertirRecarga = (event) => {
            event.preventDefault();
            event.returnValue = 'Hay un Pomodoro en curso. Si recargás la página, el progreso se perderá.';
            return event.returnValue;
        };

        const eliminarSiLaPaginaSeAbandona = () => {
            const idPomodoro = localStorage.getItem(POMODORO_APUNTE_STORAGE_KEY);

            if (!idPomodoro) return;

            try {
                fetch(`${API_BASE_URL}/Pomodoros/${idPomodoro}`, {
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
    }, [pomodoroEnCurso, API_BASE_URL]);

    const guardarMateriaActiva = (materia) => {
        if (!materia) return;

        setMateriaActiva(materia);
        localStorage.setItem('materiaActiva', JSON.stringify(materia));
    };

    const guardarApunteActivo = (apunte) => {
        if (!apunte) return;

        setApunteActivo(apunte);
        localStorage.setItem('apunteActivo', JSON.stringify(apunte));
    };

    const ejecutarNavegacion = (nuevaVista, datosExtra = null) => {
        localStorage.setItem('vistaActual', nuevaVista);

        switch (nuevaVista) {
            case 'login':
                navigate('/login');
                return;

            case 'registro':
                navigate('/registro');
                return;

            case 'recuperar':
                navigate('/recuperar');
                return;

            case 'menu':
                navigate('/menu');
                return;

            case 'materias':
                navigate('/materias');
                return;

            case 'dashboard':
            case 'pomodoro':
                navigate('/pomodoro');
                return;

            case 'estadisticas':
                navigate('/estadisticas');
                return;

            case 'misDatos':
                navigate('/mis-datos');
                return;

            case 'apuntes': {
                const materia = datosExtra || materiaActiva;

                if (materia) {
                    guardarMateriaActiva(materia);
                }

                const idMateria = obtenerIdMateria(materia);

                if (idMateria) {
                    navigate(`/materias/${idMateria}`);
                } else {
                    navigate('/materias');
                }

                return;
            }

            case 'editor': {
                const materia = datosExtra || materiaActiva;

                if (materia) {
                    guardarMateriaActiva(materia);
                }

                const idMateria = obtenerIdMateria(materia);

                if (idMateria) {
                    navigate(`/materias/${idMateria}/nuevo-apunte`);
                } else {
                    navigate('/materias');
                }

                return;
            }

            case 'verApunte': {
                const apunte = datosExtra?.apunte || datosExtra;
                const materia = datosExtra?.materia || materiaActiva;

                if (apunte) {
                    guardarApunteActivo(apunte);
                }

                if (materia) {
                    guardarMateriaActiva(materia);
                }

                const idApunte = obtenerIdApunte(apunte);
                const idMateria =
                    obtenerIdMateria(materia) ||
                    apunte?.idMateria ||
                    apunte?.IdMateria ||
                    apunte?.id_materia;

                if (idMateria && idApunte) {
                    navigate(`/materias/${idMateria}/apuntes/${idApunte}`);
                } else if (idMateria) {
                    navigate(`/materias/${idMateria}`);
                } else {
                    navigate('/materias');
                }

                return;
            }

            default:
                navigate('/menu');
        }
    };

    const navegarA = (nuevaVista, datosExtra = null) => {
        if (pomodoroEnCurso && nuevaVista !== vistaActual) {
            setAvisoSalidaPomodoro({
                abierto: true,
                tipo: 'navegacion',
                vista: nuevaVista,
                datosExtra,
            });
            return;
        }

        ejecutarNavegacion(nuevaVista, datosExtra);
    };

    const cerrarSesionDirecto = () => {
        localStorage.removeItem('idUsuario');
        localStorage.removeItem('nombreUsuario');
        localStorage.removeItem('correoUsuario');
        localStorage.removeItem('emailUsuario');
        localStorage.removeItem('vistaActual');
        localStorage.removeItem('materiaActiva');
        localStorage.removeItem('apunteActivo');
        localStorage.removeItem(POMODORO_APUNTE_STORAGE_KEY);

        setPomodoroEnCurso(false);
        setMateriaActiva(null);
        setApunteActivo(null);

        navigate('/login');
    };

    const manejarCerrarSesion = () => {
        if (pomodoroEnCurso) {
            setAvisoSalidaPomodoro({
                abierto: true,
                tipo: 'logout',
                vista: null,
                datosExtra: null,
            });
            return;
        }

        cerrarSesionDirecto();
    };

    const cancelarSalidaPomodoro = () => {
        setAvisoSalidaPomodoro({
            abierto: false,
            tipo: null,
            vista: null,
            datosExtra: null,
        });
    };

    const confirmarSalidaPomodoro = async () => {
        const accionPendiente = avisoSalidaPomodoro;

        await eliminarPomodoroActivoSinGuardar();

        setPomodoroEnCurso(false);
        cancelarSalidaPomodoro();

        if (accionPendiente.tipo === 'logout') {
            cerrarSesionDirecto();
            return;
        }

        if (accionPendiente.vista) {
            ejecutarNavegacion(accionPendiente.vista, accionPendiente.datosExtra);
        }
    };

    const renderAvisoSalidaPomodoro = () => {
        if (!avisoSalidaPomodoro.abierto) return null;

        return (
            <div style={estilosModalPomodoro.overlay}>
                <div style={estilosModalPomodoro.modal}>
                    <h3 style={estilosModalPomodoro.titulo}>Pomodoro en curso</h3>

                    <p style={estilosModalPomodoro.texto}>
                        Hay una sesión Pomodoro activa en este apunte.
                    </p>

                    <p style={estilosModalPomodoro.advertencia}>
                        Si abandonás esta sección o cerrás sesión, el progreso actual se perderá.
                        ¿Querés abandonar la sesión?
                    </p>

                    <div style={estilosModalPomodoro.acciones}>
                        <button
                            type="button"
                            style={estilosModalPomodoro.btnCancelar}
                            onClick={cancelarSalidaPomodoro}
                        >
                            Cancelar
                        </button>

                        <button
                            type="button"
                            style={estilosModalPomodoro.btnSalir}
                            onClick={confirmarSalidaPomodoro}
                        >
                            Abandonar sesión
                        </button>
                    </div>
                </div>
            </div>
        );
    };

    const envolverConAvisoPomodoro = (contenido) => (
        <>
            {contenido}
            {renderAvisoSalidaPomodoro()}
        </>
    );

    const renderDashboard = (contenido) => {
        return envolverConAvisoPomodoro(
            <RutaPrivada>
                <DashboardLayout
                    nombreUsuario={nombreParaAvatar}
                    onLogout={manejarCerrarSesion}
                    onNavegar={navegarA}
                    vistaActual={vistaActual}
                >
                    {contenido}
                </DashboardLayout>
            </RutaPrivada>
        );
    };


    return (
        <Routes>
            <Route path="/" element={<RedireccionInicial />} />

            <Route path="/login" element={<Login onNavegar={navegarA} />} />
            <Route path="/registro" element={<Registro onNavegar={navegarA} />} />
            <Route path="/recuperar" element={<RecuperarPassword onNavegar={navegarA} />} />

            <Route
                path="/menu"
                element={renderDashboard(<MenuDashboard onNavegar={navegarA} />)}
            />

            <Route
                path="/materias"
                element={renderDashboard(<MateriasDashboard onNavegar={navegarA} />)}
            />

            <Route
                path="/materias/:idMateria"
                element={(
                    <PaginaApuntes
                        materiaActiva={materiaActiva}
                        navegarA={navegarA}
                        renderDashboard={renderDashboard}
                    />
                )}
            />

            <Route
                path="/materias/:idMateria/nuevo-apunte"
                element={(
                    <PaginaEditorApunte
                        materiaActiva={materiaActiva}
                        navegarA={navegarA}
                        renderDashboard={renderDashboard}
                    />
                )}
            />

            <Route
                path="/materias/:idMateria/apuntes/:idApunte"
                element={(
                    <PaginaVerApunte
                        materiaActiva={materiaActiva}
                        apunteActivo={apunteActivo}
                        guardarApunteActivo={guardarApunteActivo}
                        navegarA={navegarA}
                        renderDashboard={renderDashboard}
                        setPomodoroEnCurso={setPomodoroEnCurso}
                    />
                )}
            />

            <Route
                path="/materias/:idMateria/:idApunte"
                element={(
                    <PaginaVerApunte
                        materiaActiva={materiaActiva}
                        apunteActivo={apunteActivo}
                        guardarApunteActivo={guardarApunteActivo}
                        navegarA={navegarA}
                        renderDashboard={renderDashboard}
                        setPomodoroEnCurso={setPomodoroEnCurso}
                    />
                )}
            />

            <Route
                path="/pomodoro"
                element={renderDashboard(
                    <PomodoroTimer onEstadoPomodoroChange={setPomodoroEnCurso} />
                )}
            />

            <Route
                path="/estadisticas"
                element={renderDashboard(<EstadisticasDashboard />)}
            />

            <Route
                path="/mis-datos"
                element={renderDashboard(<MisDatosDashboard />)}
            />

            <Route path="*" element={<Navigate to="/menu" replace />} />
        </Routes>
    );
}

const estilosCarga = {
    contenedor: {
        flex: 1,
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        color: '#6A7185',
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif",
    },
    texto: {
        fontSize: '1rem',
        fontWeight: 700,
    },
};

const estilosModalPomodoro = {
    overlay: {
        position: 'fixed',
        inset: 0,
        backgroundColor: 'rgba(45, 50, 71, 0.62)',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        zIndex: 3000,
    },
    modal: {
        width: '430px',
        maxWidth: 'calc(100vw - 32px)',
        backgroundColor: 'white',
        borderRadius: '18px',
        padding: '32px',
        boxShadow: '0 18px 45px rgba(0,0,0,0.22)',
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif",
    },
    titulo: {
        margin: '0 0 12px 0',
        color: '#2D3247',
        fontSize: '1.25rem',
        fontWeight: 800,
    },
    texto: {
        margin: '0 0 12px 0',
        color: '#465365',
        lineHeight: 1.5,
        fontSize: '0.95rem',
    },
    advertencia: {
        margin: '0 0 22px 0',
        color: '#D64545',
        backgroundColor: '#FFF1F1',
        border: '1px solid #FFD0D0',
        borderRadius: '10px',
        padding: '12px',
        fontSize: '0.9rem',
        fontWeight: 600,
        lineHeight: 1.4,
    },
    acciones: {
        display: 'flex',
        justifyContent: 'flex-end',
        gap: '10px',
        flexWrap: 'wrap',
    },
    btnCancelar: {
        background: 'none',
        border: 'none',
        color: '#6A7185',
        cursor: 'pointer',
        fontWeight: 700,
        padding: '10px 14px',
    },
    btnSalir: {
        backgroundColor: '#D64545',
        color: 'white',
        border: 'none',
        borderRadius: '9px',
        padding: '10px 18px',
        cursor: 'pointer',
        fontWeight: 800,
    },
};

export default App;
