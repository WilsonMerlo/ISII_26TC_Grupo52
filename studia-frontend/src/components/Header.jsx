import React from 'react';

// Recibimos el nombre del usuario como prop (por defecto le ponemos "Usuario")
const Header = ({ nombreUsuario = "Usuario" }) => {

    // --- LÓGICA DE INICIALES (SENIOR TIP) ---
    const obtenerIniciales = (nombre) => {
        if (!nombre) return "U"; // Si no hay nombre, devolvemos una "U" por defecto
        
        // Separamos el nombre por espacios eliminando espacios extra
        const palabras = nombre.trim().split(/\s+/); 
        
        // Si tiene 2 o más palabras, agarramos la 1ra letra de la 1ra y 2da palabra
        if (palabras.length >= 2) {
            return (palabras[0][0] + palabras[1][0]).toUpperCase();
        }
        
        // Si solo puso "Alex" (1 palabra), devolvemos solo la "A"
        return palabras[0][0].toUpperCase();
    };

    const iniciales = obtenerIniciales(nombreUsuario);

    return (
        <header style={estilos.header}>
            <div style={estilos.logoSeccion}>
                <span style={estilos.logoIcono}>S</span>
                <h1 style={estilos.logoNombre}>Sanctuary</h1>
                <p style={estilos.logoSubtitulo}>Deep Work</p>
            </div>

            {/* Breadcrumb / Sección Actual */}
            <div style={estilos.breadcrumb}>
                <span style={estilos.crumbPadre}>Enfoque</span>
                <span style={estilos.crumbSeparador}>•</span>
                <span style={estilos.crumbActual}>Temporizador Pomodoro</span>
            </div>

            {/* Íconos derecha y Avatar */}
            <div style={estilos.acciones}>
                <button style={estilos.iconoBtn}>🔔</button>
                <button style={estilos.iconoBtn}>⚙️</button>
                <div style={estilos.avatarContainer}>
                    {/* Imprimimos la variable calculada en lugar del "AR" fijo */}
                    <div style={estilos.avatarPlaceholder} title={nombreUsuario}>
                        {iniciales}
                    </div>
                </div>
            </div>
        </header>
    );
};

// --- ESTILOS ENCAPSULADOS ---
const estilos = {
    header: { height: '70px', backgroundColor: 'white', borderBottom: '1px solid #E8EBFF', display: 'flex', alignItems: 'center', justifyContent: 'space-between', padding: '0 30px', position: 'sticky', top: 0, zIndex: 100 },
    logoSeccion: { display: 'flex', alignItems: 'center', gap: '8px' },
    logoIcono: { width: '32px', height: '32px', borderRadius: '8px', backgroundColor: '#3A56AF', color: 'white', display: 'flex', justifyContent: 'center', alignItems: 'center', fontWeight: 'bold', fontSize: '1.2rem' },
    logoNombre: { fontSize: '1.3rem', fontWeight: '700', color: '#2D3247', margin: 0 },
    logoSubtitulo: { fontSize: '0.8rem', color: '#9EA5BA', margin: 0, marginTop: '-3px' },
    
    breadcrumb: { color: '#9EA5BA', fontSize: '0.9rem', display: 'flex', alignItems: 'center', gap: '8px' },
    crumbSeparador: { opacity: 0.5 },
    crumbActual: { fontWeight: '600', color: '#2D3247' },
    
    acciones: { display: 'flex', alignItems: 'center', gap: '15px' },
    iconoBtn: { background: 'none', border: 'none', fontSize: '1.3rem', color: '#9EA5BA', cursor: 'pointer', padding: 0 },
    avatarContainer: { display: 'flex', alignItems: 'center', gap: '10px' },
    // Le agregué userSelect: 'none' para que no se sombree como texto al hacer clic
    avatarPlaceholder: { width: '40px', height: '40px', borderRadius: '50%', backgroundColor: '#2D3247', color: 'white', display: 'flex', justifyContent: 'center', alignItems: 'center', fontWeight: '600', fontSize: '1rem', border: '2px solid #E8EBFF', userSelect: 'none', cursor: 'pointer' }
};

export default Header;