import React, { useState } from 'react'
import './App.css'

// Vistas
import Login from './pages/Login'
import Registro from './pages/Registro'
import RecuperarPassword from './pages/RecuperarPassword'

// Dashboard y Componentes
import DashboardLayout from './components/DashboardLayout'
import PomodoroTimer from './components/PomodoroTimer'

function App() {
  // El estado 'vistaActual' controla qué pantalla se muestra.
  const [vistaActual, setVistaActual] = useState('login');

  // --- LÓGICA PARA EL AVATAR ---
  // Leemos el nombre que se guardó en el Login. 
  // Si todavía no hay nadie logueado, usamos "Usuario" como respaldo.
  const nombreParaAvatar = localStorage.getItem('nombreUsuario') || "Usuario";

  const navegarA = (nuevaVista) => {
    setVistaActual(nuevaVista);
  };

  // Renderizado condicional
  switch (vistaActual) {
    case 'registro':
      return <Registro onNavegar={navegarA} />;
      
    case 'recuperar':
      return <RecuperarPassword onNavegar={navegarA} />;
      
    case 'dashboard':
      return (
        /* Pasamos el nombre al DashboardLayout */
        <DashboardLayout nombreUsuario={nombreParaAvatar}>
          <PomodoroTimer />
        </DashboardLayout>
      );
      
    case 'login':
    default:
      return (
        <Login onNavegar={navegarA} />
      );
  }
}

export default App;