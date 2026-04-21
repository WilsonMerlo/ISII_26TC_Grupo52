import React from 'react';

const Sidebar = ({ nombreUsuario }) => { 
    
    // --- LÓGICA DE INICIALES ---
    const obtenerIniciales = (nombre) => {
        if (!nombre) return "U";
        const palabras = nombre.trim().split(/\s+/);
        if (palabras.length >= 2) return (palabras[0][0] + palabras[1][0]).toUpperCase();
        return palabras[0][0].toUpperCase();
    };

    const iniciales = obtenerIniciales(nombreUsuario);

    const menuItems = [
        { icono: '🖥️', nombre: 'Escritorio' },
        { icono: '📝', nombre: 'Notas' },
        { icono: '⏱️', nombre: 'Enfoque', activo: true },
        { icono: '📊', nombre: 'Estadísticas' },
    ];

    return (
        <aside style={estilos.sidebar}>
            <nav style={estilos.nav}>
                {menuItems.map((item, index) => (
                    <div 
                        key={index} 
                        style={item.activo ? {...estilos.menuItem, ...estilos.itemActivo} : estilos.menuItem}
                    >
                        <span style={estilos.menuIcono}>{item.icono}</span>
                        <span style={estilos.menuNombre}>{item.nombre}</span>
                    </div>
                ))}
            </nav>

            <div style={estilos.seccionInferior}>
                <button style={estilos.ayudaBtn}>Ayuda</button>
                <button style={estilos.cerrarSesionBtn}>Cerrar Sesión</button>
                
                <div style={estilos.usuarioCard}>
                    {/* Imprimimos las iniciales automáticas */}
                    <div style={estilos.userAvatarMini}>{iniciales}</div>
                    <div style={estilos.userTextos}>
                        {/* Imprimimos la variable del nombre real, NUNCA MÁS un nombre fijo */}
                        <div style={estilos.userNameMini}>{nombreUsuario}</div>
                        <div style={estilos.userModoMini}>Modo Concentración</div>
                    </div>
                </div>
            </div>
        </aside>
    );
};

// --- ESTILOS RÁPIDOS PARA SIDEBAR ---
const estilos = {
    sidebar: { width: '250px', backgroundColor: 'white', borderRight: '1px solid #E8EBFF', display: 'flex', flexDirection: 'column', padding: '30px 20px', justifyContent: 'space-between', minHeight: 'calc(100vh - 70px)' },
    nav: { display: 'flex', flexDirection: 'column', gap: '10px' },
    menuItem: { display: 'flex', alignItems: 'center', gap: '15px', padding: '12px 15px', borderRadius: '10px', color: '#9EA5BA', cursor: 'pointer', transition: 'all 0.2s ease', fontWeight: '500' },
    menuIcono: { fontSize: '1.2rem' },
    itemActivo: { backgroundColor: '#F6F8FE', color: '#3A56AF', fontWeight: '600' },
    seccionInferior: { borderTop: '1px solid #E8EBFF', paddingTop: '20px', display: 'flex', flexDirection: 'column', gap: '15px' },
    ayudaBtn: { background: 'none', border: '1px solid #9EA5BA', color: '#9EA5BA', borderRadius: '8px', padding: '10px', cursor: 'pointer', fontWeight: '600' },
    cerrarSesionBtn: { background: 'none', border: 'none', color: '#9EA5BA', cursor: 'pointer', fontWeight: '600', padding: 0 },
    usuarioCard: { display: 'flex', alignItems: 'center', gap: '10px', backgroundColor: '#F6F8FE', padding: '10px', borderRadius: '10px', marginTop: '10px' },
    userAvatarMini: { width: '30px', height: '30px', borderRadius: '50%', backgroundColor: '#2D3247', color: 'white', display: 'flex', justifyContent: 'center', alignItems: 'center', fontWeight: '600', fontSize: '0.8rem' },
    userNameMini: { fontWeight: '600', color: '#2D3247', fontSize: '0.9rem' },
    userModoMini: { fontSize: '0.75rem', color: '#9EA5BA' }
};

export default Sidebar;