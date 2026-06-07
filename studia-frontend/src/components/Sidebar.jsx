import React from 'react';

// --- Íconos SVG ---

const IconMenu = () => (
    <svg
        width="20"
        height="20"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round"
    >
        <rect x="3" y="3" width="7" height="7" rx="1"></rect>
        <rect x="14" y="3" width="7" height="7" rx="1"></rect>
        <rect x="3" y="14" width="7" height="7" rx="1"></rect>
        <rect x="14" y="14" width="7" height="7" rx="1"></rect>
    </svg>
);

const IconMaterias = () => (
    <svg
        width="20"
        height="20"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round"
    >
        <path d="M4 19.5A2.5 2.5 0 0 1 6.5 17H20"></path>
        <path d="M4 4.5A2.5 2.5 0 0 1 6.5 2H20v20H6.5A2.5 2.5 0 0 1 4 19.5z"></path>
    </svg>
);

const IconEnfoque = () => (
    <svg
        width="20"
        height="20"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round"
    >
        <circle cx="12" cy="13" r="8"></circle>
        <polyline points="12 9 12 13 14 15"></polyline>
        <line x1="12" y1="2" x2="12" y2="4"></line>
        <line x1="10" y1="2" x2="14" y2="2"></line>
    </svg>
);

const IconEstadisticas = () => (
    <svg
        width="20"
        height="20"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round"
    >
        <line x1="18" y1="20" x2="18" y2="10"></line>
        <line x1="12" y1="20" x2="12" y2="4"></line>
        <line x1="6" y1="20" x2="6" y2="14"></line>
    </svg>
);

const Sidebar = ({ nombreUsuario = "Usuario", onLogout, onNavegar, vistaActual }) => {
    const obtenerIniciales = (nombre) => {
        if (!nombre) return "U";

        const palabras = nombre.trim().split(/\s+/);

        if (palabras.length >= 2) {
            return (palabras[0][0] + palabras[1][0]).toUpperCase();
        }

        return palabras[0][0].toUpperCase();
    };

    const iniciales = obtenerIniciales(nombreUsuario);

    const menuItems = [
        { icono: <IconMenu />, nombre: 'Menú', vista: 'menu' },
        { icono: <IconMaterias />, nombre: 'Materias', vista: 'materias' },
        { icono: <IconEnfoque />, nombre: 'Enfoque', vista: 'dashboard' },
        { icono: <IconEstadisticas />, nombre: 'Estadísticas', vista: 'estadisticas' },
    ];

    const esItemActivo = (item) => {
        if (
            item.vista === 'materias' &&
            ['materias', 'apuntes', 'verApunte', 'editor'].includes(vistaActual)
        ) {
            return true;
        }

        return item.vista === vistaActual;
    };

    return (
        <aside style={estilos.sidebar}>
            <nav style={estilos.nav}>
                {menuItems.map((item, index) => {
                    const activo = esItemActivo(item);

                    return (
                        <div
                            key={index}
                            style={
                                activo
                                    ? { ...estilos.menuItem, ...estilos.itemActivo }
                                    : estilos.menuItem
                            }
                            onClick={() => {
                                if (item.vista && onNavegar) {
                                    onNavegar(item.vista);
                                }
                            }}
                        >
                            <span style={activo ? estilos.menuIconoActivo : estilos.menuIcono}>
                                {item.icono}
                            </span>
                            <span>{item.nombre}</span>
                        </div>
                    );
                })}
            </nav>

            <div style={estilos.seccionInferior}>
                <button style={estilos.cerrarSesionBtn} onClick={onLogout}>
                    Cerrar Sesión
                </button>

                <div style={estilos.usuarioCard}>
                    <div style={estilos.userAvatarMini}>{iniciales}</div>
                    <div style={estilos.userTextos}>
                        <div style={estilos.userNameMini}>{nombreUsuario}</div>
                        <div style={estilos.userModoMini}>Modo Concentración</div>
                    </div>
                </div>
            </div>
        </aside>
    );
};

const estilos = {
    sidebar: {
        width: '240px',
        backgroundColor: 'white',
        borderRight: '1px solid #E8EBFF',
        display: 'flex',
        flexDirection: 'column',
        padding: '24px 16px',
        justifyContent: 'space-between',
        minHeight: 'calc(100vh - 64px)',
        fontFamily: "'IBM Plex Sans', 'Helvetica Neue', sans-serif",
        flexShrink: 0,
    },
    nav: {
        display: 'flex',
        flexDirection: 'column',
        gap: '4px',
    },
    menuItem: {
        display: 'flex',
        alignItems: 'center',
        gap: '12px',
        padding: '10px 12px',
        borderRadius: '6px',
        color: '#9EA5BA',
        cursor: 'pointer',
        fontSize: '0.9rem',
        fontWeight: '500',
        transition: 'background-color 0.15s, color 0.15s',
    },
    itemActivo: {
        backgroundColor: '#F0F3FF',
        color: '#3A56AF',
        fontWeight: '600',
    },
    menuIcono: {
        display: 'flex',
        alignItems: 'center',
        color: '#B0B7CF',
        flexShrink: 0,
    },
    menuIconoActivo: {
        display: 'flex',
        alignItems: 'center',
        color: '#3A56AF',
        flexShrink: 0,
    },
    seccionInferior: {
        borderTop: '1px solid #E8EBFF',
        paddingTop: '20px',
        display: 'flex',
        flexDirection: 'column',
        gap: '12px',
    },
    cerrarSesionBtn: {
        background: 'none',
        border: '1px solid #E0E4F4',
        color: '#9EA5BA',
        borderRadius: '6px',
        padding: '9px',
        cursor: 'pointer',
        fontWeight: '500',
        fontSize: '0.88rem',
        fontFamily: 'inherit',
    },
    usuarioCard: {
        display: 'flex',
        alignItems: 'center',
        gap: '10px',
        backgroundColor: '#F6F8FE',
        padding: '10px 12px',
        borderRadius: '6px',
        marginTop: '4px',
    },
    userAvatarMini: {
        width: '30px',
        height: '30px',
        borderRadius: '50%',
        backgroundColor: '#2D3247',
        color: 'white',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        fontWeight: '600',
        fontSize: '0.75rem',
        flexShrink: 0,
    },
    userTextos: {
        overflow: 'hidden',
    },
    userNameMini: {
        fontWeight: '600',
        color: '#2D3247',
        fontSize: '0.85rem',
        whiteSpace: 'nowrap',
        overflow: 'hidden',
        textOverflow: 'ellipsis',
    },
    userModoMini: {
        fontSize: '0.72rem',
        color: '#9EA5BA',
    },
};

export default Sidebar;
