import React from 'react';
import Header from './Header';
import Sidebar from './Sidebar';

const DashboardLayout = ({ children, nombreUsuario, onLogout, onNavegar }) => {
    return (
        <div style={estilos.mainWrap}>
            <Header nombreUsuario={nombreUsuario} />
            <div style={estilos.seccionInferiorWrap}>
                <Sidebar nombreUsuario={nombreUsuario} onLogout={onLogout} onNavegar={onNavegar} />
                <main style={estilos.mainContentArea}>
                    {children}
                </main>
            </div>
        </div>
    );
};

const estilos = {
    mainWrap: {
        display: 'flex',
        flexDirection: 'column',
        height: '100vh',
        overflow: 'hidden',
        backgroundColor: '#F6F8FE',
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif",
    },
    seccionInferiorWrap: {
        display: 'flex',
        flex: 1,
        minHeight: 0,        // permite que los hijos flex se encojan
        overflow: 'hidden',
    },
    mainContentArea: {
        flex: 1,
        minHeight: 0,
        display: 'flex',
        flexDirection: 'column', // los hijos se apilan en columna y pueden ocupar el 100%
        overflow: 'hidden',      // el scroll lo maneja cada vista internamente
    },
};

export default DashboardLayout;