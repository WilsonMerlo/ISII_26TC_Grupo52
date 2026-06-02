import React, { useState, useEffect } from 'react';
import { materiaService } from '../services/materiaService';
import LongPressDelete from '../components/LongPressDelete';

const MateriasDashboard = ({ onNavegar }) => {
    const [materias, setMaterias] = useState([]);
    const [mostrarModal, setMostrarModal] = useState(false);
    const [nuevaMateria, setNuevaMateria] = useState({ nombre_materia: '', descripcion: '' });

    useEffect(() => {
        cargarMaterias();
    }, []);

    const cargarMaterias = async () => {
        try {
            const data = await materiaService.obtenerTodas();
            setMaterias(data);
        } catch (error) {
            console.error("Error cargando materias:", error);
        }
    };

    const manejarCrearMateria = async (e) => {
        e.preventDefault();
        try {
            // Enviamos el objeto con los nombres exactos de la BD de Wilson
            // IMPORTANTE: id_usuario suele ser el del usuario logueado (ej: 1)
            const materiaAGuardar = {
                ...nuevaMateria,
                id_usuario: localStorage.getItem('idUsuario') || 1 
            };
            
            await materiaService.crear(materiaAGuardar);
            setMostrarModal(false); // Cerramos el formulario
            setNuevaMateria({ nombre_materia: '', descripcion: '' }); // Limpiamos
            cargarMaterias(); // Recargamos la lista automáticamente
        } catch (error) {
            alert("Error al crear la materia. Revisa la conexión con el servidor.");
        }
    };

    const manejarBorrado = async (id) => {
        try {
            await materiaService.eliminar(id);
            setMaterias(materias.filter(m => (m.id_materia || m.idMateria) !== id));
        } catch (error) {
            alert("Hubo un problema al borrar la materia.");
        }
    };

    return (
        <div style={estilos.contenedorPrincipal}>
            
            {/* ¡ACÁ VOLVIÓ TU BOTÓN! Cabecera: Título + Botón Agregar */}
            <div style={estilos.cabecera}>
                <h2 style={estilos.tituloSeccion}>Mis Materias</h2>
                <button 
                    style={estilos.btnAgregar} 
                    onClick={() => setMostrarModal(true)}
                >
                    <span style={estilos.iconoPlus}>+</span> Agregar Materia
                </button>
            </div>
            
            {/* Grilla de Tarjetas Clickeables */}
            <div style={estilos.gridMaterias}>
                {materias.map((materia, index) => (
                    <div 
                        key={materia.id_materia || materia.idMateria || index} 
                        style={{...estilos.tarjeta, cursor: 'pointer'}}
                        onClick={() => onNavegar && onNavegar('apuntes', materia)}
                    >
                        <h3 style={estilos.tituloMateria}>
                            {materia.nombre_materia || materia.nombreMateria}
                        </h3>
                        <p style={estilos.descMateria}>{materia.descripcion}</p>
                        
                        {/* El basurero protegido para no navegar por error */}
                        <div style={estilos.footerTarjeta} onClick={(e) => e.stopPropagation()}>
                            <LongPressDelete onConfirmDelete={() => manejarBorrado(materia.id_materia || materia.idMateria)} />
                        </div>
                    </div>
                ))}
            </div>

            {/* Modal / Formulario Flotante */}
            {mostrarModal && (
                <div style={estilos.overlayModal}>
                    <div style={estilos.modal}>
                        <h3 style={{marginBottom: '20px', color: '#2D3247'}}>Nueva Materia</h3>
                        <form onSubmit={manejarCrearMateria} style={estilos.formulario}>
                            <input 
                                type="text" 
                                placeholder="Nombre de la materia (ej: Cálculo)" 
                                required
                                value={nuevaMateria.nombre_materia}
                                onChange={(e) => setNuevaMateria({...nuevaMateria, nombre_materia: e.target.value})}
                                style={estilos.input}
                            />
                            <textarea 
                                placeholder="Breve descripción..." 
                                value={nuevaMateria.descripcion}
                                onChange={(e) => setNuevaMateria({...nuevaMateria, descripcion: e.target.value})}
                                style={estilos.textarea}
                            />
                            <div style={estilos.botonesForm}>
                                <button type="button" onClick={() => setMostrarModal(false)} style={estilos.btnCancelar}>Cancelar</button>
                                <button type="submit" style={estilos.btnGuardar}>Guardar Materia</button>
                            </div>
                        </form>
                    </div>
                </div>
            )}
        </div>
    );
};

const estilos = {
    contenedorPrincipal: { padding: '40px', width: '100%', boxSizing: 'border-box', position: 'relative' },
    cabecera: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '30px' },
    tituloSeccion: { color: '#2D3247', margin: 0, fontSize: '1.8rem' },
    
    // Botón Agregar
    btnAgregar: { backgroundColor: '#3A56AF', color: 'white', border: 'none', padding: '12px 20px', borderRadius: '10px', fontWeight: '600', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px', transition: 'all 0.2s' },
    iconoPlus: { fontSize: '1.4rem', lineHeight: '1' },

    gridMaterias: { display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(320px, 1fr))', gap: '25px' },
    tarjeta: { backgroundColor: 'white', borderRadius: '15px', padding: '25px', border: '1px solid #E8EBFF', boxShadow: '0 4px 12px rgba(58, 86, 175, 0.05)', display: 'flex', flexDirection: 'column', minHeight: '180px' },
    tituloMateria: { fontSize: '1.4rem', color: '#3A56AF', margin: '0 0 10px 0' },
    descMateria: { fontSize: '0.9rem', color: '#6A7185', margin: '0 0 20px 0', lineHeight: '1.4' },
    footerTarjeta: { marginTop: 'auto', display: 'flex', justifyContent: 'flex-end' },

    // Estilos del Modal
    overlayModal: { position: 'fixed', top: 0, left: 0, width: '100vw', height: '100vh', backgroundColor: 'rgba(45, 50, 71, 0.6)', display: 'flex', justifyContent: 'center', alignItems: 'center', zIndex: 1000 },
    modal: { backgroundColor: 'white', padding: '40px', borderRadius: '20px', width: '400px', boxShadow: '0 10px 30px rgba(0,0,0,0.2)' },
    formulario: { display: 'flex', flexDirection: 'column', gap: '15px' },
    input: { padding: '12px', borderRadius: '8px', border: '1px solid #E8EBFF', outline: 'none', fontSize: '1rem' },
    textarea: { padding: '12px', borderRadius: '8px', border: '1px solid #E8EBFF', outline: 'none', fontSize: '1rem', minHeight: '80px', fontFamily: 'inherit' },
    botonesForm: { display: 'flex', justifyContent: 'flex-end', gap: '10px', marginTop: '10px' },
    btnCancelar: { background: 'none', border: 'none', color: '#6A7185', cursor: 'pointer', fontWeight: '600' },
    btnGuardar: { backgroundColor: '#3A56AF', color: 'white', border: 'none', padding: '10px 20px', borderRadius: '8px', cursor: 'pointer', fontWeight: '600' }
};

export default MateriasDashboard;