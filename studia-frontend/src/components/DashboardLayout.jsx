import React from 'react';
import Header from './Header';
import Sidebar from './Sidebar';



// 1. Agregamos 'nombreUsuario' a los parámetros que recibe el componente
const DashboardLayout = ({ children, nombreUsuario }) => {
    return (
        <div style={estilos.mainWrap}>
            <Header nombreUsuario={nombreUsuario} />

            <div style={estilos.seccionInferiorWrap}>
                {/* --- PASAMOS EL NOMBRE AQUÍ TAMBIÉN --- */}
                <Sidebar nombreUsuario={nombreUsuario} />

                <main style={estilos.mainContentArea}>
                    {children}
                </main>
            </div>
        </div>
    );
};

// --- ESTILOS DE ESTRUCTURA (FLEXBOX MASTER) ---
const estilos = {
    mainWrap: { display: 'flex', flexDirection: 'column', minHeight: '100vh', backgroundColor: '#F6F8FE' },
    seccionInferiorWrap: { display: 'flex', flex: 1 }, 
    mainContentArea: { flex: 1, display: 'flex', justifyContent: 'center', alignItems: 'center', overflowY: 'auto' } 
};

export default DashboardLayout;