import React from 'react';
import Header from './Header';
import Sidebar from './Sidebar';

const DashboardLayout = ({ children }) => {
    return (
        <div style={estilos.mainWrap}>
            {/* 1. Header arriba del todo */}
            <Header />

            <div style={estilos.seccionInferiorWrap}>
                {/* 2. Sidebar a la izquierda */}
                <Sidebar />

                {/* 3. Contenido Principal a la derecha - Zona de Deep Work */}
                <main style={estilos.mainContentArea}>
                    {children} {/* Aquí es donde meteremos el PomodoroTimer */}
                </main>
            </div>
        </div>
    );
};

// --- ESTILOS DE ESTRUCTURA (FLEXBOX MASTER) ---
const estilos = {
    mainWrap: { display: 'flex', flexDirection: 'column', minHeight: '100vh', backgroundColor: '#F6F8FE' },
    seccionInferiorWrap: { display: 'flex', flex: 1 }, // El resto del espacio lo dividimos en row (Sidebar | Main)
    mainContentArea: { flex: 1, display: 'flex', justifyContent: 'center', alignItems: 'center', overflowY: 'auto' } // Ocupa todo el resto, centra el contenido central (Pomodoro)
};

export default DashboardLayout;