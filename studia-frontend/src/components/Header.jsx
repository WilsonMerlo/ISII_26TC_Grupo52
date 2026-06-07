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

            {/* Usuario */}
            <div style={estilos.acciones}>
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
    acciones: {
        display: 'flex',
        alignItems: 'center',
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
    },
};

export default Header;
