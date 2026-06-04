import React, { useState, useEffect } from 'react';
import { materiaService } from '../services/materiaService';


const MateriasDashboard = ({ onNavegar }) => {
    const [materias, setMaterias] = useState([]);
    const [mostrarModal, setMostrarModal] = useState(false);
    const [nuevaMateria, setNuevaMateria] = useState({
        nombreMateria: '',
        descripcion: ''
    });
    const [materiaAEliminar, setMateriaAEliminar] = useState(null);
    const [materiaEditando, setMateriaEditando] = useState(null);

    const [formEditar, setFormEditar] = useState({
        nombreMateria: '',
        descripcion: ''
    });

    useEffect(() => {
        cargarMaterias();
    }, []);

    const obtenerIdMateria = (materia) => {
        return materia.id_materia || materia.idMateria || materia.IdMateria || materia.id;
    };

    const obtenerNombreMateria = (materia) => {
        return materia.nombre_materia || materia.nombreMateria || materia.NombreMateria || '';
    };

    const obtenerDescripcionMateria = (materia) => {
        return materia.descripcion || materia.Descripcion || '';
    };

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

        if (!nuevaMateria.nombreMateria.trim()) {
            alert("El nombre de la materia es obligatorio.");
            return;
        }

        try {
            const idUsuario = Number(localStorage.getItem('idUsuario'));

            if (!idUsuario) {
                alert("No se encontró el usuario logueado. Iniciá sesión nuevamente.");
                return;
            }

            const materiaAGuardar = {
                idUsuario,
                nombreMateria: nuevaMateria.nombreMateria.trim(),
                descripcion: nuevaMateria.descripcion.trim()
            };

            await materiaService.crear(materiaAGuardar);

            setMostrarModal(false);
            setNuevaMateria({
                nombreMateria: '',
                descripcion: ''
            });

            await cargarMaterias();
        } catch (error) {
            console.error("Error al crear materia:", error);
            alert("Error al crear la materia. Revisa la conexión con el servidor.");
        }
    };

    const abrirModalEliminar = (materia) => {
        setMateriaAEliminar(materia);
    };

    const cerrarModalEliminar = () => {
        setMateriaAEliminar(null);
    };

    const confirmarEliminarMateria = async () => {
        if (!materiaAEliminar) return;

        const id = obtenerIdMateria(materiaAEliminar);

        try {
            await materiaService.eliminar(id);

            setMaterias((prevMaterias) =>
                prevMaterias.filter((m) => obtenerIdMateria(m) !== id)
            );

            setMateriaAEliminar(null);
        } catch (error) {
            console.error("Error al borrar materia:", error);
            alert("Hubo un problema al borrar la materia.");
        }
    };

    const abrirModalEditar = (materia) => {
        setMateriaEditando(materia);

        setFormEditar({
            nombreMateria: obtenerNombreMateria(materia),
            descripcion: obtenerDescripcionMateria(materia)
        });
    };

    const cerrarModalEditar = () => {
        setMateriaEditando(null);

        setFormEditar({
            nombreMateria: '',
            descripcion: ''
        });
    };

    const guardarEdicionMateria = async (e) => {
        e.preventDefault();

        if (!materiaEditando) return;

        if (!formEditar.nombreMateria.trim()) {
            alert("El nombre de la materia es obligatorio.");
            return;
        }

        const id = obtenerIdMateria(materiaEditando);

        const idUsuario =
            materiaEditando.id_usuario ||
            materiaEditando.idUsuario ||
            materiaEditando.IdUsuario ||
            Number(localStorage.getItem('idUsuario'));

        const materiaActualizada = {
            ...materiaEditando,
            idMateria: id,
            idUsuario,
            nombreMateria: formEditar.nombreMateria.trim(),
            descripcion: formEditar.descripcion.trim()
        };

        try {
            await materiaService.actualizar(id, materiaActualizada);
            cerrarModalEditar();
            await cargarMaterias();
        } catch (error) {
            console.error("Error al editar materia:", error);
            alert("Error al editar la materia. Revisa la conexión con el servidor.");
        }
    };

    return (
        <div style={estilos.contenedorPrincipal}>

            {/* Cabecera: Título + Botón Agregar */}
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
                        key={obtenerIdMateria(materia) || index}
                        style={{ ...estilos.tarjeta, cursor: 'pointer' }}
                        onClick={() => onNavegar && onNavegar('apuntes', materia)}
                    >
                        <h3 style={estilos.tituloMateria}>
                            {obtenerNombreMateria(materia)}
                        </h3>

                        <p style={estilos.descMateria}>
                            {obtenerDescripcionMateria(materia)}
                        </p>

                        {/* El basurero protegido para no navegar por error */}
                        <div style={estilos.footerTarjeta} onClick={(e) => e.stopPropagation()}>
                            <button
                                type="button"
                                style={estilos.btnEditar}
                                onClick={() => abrirModalEditar(materia)}
                            >
                                Editar
                            </button>

                            <button
                                type="button"
                                style={estilos.btnEliminar}
                                onClick={() => abrirModalEliminar(materia)}
                            >
                                Borrar
                            </button>
                        </div>
                    </div>
                ))}
            </div>

            {/* Modal crear materia */}
                {mostrarModal && (
                    <div style={estilos.overlayModal}>
                        <div style={estilos.modal}>
                            <h3 style={{ marginBottom: '20px', color: '#2D3247' }}>
                                Nueva Materia
                            </h3>

                            <form onSubmit={manejarCrearMateria} style={estilos.formulario}>
                                <input
                                    type="text"
                                    placeholder="Nombre de la materia (ej: Cálculo)"
                                    required
                                    value={nuevaMateria.nombreMateria}
                                    onChange={(e) =>
                                        setNuevaMateria({
                                            ...nuevaMateria,
                                            nombreMateria: e.target.value
                                        })
                                    }
                                    style={estilos.input}
                                />

                                <textarea
                                    placeholder="Breve descripción..."
                                    value={nuevaMateria.descripcion}
                                    onChange={(e) =>
                                        setNuevaMateria({
                                            ...nuevaMateria,
                                            descripcion: e.target.value
                                        })
                                    }
                                    style={estilos.textarea}
                                />

                                <div style={estilos.botonesForm}>
                                    <button
                                        type="button"
                                        onClick={() => setMostrarModal(false)}
                                        style={estilos.btnCancelar}
                                    >
                                        Cancelar
                                    </button>

                                    <button type="submit" style={estilos.btnGuardar}>
                                        Guardar Materia
                                    </button>
                                </div>
                            </form>
                        </div>
                    </div>
                )}

                {/* Modal confirmar borrado */}
                {materiaAEliminar && (
                    <div style={estilos.overlayModal}>
                        <div style={estilos.modalConfirmacion}>
                            <h3 style={estilos.tituloModal}>Eliminar materia</h3>

                            <p style={estilos.textoConfirmacion}>
                                ¿Estás seguro de que querés eliminar la materia{' '}
                                <strong>{obtenerNombreMateria(materiaAEliminar)}</strong>?
                            </p>

                            <div style={estilos.botonesForm}>
                                <button
                                    type="button"
                                    onClick={cerrarModalEliminar}
                                    style={estilos.btnCancelar}
                                >
                                    Cancelar
                                </button>

                                <button
                                    type="button"
                                    onClick={confirmarEliminarMateria}
                                    style={estilos.btnConfirmarEliminar}
                                >
                                    Sí, eliminar
                                </button>
                            </div>
                        </div>
                    </div>
                )}

                {/* Modal editar materia */}
                {materiaEditando && (
                    <div style={estilos.overlayModal}>
                        <div style={estilos.modal}>
                            <h3 style={estilos.tituloModal}>Editar Materia</h3>

                            <form onSubmit={guardarEdicionMateria} style={estilos.formulario}>
                                <input
                                    type="text"
                                    placeholder="Nombre de la materia"
                                    required
                                    value={formEditar.nombreMateria}
                                    onChange={(e) =>
                                        setFormEditar({
                                            ...formEditar,
                                            nombreMateria: e.target.value
                                        })
                                    }
                                    style={estilos.input}
                                />

                                <textarea
                                    placeholder="Descripción"
                                    value={formEditar.descripcion}
                                    onChange={(e) =>
                                        setFormEditar({
                                            ...formEditar,
                                            descripcion: e.target.value
                                        })
                                    }
                                    style={estilos.textarea}
                                />

                                <div style={estilos.botonesForm}>
                                    <button
                                        type="button"
                                        onClick={cerrarModalEditar}
                                        style={estilos.btnCancelar}
                                    >
                                        Cancelar
                                    </button>

                                    <button type="submit" style={estilos.btnGuardar}>
                                        Guardar Cambios
                                    </button>
                                </div>
                            </form>
                        </div>
                    </div>
                )}
        </div>
    );
};

const estilos = {
    contenedorPrincipal: {
        padding: '40px',
        width: '100%',
        boxSizing: 'border-box',
        position: 'relative'
    },
    cabecera: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        marginBottom: '30px'
    },
    tituloSeccion: {
        color: '#2D3247',
        margin: 0,
        fontSize: '1.8rem'
    },

    btnAgregar: {
        backgroundColor: '#3A56AF',
        color: 'white',
        border: 'none',
        padding: '12px 20px',
        borderRadius: '10px',
        fontWeight: '600',
        cursor: 'pointer',
        display: 'flex',
        alignItems: 'center',
        gap: '8px',
        transition: 'all 0.2s'
    },
    iconoPlus: {
        fontSize: '1.4rem',
        lineHeight: '1'
    },

    gridMaterias: {
        display: 'grid',
        gridTemplateColumns: 'repeat(auto-fill, minmax(320px, 1fr))',
        gap: '25px'
    },
    tarjeta: {
        backgroundColor: 'white',
        borderRadius: '15px',
        padding: '25px',
        border: '1px solid #E8EBFF',
        boxShadow: '0 4px 12px rgba(58, 86, 175, 0.05)',
        display: 'flex',
        flexDirection: 'column',
        minHeight: '180px'
    },
    tituloMateria: {
        fontSize: '1.4rem',
        color: '#3A56AF',
        margin: '0 0 10px 0'
    },
    descMateria: {
        fontSize: '0.9rem',
        color: '#6A7185',
        margin: '0 0 20px 0',
        lineHeight: '1.4'
    },
    footerTarjeta: {
        marginTop: 'auto',
        display: 'flex',
        justifyContent: 'flex-end',
        gap: '10px'
    },

    btnEditar: {
        backgroundColor: '#F0F3FF',
        color: '#3A56AF',
        border: '1px solid #C9D3FF',
        padding: '8px 12px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '600',
        fontSize: '0.85rem'
    },

    btnEliminar: {
        backgroundColor: '#FFF1F1',
        color: '#D64545',
        border: '1px solid #FFD0D0',
        padding: '8px 12px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '600',
        fontSize: '0.85rem'
    },

    overlayModal: {
        position: 'fixed',
        top: 0,
        left: 0,
        width: '100vw',
        height: '100vh',
        backgroundColor: 'rgba(45, 50, 71, 0.6)',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        zIndex: 1000
    },
    modal: {
        backgroundColor: 'white',
        padding: '40px',
        borderRadius: '20px',
        width: '400px',
        boxShadow: '0 10px 30px rgba(0,0,0,0.2)'
    },

    modalConfirmacion: {
        backgroundColor: 'white',
        padding: '35px',
        borderRadius: '20px',
        width: '420px',
        boxShadow: '0 10px 30px rgba(0,0,0,0.2)'
    },

    tituloModal: {
        margin: '0 0 20px 0',
        color: '#2D3247'
    },

    textoConfirmacion: {
        color: '#6A7185',
        lineHeight: '1.5',
        marginBottom: '25px'
    },

    btnConfirmarEliminar: {
        backgroundColor: '#D64545',
        color: 'white',
        border: 'none',
        padding: '10px 20px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '600'
    },

    formulario: {
        display: 'flex',
        flexDirection: 'column',
        gap: '15px'
    },
    input: {
        padding: '12px',
        borderRadius: '8px',
        border: '1px solid #E8EBFF',
        outline: 'none',
        fontSize: '1rem'
    },
    textarea: {
        padding: '12px',
        borderRadius: '8px',
        border: '1px solid #E8EBFF',
        outline: 'none',
        fontSize: '1rem',
        minHeight: '80px',
        fontFamily: 'inherit'
    },
    botonesForm: {
        display: 'flex',
        justifyContent: 'flex-end',
        gap: '10px',
        marginTop: '10px'
    },
    btnCancelar: {
        background: 'none',
        border: 'none',
        color: '#6A7185',
        cursor: 'pointer',
        fontWeight: '600'
    },
    btnGuardar: {
        backgroundColor: '#3A56AF',
        color: 'white',
        border: 'none',
        padding: '10px 20px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '600'
    }
};

export default MateriasDashboard;
