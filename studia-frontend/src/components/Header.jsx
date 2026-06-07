import React, { useEffect, useRef, useState } from 'react';

const obtenerCorreoGuardado = () => {
    return (
        localStorage.getItem('correoUsuario') ||
        localStorage.getItem('emailUsuario') ||
        localStorage.getItem('correo') ||
        localStorage.getItem('email') ||
        'usuario@studia.com'
    );
};

const Header = ({ nombreUsuario = "Usuario", onLogout, onNavegar }) => {
    const [menuAbierto, setMenuAbierto] = useState(false);
    const [correoUsuario, setCorreoUsuario] = useState(obtenerCorreoGuardado);
    const dropdownRef = useRef(null);

    const obtenerIniciales = (nombre) => {
        if (!nombre) return "U";
        const palabras = nombre.trim().split(/\s+/);
        if (palabras.length >= 2) return (palabras[0][0] + palabras[1][0]).toUpperCase();
        return palabras[0][0].toUpperCase();
    };

    useEffect(() => {
        const cerrarSiClickAfuera = (event) => {
            if (dropdownRef.current && !dropdownRef.current.contains(event.target)) {
                setMenuAbierto(false);
            }
        };

        document.addEventListener('mousedown', cerrarSiClickAfuera);
        return () => document.removeEventListener('mousedown', cerrarSiClickAfuera);
    }, []);

    useEffect(() => {
        const actualizarDatos = () => {
            setCorreoUsuario(obtenerCorreoGuardado());
        };

        window.addEventListener('storage', actualizarDatos);
        window.addEventListener('datosUsuarioActualizados', actualizarDatos);

        return () => {
            window.removeEventListener('storage', actualizarDatos);
            window.removeEventListener('datosUsuarioActualizados', actualizarDatos);
        };
    }, []);

    const irAMisDatos = () => {
        setMenuAbierto(false);
        onNavegar?.('misDatos');
    };

    const irAMenu = () => {
        setMenuAbierto(false);
        onNavegar?.('menu');
    };

    const cerrarSesion = () => {
        setMenuAbierto(false);
        onLogout?.();
    };

    const iniciales = obtenerIniciales(nombreUsuario);

    return (
        <header style={estilos.header}>
            <button
                type="button"
                style={estilos.logoSeccion}
                onClick={irAMenu}
                title="Ir al menú"
            >
                <span style={estilos.logoIcono}>S</span>
                <div>
                    <h1 style={estilos.logoNombre}>StudIA</h1>
                    <p style={estilos.logoSubtitulo}>Deep Work</p>
                </div>
            </button>

            <div style={estilos.acciones} ref={dropdownRef}>
                <button
                    type="button"
                    style={estilos.avatarBoton}
                    title={nombreUsuario}
                    onClick={() => setMenuAbierto((abierto) => !abierto)}
                >
                    {iniciales}
                </button>

                {menuAbierto && (
                    <div style={estilos.dropdown}>
                        <div style={estilos.usuarioInfo}>
                            <strong style={estilos.usuarioNombre}>{nombreUsuario}</strong>
                            <span style={estilos.usuarioCorreo}>{correoUsuario}</span>
                        </div>

                        <button type="button" style={estilos.opcion} onClick={irAMisDatos}>
                            <span className="material-symbols-outlined" style={estilos.iconoMaterial}>person</span>
                            <span>Mis Datos</span>
                        </button>

                        <div style={estilos.separador} />

                        <button type="button" style={{ ...estilos.opcion, ...estilos.opcionPeligro }} onClick={cerrarSesion}>
                            <span className="material-symbols-outlined" style={estilos.iconoMaterial}>logout</span>
                            <span>Cerrar sesión</span>
                        </button>
                    </div>
                )}
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
        backgroundColor: 'transparent',
        border: 'none',
        padding: 0,
        cursor: 'pointer',
        fontFamily: 'inherit',
        textAlign: 'left',
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
        position: 'relative',
    },
    avatarBoton: {
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
        fontFamily: 'inherit',
    },
    dropdown: {
        position: 'absolute',
        top: '48px',
        right: 0,
        width: '230px',
        backgroundColor: 'white',
        border: '1px solid #E8EBFF',
        borderRadius: '12px',
        boxShadow: '0 18px 45px rgba(45, 50, 71, 0.16)',
        padding: '14px',
        zIndex: 300,
    },
    usuarioInfo: {
        padding: '6px 8px 14px',
        display: 'flex',
        flexDirection: 'column',
        gap: '4px',
    },
    usuarioNombre: {
        color: '#2D3247',
        fontSize: '0.92rem',
    },
    usuarioCorreo: {
        color: '#8E96AE',
        fontSize: '0.76rem',
        wordBreak: 'break-word',
    },
    opcion: {
        width: '100%',
        border: 'none',
        backgroundColor: 'transparent',
        display: 'flex',
        alignItems: 'center',
        gap: '10px',
        padding: '11px 8px',
        borderRadius: '8px',
        cursor: 'pointer',
        color: '#465365',
        fontWeight: 700,
        fontSize: '0.82rem',
        fontFamily: 'inherit',
        textAlign: 'left',
    },
    opcionPeligro: {
        color: '#C85050',
        textTransform: 'uppercase',
        letterSpacing: '0.02em',
        fontSize: '0.76rem',
    },
    iconoMaterial: {
        width: '22px',
        display: 'inline-flex',
        justifyContent: 'center',
        color: 'inherit',
        fontSize: '1.15rem',
    },
    separador: {
        height: '1px',
        backgroundColor: '#EEF1FA',
        margin: '8px -14px 6px',
    },
};

export default Header;
