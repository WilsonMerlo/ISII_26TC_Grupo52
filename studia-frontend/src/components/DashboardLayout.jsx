import React from 'react';
import Header from './Header';
import Sidebar from './Sidebar';

const DashboardLayout = ({ children, nombreUsuario }) => {
    return (
        <div style={estilos.mainWrap}>
            <Header nombreUsuario={nombreUsuario} />
            <div style={estilos.seccionInferiorWrap}>
                <Sidebar nombreUsuario={nombreUsuario} />
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
        minHeight: '100vh',
        backgroundColor: '#F6F8FE',
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif",
    },
    seccionInferiorWrap: {
        display: 'flex',
        flex: 1,
    },
    mainContentArea: {
        flex: 1,
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'flex-start',
        overflowY: 'auto',
    },
};

export default DashboardLayout;
