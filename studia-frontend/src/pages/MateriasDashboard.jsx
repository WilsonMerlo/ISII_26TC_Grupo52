import React, { useState, useEffect, useRef } from 'react';
import { materiaService } from '../services/materiaService';

const IconoEditar = () => (
    <svg
        width="18"
        height="18"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round"
        aria-hidden="true"
    >
        <path d="M12 20h9" />
        <path d="M16.5 3.5a2.1 2.1 0 0 1 3 3L7 19l-4 1 1-4L16.5 3.5z" />
    </svg>
);

const IconoBasurero = () => (
    <svg
        width="18"
        height="18"
        viewBox="0 0 24 24"
        fill="none"
        stroke="currentColor"
        strokeWidth="2"
        strokeLinecap="round"
        strokeLinejoin="round"
        aria-hidden="true"
    >
        <polyline points="3 6 5 6 21 6" />
        <path d="M19 6l-1 14H6L5 6" />
        <path d="M10 11v6" />
        <path d="M14 11v6" />
        <path d="M9 6V4h6v2" />
    </svg>
);

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

    const [busqueda, setBusqueda] = useState('');
    const [buscadorActivo, setBuscadorActivo] = useState(false);
    const buscadorRef = useRef(null);

    useEffect(() => {
        cargarMaterias();
    }, []);

    useEffect(() => {
        const manejarClickFuera = (event) => {
            if (buscadorRef.current && !buscadorRef.current.contains(event.target)) {
                setBuscadorActivo(false);
            }
        };

        document.addEventListener('mousedown', manejarClickFuera);

        return () => {
            document.removeEventListener('mousedown', manejarClickFuera);
        };
    }, []);

    const obtenerIdMateria = (materia) => {
        return materia?.id_materia || materia?.idMateria || materia?.IdMateria || materia?.id;
    };

    const obtenerNombreMateria = (materia) => {
        return materia?.nombre_materia || materia?.nombreMateria || materia?.NombreMateria || '';
    };

    const obtenerDescripcionMateria = (materia) => {
        return materia?.descripcion || materia?.Descripcion || '';
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

            cargarMaterias();
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

    const normalizarTexto = (texto) => {
        return String(texto || '')
            .normalize('NFD')
            .replace(/[\u0300-\u036f]/g, '')
            .toLowerCase()
            .trim();
    };

    const terminoNormalizado = normalizarTexto(busqueda);

    const materiasCoincidentes = terminoNormalizado
        ? materias.filter((materia) => {
            const nombre = normalizarTexto(obtenerNombreMateria(materia));
            const descripcion = normalizarTexto(obtenerDescripcionMateria(materia));

            return nombre.includes(terminoNormalizado) || descripcion.includes(terminoNormalizado);
        })
        : [];

    const abrirMateriaDesdeBusqueda = (materia) => {
        setBusqueda('');
        setBuscadorActivo(false);

        if (onNavegar) {
            onNavegar('apuntes', materia);
        }
    };

    return (
        <div style={estilos.contenedorPrincipal}>
            <div style={estilos.cabecera}>
                <div style={estilos.filaTituloBuscador}>
                    <h2 style={estilos.tituloSeccion}>Mis Materias</h2>

                    <div style={estilos.buscadorWrapper} ref={buscadorRef}>
                        <div style={estilos.buscadorCaja}>
                            <svg
                                width="20"
                                height="20"
                                viewBox="0 0 24 24"
                                fill="none"
                                stroke="currentColor"
                                strokeWidth="2"
                                strokeLinecap="round"
                                strokeLinejoin="round"
                                aria-hidden="true"
                                style={estilos.buscadorIcono}
                            >
                                <circle cx="11" cy="11" r="8" />
                                <path d="M21 21l-4.3-4.3" />
                            </svg>

                            <input
                                type="text"
                                value={busqueda}
                                onChange={(e) => {
                                    setBusqueda(e.target.value);
                                    setBuscadorActivo(true);
                                }}
                                onFocus={() => setBuscadorActivo(true)}
                                placeholder="Buscar materia..."
                                style={estilos.buscadorInput}
                            />
                        </div>

                        {buscadorActivo && busqueda.trim() && (
                            <div style={estilos.resultadosBusqueda}>
                                {materiasCoincidentes.length > 0 ? (
                                    materiasCoincidentes.map((materia) => (
                                        <button
                                            key={obtenerIdMateria(materia)}
                                            type="button"
                                            style={estilos.resultadoItem}
                                            onClick={() => abrirMateriaDesdeBusqueda(materia)}
                                        >
                                            <span style={estilos.resultadoTitulo}>
                                                {obtenerNombreMateria(materia)}
                                            </span>

                                            <span style={estilos.resultadoDescripcion}>
                                                {obtenerDescripcionMateria(materia) || 'Sin descripción'}
                                            </span>
                                        </button>
                                    ))
                                ) : (
                                    <div style={estilos.resultadoVacio}>
                                        No se encontraron materias.
                                    </div>
                                )}
                            </div>
                        )}
                    </div>
                </div>

                <button
                    style={estilos.btnAgregar}
                    onClick={() => setMostrarModal(true)}
                >
                    <span style={estilos.iconoPlus}>+</span> Agregar Materia
                </button>
            </div>

            <div style={estilos.scrollMaterias}>
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

                            <div style={estilos.footerTarjeta} onClick={(e) => e.stopPropagation()}>
                                <button
                                    type="button"
                                    style={estilos.btnEditar}
                                    onClick={() => abrirModalEditar(materia)}
                                    title="Editar materia"
                                    aria-label="Editar materia"
                                >
                                    <IconoEditar />
                                </button>

                                <button
                                    type="button"
                                    style={estilos.btnEliminar}
                                    onClick={() => abrirModalEliminar(materia)}
                                    title="Borrar materia"
                                    aria-label="Borrar materia"
                                >
                                    <IconoBasurero />
                                </button>
                            </div>
                        </div>
                    ))}
                </div>
            </div>

            {mostrarModal && (
                <div style={estilos.overlayModal}>
                    <div style={estilos.modal}>
                        <h3 style={estilos.tituloModal}>Nueva Materia</h3>

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
        height: '100%',
        minHeight: 0,
        boxSizing: 'border-box',
        position: 'relative',
        display: 'flex',
        flexDirection: 'column',
        overflow: 'hidden'
    },

    cabecera: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        gap: '20px',
        marginBottom: '30px',
        flexShrink: 0
    },

    tituloSeccion: {
        color: '#2D3247',
        margin: 0,
        fontSize: '1.8rem',
        flexShrink: 0
    },

    filaTituloBuscador: {
        display: 'flex',
        alignItems: 'center',
        gap: '20px',
        flexWrap: 'wrap',
        flex: 1,
        minWidth: 0
    },

    buscadorWrapper: {
        position: 'relative',
        flex: '1 1 320px',
        maxWidth: '520px',
        minWidth: '260px',
        zIndex: 20
    },

    buscadorCaja: {
        height: '48px',
        backgroundColor: 'white',
        border: '1px solid #E8EBFF',
        borderRadius: '999px',
        boxShadow: '0 10px 24px rgba(58, 86, 175, 0.08)',
        display: 'flex',
        alignItems: 'center',
        gap: '12px',
        padding: '0 18px'
    },

    buscadorIcono: {
        color: '#6A7185',
        flexShrink: 0
    },

    buscadorInput: {
        border: 'none',
        outline: 'none',
        width: '100%',
        height: '100%',
        backgroundColor: 'transparent',
        color: '#2D3247',
        fontSize: '0.95rem'
    },

    resultadosBusqueda: {
        position: 'absolute',
        top: '58px',
        left: 0,
        right: 0,
        backgroundColor: 'white',
        border: '1px solid #E8EBFF',
        borderRadius: '16px',
        boxShadow: '0 16px 36px rgba(45, 50, 71, 0.16)',
        padding: '8px',
        maxHeight: '280px',
        overflowY: 'auto'
    },

    resultadoItem: {
        width: '100%',
        background: 'none',
        border: 'none',
        textAlign: 'left',
        padding: '12px 14px',
        borderRadius: '12px',
        cursor: 'pointer',
        display: 'flex',
        flexDirection: 'column',
        gap: '4px'
    },

    resultadoTitulo: {
        color: '#2D3247',
        fontWeight: 700,
        fontSize: '0.95rem'
    },

    resultadoDescripcion: {
        color: '#9EA5BA',
        fontSize: '0.78rem',
        whiteSpace: 'nowrap',
        overflow: 'hidden',
        textOverflow: 'ellipsis'
    },

    resultadoVacio: {
        color: '#9EA5BA',
        fontSize: '0.9rem',
        padding: '14px',
        textAlign: 'center'
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

    scrollMaterias: {
        flex: 1,
        minHeight: 0,
        overflowY: 'auto',
        overflowX: 'hidden',
        paddingRight: '8px'
    },

    gridMaterias: {
        display: 'grid',
        gridTemplateColumns: 'repeat(auto-fill, minmax(320px, 1fr))',
        gap: '25px',
        paddingBottom: '24px'
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
        width: '36px',
        height: '36px',
        borderRadius: '8px',
        cursor: 'pointer',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
        padding: 0
    },

    btnEliminar: {
        backgroundColor: '#FFF1F1',
        color: '#D64545',
        border: '1px solid #FFD0D0',
        width: '36px',
        height: '36px',
        borderRadius: '8px',
        cursor: 'pointer',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
        padding: 0
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
        fontWeight: '600',
        padding: '10px 14px'
    },

    btnGuardar: {
        backgroundColor: '#3A56AF',
        color: 'white',
        border: 'none',
        padding: '10px 20px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '600'
    },

    btnConfirmarEliminar: {
        backgroundColor: '#D64545',
        color: 'white',
        border: 'none',
        padding: '10px 20px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '600'
    }
};

export default MateriasDashboard;
