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

function App() {
  const [vistaActual, setVistaActual] = useState(() => {
    const idUsuario = localStorage.getItem('idUsuario');
      if (!idUsuario) return 'login';
      return localStorage.getItem('vistaActual') || 'dashboard';
  });

  const [pomodoroEnCurso, setPomodoroEnCurso] = useState(false);
  const [avisoSalidaPomodoro, setAvisoSalidaPomodoro] = useState({
    abierto: false,
    tipo: null,
    vista: null,
    datosExtra: null,
  });

  useEffect(() => {
    if (!pomodoroEnCurso) return;

    const advertirRecarga = (event) => {
      event.preventDefault();

      // Los navegadores modernos no permiten personalizar el texto del aviso,
      // pero esta asignación fuerza la alerta nativa de confirmación.
      event.returnValue = 'Tenés un Pomodoro en curso. Si recargás la página, se puede interrumpir la sesión.';
      return event.returnValue;
    };

    window.addEventListener('beforeunload', advertirRecarga);

    return () => {
      window.removeEventListener('beforeunload', advertirRecarga);
    };
  }, [pomodoroEnCurso]);
  
  // Memorias de la aplicación
  const [materiaActiva, setMateriaActiva] = useState(() => {
      const materiaGuardada = localStorage.getItem('materiaActiva');
      return materiaGuardada ? JSON.parse(materiaGuardada) : null;
  });

  const [apunteActivo, setApunteActivo] = useState(() => {
      const apunteGuardado = localStorage.getItem('apunteActivo');
      return apunteGuardado ? JSON.parse(apunteGuardado) : null;
  });

  const nombreParaAvatar = localStorage.getItem('nombreUsuario') || 'Usuario';

  const ejecutarNavegacion = (nuevaVista, datosExtra = null) => {
    localStorage.setItem('vistaActual', nuevaVista);

    if (nuevaVista === 'apuntes' || nuevaVista === 'editor') {
        setMateriaActiva(datosExtra);
        localStorage.setItem('materiaActiva', JSON.stringify(datosExtra));
    }

    if (nuevaVista === 'verApunte') {
        setApunteActivo(datosExtra);
        localStorage.setItem('apunteActivo', JSON.stringify(datosExtra));
    }

    setVistaActual(nuevaVista);
  };

  // Función maestra de navegación
  const navegarA = (nuevaVista, datosExtra = null) => {
    if (
      pomodoroEnCurso &&
      vistaActual === 'dashboard' &&
      nuevaVista !== 'dashboard' &&
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

      setPomodoroEnCurso(false);
      setVistaActual('login');
      setMateriaActiva(null);
      setApunteActivo(null);
  };

  const manejarCerrarSesion = () => {
      if (pomodoroEnCurso && vistaActual === 'dashboard') {
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

  const confirmarSalidaPomodoro = () => {
    const accionPendiente = avisoSalidaPomodoro;

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
            Tenés un Pomodoro iniciado. Si salís de esta sección desde el sidebar, el temporizador se va a interrumpir.
          </p>
          <p style={estilosModalPomodoro.advertencia}>
            Esta acción puede hacer que pierdas el progreso actual del ciclo.
          </p>

          <div style={estilosModalPomodoro.acciones}>
            <button type="button" style={estilosModalPomodoro.btnCancelar} onClick={cancelarSalidaPomodoro}>
              Cancelar
            </button>
            <button type="button" style={estilosModalPomodoro.btnSalir} onClick={confirmarSalidaPomodoro}>
              Salir de todos modos
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
            // 👇 CAMBIAMOS ESTA LÍNEA PARA PASAR EL OBJETO EN MEMORIA 👇
            apunteSeleccionado={apunteActivo}
            onVolver={() => navegarA('apuntes', materiaActiva)} 
          />
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
    width: '420px',
    maxWidth: 'calc(100vw - 32px)',
    backgroundColor: 'white',
    borderRadius: '18px',
    padding: '32px',
    boxShadow: '0 18px 45px rgba(0,0,0,0.22)',
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
    fontSize: '0.88rem',
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