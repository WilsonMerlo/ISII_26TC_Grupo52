import React, { useState, useEffect } from 'react';
import { apunteService } from '../services/apunteService';

const ApuntesDashboard = ({ materia, onVolver, onNuevoApunte, onVerApunte }) => {
    const [apuntes, setApuntes] = useState([]);
    const nombreMateria = materia?.nombre_materia || materia?.nombreMateria || "Materia desconocida";

    useEffect(() => {
        if (materia) {
            cargarApuntes();
        }
    }, [materia]);

    const cargarApuntes = async () => {
        try {
            const id = materia.id_materia || materia.idMateria;
            const data = await apunteService.obtenerPorMateria(id);
            setApuntes(data);
        } catch (error) {
            console.error("Error al cargar los apuntes:", error);
        }
    };

    return (
        <div style={estilos.contenedorPrincipal}>
            
            <div style={estilos.cabecera}>
                <div style={estilos.grupoIzquierdo}>
                    <button style={estilos.btnVolver} onClick={onVolver}>
                        ← Volver a Materias
                    </button>
                    <h2 style={estilos.tituloSeccion}>Apuntes de <span style={{color: '#3A56AF'}}>{nombreMateria}</span></h2>
                </div>
                <button style={estilos.btnAgregar} onClick={onNuevoApunte}>
                    + Nuevo Apunte
                </button>
            </div>
            
            <div style={estilos.gridApuntes}>
                {apuntes.length === 0 ? (
                    <div style={estilos.vacio}>
                        <p style={{color: '#6A7185'}}>No hay apuntes todavía.</p>
                        <p style={{fontSize: '0.9rem', color: '#9EA5BA'}}>Hacé clic en "+ Nuevo Apunte" para empezar a estudiar.</p>
                    </div>
                ) : (
                    apuntes.map((apunte, index) => (
                        <div 
                            key={apunte.id_apunte || apunte.idApunte || index} 
                            style={estilos.tarjetaApunte}
                            // 👇 AQUÍ ESTÁ EL CLIC CONECTADO AL ESPÍA 👇
                            onClick={() => {
                                console.log("Clic detectado en apunte:", apunte.titulo);
                                if (onVerApunte) {
                                    onVerApunte(apunte);
                                } else {
                                    console.error("Error: onVerApunte no está conectado desde App.jsx");
                                }
                            }}
                        >
                            <h3 style={estilos.tituloApunte}>{apunte.titulo || "Sin título"}</h3>
                            <div style={estilos.fecha}>
                                📅 {apunte.fecha_creacion ? new Date(apunte.fecha_creacion).toLocaleDateString() : 'Sin fecha'}
                            </div>
                        </div>
                    ))
                )}
            </div>
        </div>
    );
};

const estilos = {
    contenedorPrincipal: { padding: '40px', width: '100%', boxSizing: 'border-box' },
    cabecera: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '30px' },
    grupoIzquierdo: { display: 'flex', flexDirection: 'column', gap: '5px' },
    btnVolver: { background: 'none', border: 'none', color: '#6A7185', cursor: 'pointer', textAlign: 'left', fontSize: '0.9rem', padding: 0 },
    tituloSeccion: { color: '#2D3247', margin: 0, fontSize: '1.8rem' },
    btnAgregar: { backgroundColor: '#3A56AF', color: 'white', border: 'none', padding: '12px 20px', borderRadius: '10px', fontWeight: '600', cursor: 'pointer', transition: 'all 0.2s' },
    gridApuntes: { display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(280px, 1fr))', gap: '20px' },
    tarjetaApunte: { backgroundColor: 'white', borderRadius: '12px', padding: '20px', border: '1px solid #E8EBFF', boxShadow: '0 2px 8px rgba(58, 86, 175, 0.04)', cursor: 'pointer', transition: 'transform 0.2s' },
    tituloApunte: { fontSize: '1.2rem', color: '#2D3247', margin: '0 0 15px 0' },
    fecha: { fontSize: '0.8rem', color: '#9EA5BA', display: 'flex', alignItems: 'center', gap: '5px' },
    vacio: { gridColumn: '1 / -1', textAlign: 'center', padding: '40px', backgroundColor: '#F9FBFF', borderRadius: '15px', border: '1px dashed #C8D5EB' }
};

export default ApuntesDashboard;