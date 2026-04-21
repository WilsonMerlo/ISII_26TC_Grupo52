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
  // Puede ser: 'login', 'registro', 'recuperar', o 'dashboard'
  const [vistaActual, setVistaActual] = useState('registro');

  // Función para cambiar de pantalla fácilmente
  const navegarA = (nuevaVista) => {
    setVistaActual(nuevaVista);
  };

  // Renderizado condicional estilo Switch
  switch (vistaActual) {
    case 'registro':
      return <Registro onNavegar={navegarA} />;
      
    case 'recuperar':
      return <RecuperarPassword onNavegar={navegarA} />;
      
    case 'dashboard':
      return (
        <DashboardLayout>
          {/* Aquí le pasamos la función para poder cerrar sesión desde el Sidebar si quisieras implementarlo */}
          <PomodoroTimer />
        </DashboardLayout>
      );
      
    case 'login':
    default:
      // A tu vista Login actual, asegúrate de pasarle la prop 'onNavegar' 
      // y actualizar los onClick de los enlaces "Registrarse" y "¿Olvidaste tu contraseña?"
      return (
        <Login onNavegar={navegarA} />
      );
  }
}

export default App;