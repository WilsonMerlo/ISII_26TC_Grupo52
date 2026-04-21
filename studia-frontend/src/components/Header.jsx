import React from 'react';

const Header = ({ nombreUsuario = "Usuario" }) => {

    const obtenerIniciales = (nombre) => {
        if (!nombre) return "U";
        const palabras = nombre.trim().split(/\s+/);
        if (palabras.length >= 2) return (palabras[0][0] + palabras[1][0]).toUpperCase();
        return palabras[0][0].toUpperCase();
    };

    const iniciales = obtenerIniciales(nombreUsuario);

    return (
        <header style={estilos.header}>
            {/* Logo */}
            <div style={estilos.logoSeccion}>
                <span style={estilos.logoIcono}>S</span>
                <div>
                    <h1 style={estilos.logoNombre}>StudIA</h1>
                    <p style={estilos.logoSubtitulo}>Deep Work</p>
                </div>
            </div>

            {/* Breadcrumb */}
            <div style={estilos.breadcrumb}>
                <span style={estilos.crumbPadre}>Enfoque</span>
                <span style={estilos.crumbSeparador}>·</span>
                <span style={estilos.crumbActual}>Temporizador Pomodoro</span>
            </div>

            {/* Acciones */}
            <div style={estilos.acciones}>
                <button style={estilos.iconoBtn} title="Notificaciones">
                    <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="18" height="18">
                        <path strokeLinecap="round" strokeLinejoin="round" d="M10 2a6 6 0 00-6 6v2.5L2.5 13h15L16 10.5V8a6 6 0 00-6-6z" />
                        <path strokeLinecap="round" strokeLinejoin="round" d="M8 13v.5a2 2 0 004 0V13" />
                    </svg>
                </button>
                <button style={estilos.iconoBtn} title="Configuración">
                    <svg viewBox="0 0 20 20" fill="none" stroke="currentColor" strokeWidth="1.5" width="18" height="18">
                        <circle cx="10" cy="10" r="2.5" strokeLinecap="round" />
                        <path strokeLinecap="round" strokeLinejoin="round" d="M10 2v1.5M10 16.5V18M2 10h1.5M16.5 10H18M4.1 4.1l1.1 1.1M14.8 14.8l1.1 1.1M4.1 15.9l1.1-1.1M14.8 5.2l1.1-1.1" />
                    </svg>
                </button>

                <div
                    style={estilos.avatarPlaceholder}
                    title={nombreUsuario}
                >
                    {iniciales}
                </div>
            </div>
        </header>
    );
};

const estilos = {
    header: {
        height: '64px',
        backgroundColor: 'white',
        borderBottom: '1px solid #E8EBFF',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'space-between',
        padding: '0 28px',
        position: 'sticky',
        top: 0,
        zIndex: 100,
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif",
    },
    logoSeccion: {
        display: 'flex',
        alignItems: 'center',
        gap: '10px',
    },
    logoIcono: {
        width: '32px',
        height: '32px',
        borderRadius: '6px',
        backgroundColor: '#3A56AF',
        color: 'white',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        fontWeight: '700',
        fontSize: '1.1rem',
        flexShrink: 0,
    },
    logoNombre: {
        fontSize: '1.2rem',
        fontWeight: '700',
        color: '#2D3247',
        margin: 0,
        letterSpacing: '-0.02em',
        lineHeight: 1.2,
    },
    logoSubtitulo: {
        fontSize: '0.7rem',
        color: '#9EA5BA',
        margin: 0,
        letterSpacing: '0.05em',
        lineHeight: 1,
    },
    breadcrumb: {
        color: '#9EA5BA',
        fontSize: '0.88rem',
        display: 'flex',
        alignItems: 'center',
        gap: '8px',
    },
    crumbPadre: { fontWeight: '400' },
    crumbSeparador: { opacity: 0.4 },
    crumbActual: { fontWeight: '600', color: '#2D3247' },

    acciones: {
        display: 'flex',
        alignItems: 'center',
        gap: '4px',
    },
    iconoBtn: {
        background: 'none',
        border: 'none',
        color: '#9EA5BA',
        cursor: 'pointer',
        padding: '8px',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: '6px',
    },
    avatarPlaceholder: {
        width: '36px',
        height: '36px',
        borderRadius: '50%',
        backgroundColor: '#2D3247',
        color: 'white',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        fontWeight: '600',
        fontSize: '0.85rem',
        border: '2px solid #E8EBFF',
        userSelect: 'none',
        cursor: 'pointer',
        marginLeft: '8px',
    },
};

export default Header;
