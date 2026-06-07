import React, { useEffect, useState } from 'react'
import './App.css'

// ── VIEWS ──
import Login from './pages/Login'
import Registro from './pages/Registro'
import RecuperarPassword from './pages/RecuperarPassword'

// ── DASHBOARD & COMPONENTS ──
import DashboardLayout from './components/DashboardLayout'
import PomodoroTimer from './components/PomodoroTimer'
import MateriasDashboard from './pages/MateriasDashboard'
import EditorApunte from './components/EditorApunte'
import ApuntesDashboard from './pages/ApuntesDashboard'
import VerApunte from './pages/VerApunte'
import EstadisticasDashboard from './pages/EstadisticasDashboard'
import { eliminarPomodoro } from './services/pomodoroService'

function App() {
  const [vistaActual, setVistaActual] = useState(() => {
      const idUsuario = localStorage.getItem('idUsuario');

      if (!idUsuario) return 'login';

      return localStorage.getItem('vistaActual') || 'dashboard';
  });

  // Memorias de la aplicación
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

  // Estado global para advertir si hay un Pomodoro en curso
  const [pomodoroEnCurso, setPomodoroEnCurso] = useState(false);
  const [avisoSalidaPomodoro, setAvisoSalidaPomodoro] = useState({
      abierto: false,
      tipo: null,
      vista: null,
      datosExtra: null,
  });

  const nombreParaAvatar = localStorage.getItem('nombreUsuario') || 'Usuario';
  const BASE_URL = import.meta.env.VITE_API_URL || 'https://localhost:7068';
  const POMODORO_APUNTE_STORAGE_KEY = 'pomodoroApunteActivoId';

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

          // Los navegadores modernos no permiten personalizar completamente
          // el texto del aviso, pero returnValue activa la alerta nativa.
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
  }, [pomodoroEnCurso, BASE_URL]);

  const ejecutarNavegacion = (nuevaVista, datosExtra = null) => {
    localStorage.setItem('vistaActual', nuevaVista);

    if (nuevaVista === 'apuntes' || nuevaVista === 'editor') {
        if (datosExtra) {
            setMateriaActiva(datosExtra);
            localStorage.setItem('materiaActiva', JSON.stringify(datosExtra));
        }
    } else if (nuevaVista === 'verApunte') {
        if (datosExtra) {
            setApunteActivo(datosExtra);
            localStorage.setItem('apunteActivo', JSON.stringify(datosExtra));
        }
    }

    setVistaActual(nuevaVista);
  };

  // Función maestra de navegación
  const navegarA = (nuevaVista, datosExtra = null) => {
    if (
        pomodoroEnCurso &&
        nuevaVista !== vistaActual
    ) {
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
      localStorage.removeItem('vistaActual');
      localStorage.removeItem('materiaActiva');
      localStorage.removeItem('apunteActivo');
      localStorage.removeItem(POMODORO_APUNTE_STORAGE_KEY);
      setPomodoroEnCurso(false);
      setVistaActual('login');
      setMateriaActiva(null);
      setApunteActivo(null);
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

  switch (vistaActual) {
    case 'registro':
      return <Registro onNavegar={navegarA} />;

    case 'recuperar':
      return <RecuperarPassword onNavegar={navegarA} />;

    case 'materias':
      return envolverConAvisoPomodoro(
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <MateriasDashboard onNavegar={navegarA} />
        </DashboardLayout>
      );

    case 'apuntes':
      return envolverConAvisoPomodoro(
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <ApuntesDashboard 
             materia={materiaActiva} 
             onVolver={() => navegarA('materias')} 
             onNuevoApunte={() => navegarA('editor', materiaActiva)} 
             onVerApunte={(apunte) => navegarA('verApunte', apunte)} 
          />
        </DashboardLayout>
      );

    case 'editor':
      return envolverConAvisoPomodoro(
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <EditorApunte 
             idMateriaActiva={materiaActiva?.id_materia || materiaActiva?.idMateria}
             nombreMateria={materiaActiva?.nombre_materia || materiaActiva?.nombreMateria}
             onVolver={() => navegarA('apuntes', materiaActiva)} 
          />
        </DashboardLayout>
      );

    case 'verApunte':
      return envolverConAvisoPomodoro(
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <VerApunte 
            apunteSeleccionado={apunteActivo}
            materiaActiva={materiaActiva}
            onVolver={() => navegarA('apuntes', materiaActiva)}
            onEstadoPomodoroChange={setPomodoroEnCurso}
          />
        </DashboardLayout>
      );

    case 'estadisticas':
      return envolverConAvisoPomodoro(
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <EstadisticasDashboard />
        </DashboardLayout>
      );

    case 'dashboard':
      return envolverConAvisoPomodoro(
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <PomodoroTimer onEstadoPomodoroChange={setPomodoroEnCurso} />
        </DashboardLayout>
      );

    case 'login':
    default:
      return <Login onNavegar={navegarA} />;
  }
}

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
