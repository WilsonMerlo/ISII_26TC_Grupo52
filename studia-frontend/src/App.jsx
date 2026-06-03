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
  const [vistaActual, setVistaActual] = useState('login');
  
  // Memorias de la aplicación
  const [materiaActiva, setMateriaActiva] = useState(null);
  const [apunteActivo, setApunteActivo] = useState(null);

  const nombreParaAvatar = localStorage.getItem('nombreUsuario') || 'Usuario';

  // Función maestra de navegación
  const navegarA = (nuevaVista, datosExtra = null) => {
    if (nuevaVista === 'apuntes' || nuevaVista === 'editor') {
        setMateriaActiva(datosExtra);
    } else if (nuevaVista === 'verApunte') {
        setApunteActivo(datosExtra);
    }
    setVistaActual(nuevaVista);
  };

  const manejarCerrarSesion = () => {
      localStorage.removeItem('idUsuario');
      localStorage.removeItem('nombreUsuario');
      setVistaActual('login');
  };

  switch (vistaActual) {
    case 'registro':
      return <Registro onNavegar={navegarA} />;

    case 'recuperar':
      return <RecuperarPassword onNavegar={navegarA} />;

    case 'materias':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          <MateriasDashboard onNavegar={navegarA} />
        </DashboardLayout>
      );

    case 'apuntes':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
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
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          <EditorApunte 
             idMateriaActiva={materiaActiva?.id_materia || materiaActiva?.idMateria}
             nombreMateria={materiaActiva?.nombre_materia || materiaActiva?.nombreMateria}
             onVolver={() => navegarA('apuntes', materiaActiva)} 
          />
        </DashboardLayout>
      );

    case 'verApunte':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          <VerApunte 
            // 👇 CAMBIAMOS ESTA LÍNEA PARA PASAR EL OBJETO EN MEMORIA 👇
            apunteSeleccionado={apunteActivo}
            onVolver={() => navegarA('apuntes', materiaActiva)} 
          />
        </DashboardLayout>
      );

    case 'dashboard':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          <PomodoroTimer />
        </DashboardLayout>
      );

    case 'login':
    default:
      return <Login onNavegar={navegarA} />;
  }
}

export default App;