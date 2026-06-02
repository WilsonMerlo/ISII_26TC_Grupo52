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
import ApuntesDashboard from './pages/ApuntesDashboard';

/**
 * Main App Component
 * 
 * Manages global navigation and authentication state.
 * Renders different views based on 'vistaActual' state.
 */
function App() {
  const [vistaActual, setVistaActual] = useState('login');

  const [materiaActiva, setMateriaActiva] = useState(null);

  // ── Get user info from localStorage (set during login) ──
  const nombreParaAvatar = localStorage.getItem('nombreUsuario') || 'Usuario';

  // ── Navigation handler ──
  const navegarA = (nuevaVista, datosExtra = null) => {
    if (datosExtra) {
        setMateriaActiva(datosExtra);
    }
    setVistaActual(nuevaVista);
  };

  const manejarCerrarSesion = () => {
      // Borramos los datos del usuario de la memoria
      localStorage.removeItem('idUsuario');
      localStorage.removeItem('nombreUsuario');
      // Lo mandamos al login
      setVistaActual('login');
    };


  // ── Conditional rendering based on current view ──
  switch (vistaActual) {
    case 'registro':
      return <Registro onNavegar={navegarA} />;

    case 'recuperar':
      return <RecuperarPassword onNavegar={navegarA} />;

    // 
    case 'materias':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          {/* Le pasamos onNavegar al Dashboard de materias para que los clics funcionen */}
          <MateriasDashboard onNavegar={navegarA} />
        </DashboardLayout>
      );

    //
    case 'apuntes':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          <ApuntesDashboard 
             materia={materiaActiva} 
             onVolver={() => navegarA('materias')} 
             onNuevoApunte={() => navegarA('editor', materiaActiva)} 
          />
        </DashboardLayout>
      );
    
    case 'editor':
      return (
        <DashboardLayout nombreUsuario={nombreParaAvatar} onLogout={manejarCerrarSesion} onNavegar={navegarA}>
          <EditorApunte 
             idMateriaActiva={materiaActiva?.id_materia || materiaActiva?.idMateria}
             nombreMateria={materiaActiva?.nombre_materia || materiaActiva?.nombreMateria}
             onVolver={() => navegarA('apuntes')} 
          />
        </DashboardLayout>
      );

    case 'dashboard':
      return (
        <DashboardLayout 
                        nombreUsuario={nombreParaAvatar}
                        onLogout={manejarCerrarSesion}
                        onNavegar={navegarA}
                        >
          <PomodoroTimer />
        </DashboardLayout>
      );

    case 'login':
    default:
      return <Login onNavegar={navegarA} />;
  }
}

export default App;
