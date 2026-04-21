import React from 'react';

const Header = () => {
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
                    <div style={estilos.avatarPlaceholder}>AR</div> {/* Placeholder de Alex Rivera */}
                </div>
            </div>
        </header>
    );
};


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
    avatarPlaceholder: { width: '40px', height: '40px', borderRadius: '50%', backgroundColor: '#2D3247', color: 'white', display: 'flex', justifyContent: 'center', alignItems: 'center', fontWeight: '600', fontSize: '1rem', border: '2px solid #E8EBFF' }
};

export default Header;