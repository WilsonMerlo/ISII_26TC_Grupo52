import React, { useState } from 'react'
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

  // Función maestra de navegación
  const navegarA = (nuevaVista, datosExtra = null) => {
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

  const manejarCerrarSesion = () => {
      localStorage.removeItem('idUsuario');
      localStorage.removeItem('nombreUsuario');
      localStorage.removeItem('vistaActual');
      localStorage.removeItem('materiaActiva');
      localStorage.removeItem('apunteActivo');

      setVistaActual('login');
      setMateriaActiva(null);
      setApunteActivo(null);
  };

  switch (vistaActual) {
    case 'registro':
      return <Registro onNavegar={navegarA} />;

    case 'recuperar':
      return <RecuperarPassword onNavegar={navegarA} />;

    case 'materias':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <MateriasDashboard onNavegar={navegarA} />
        </DashboardLayout>
      );

    case 'apuntes':
      return (
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
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <EditorApunte 
             idMateriaActiva={materiaActiva?.id_materia || materiaActiva?.idMateria}
             nombreMateria={materiaActiva?.nombre_materia || materiaActiva?.nombreMateria}
             onVolver={() => navegarA('apuntes', materiaActiva)} 
          />
        </DashboardLayout>
      );

    case 'verApunte':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <VerApunte 
            // 👇 CAMBIAMOS ESTA LÍNEA PARA PASAR EL OBJETO EN MEMORIA 👇
            apunteSeleccionado={apunteActivo}
            onVolver={() => navegarA('apuntes', materiaActiva)} 
          />
        </DashboardLayout>
      );

    case 'dashboard':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA} vistaActual={vistaActual}>
          <PomodoroTimer />
        </DashboardLayout>
      );

    case 'login':
    default:
      return <Login onNavegar={navegarA} />;
  }
}

export default App;