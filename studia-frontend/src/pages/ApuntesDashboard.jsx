import React, { useState, useEffect, useRef } from 'react';
import { apunteService } from '../services/apunteService';

const MantenerPresionadoEliminar = ({ onConfirmar, disabled }) => {
    const [presionando, setPresionando] = useState(false);
    const timerRef = useRef(null);

    const limpiarTimer = () => {
        if (timerRef.current) {
            clearTimeout(timerRef.current);
            timerRef.current = null;
        }

        setPresionando(false);
    };

    const iniciarPresionado = () => {
        if (disabled) return;

        setPresionando(true);

        timerRef.current = setTimeout(() => {
            timerRef.current = null;
            setPresionando(false);
            onConfirmar?.();
        }, 1200);
    };

    useEffect(() => {
        return () => limpiarTimer();
    }, []);

    return (
        <button
            type="button"
            style={disabled ? { ...estilos.btnEliminarFinal, ...estilos.btnDisabled } : estilos.btnEliminarFinal}
            onMouseDown={iniciarPresionado}
            onMouseUp={limpiarTimer}
            onMouseLeave={limpiarTimer}
            onTouchStart={iniciarPresionado}
            onTouchEnd={limpiarTimer}
            onTouchCancel={limpiarTimer}
            disabled={disabled}
        >
            <span style={estilos.progresoEliminarWrap}>
                <span
                    style={{
                        ...estilos.progresoEliminar,
                        width: presionando ? '100%' : '0%'
                    }}
                />
            </span>

            <span style={estilos.textoBotonEliminarFinal}>
                {disabled ? 'Eliminando...' : 'Mantener presionado para eliminar'}
            </span>
        </button>
    );
};

const ApuntesDashboard = ({ materia, onVolver, onVerApunte }) => {
    const [apuntes, setApuntes] = useState([]);

    const [mostrarModalNuevo, setMostrarModalNuevo] = useState(false);
    const [tituloNuevoApunte, setTituloNuevoApunte] = useState('');
    const [creandoApunte, setCreandoApunte] = useState(false);

    const [apunteAEliminar, setApunteAEliminar] = useState(null);
    const [eliminandoApunte, setEliminandoApunte] = useState(false);

    const nombreMateria =
        materia?.nombre_materia ||
        materia?.nombreMateria ||
        materia?.NombreMateria ||
        'Materia desconocida';

    useEffect(() => {
        if (materia) {
            cargarApuntes();
        }
    }, [materia]);

    const obtenerIdMateria = () => {
        return materia?.id_materia || materia?.idMateria || materia?.IdMateria || materia?.id || materia?.Id;
    };

    const obtenerIdApunte = (apunte) => {
        return apunte?.id_apunte || apunte?.idApunte || apunte?.IdApunte || apunte?.id || apunte?.Id;
    };

    const obtenerTituloApunte = (apunte) => {
        return apunte?.titulo || apunte?.Titulo || 'Sin título';
    };

    const obtenerContenidoApunte = (apunte) => {
        return apunte?.contenido || apunte?.Contenido || '<p><br></p>';
    };

    const obtenerFechaModificacion = (apunte) => {
        return (
            apunte?.fecha_modificacion ||
            apunte?.fechaModificacion ||
            apunte?.FechaModificacion ||
            apunte?.fecha_actualizacion ||
            apunte?.fechaActualizacion ||
            apunte?.FechaActualizacion ||
            apunte?.updatedAt ||
            apunte?.fecha_creacion ||
            apunte?.fechaCreacion ||
            apunte?.FechaCreacion ||
            null
        );
    };

    const obtenerTimestampModificacion = (apunte) => {
        const fecha = obtenerFechaModificacion(apunte);

        if (!fecha) return 0;

        const timestamp = new Date(fecha).getTime();

        return Number.isNaN(timestamp) ? 0 : timestamp;
    };

    const ordenarApuntesPorModificacion = (lista) => {
        return [...lista].sort(
            (a, b) => obtenerTimestampModificacion(b) - obtenerTimestampModificacion(a)
        );
    };

    const cargarApuntes = async () => {
        try {
            const idMateria = obtenerIdMateria();

            if (!idMateria) {
                setApuntes([]);
                return;
            }

            const data = await apunteService.obtenerPorMateria(idMateria);
            setApuntes(ordenarApuntesPorModificacion(data));
        } catch (error) {
            console.error('Error al cargar los apuntes:', error);
        }
    };

    const cerrarModalNuevo = () => {
        if (creandoApunte) return;

        setMostrarModalNuevo(false);
        setTituloNuevoApunte('');
    };

    const crearNuevoApunte = async (e) => {
        e.preventDefault();

        const titulo = tituloNuevoApunte.trim();

        if (!titulo) {
            alert('El título del apunte es obligatorio.');
            return;
        }

        const idMateria = Number(obtenerIdMateria());

        if (!idMateria) {
            alert('No se encontró la materia activa.');
            return;
        }

        setCreandoApunte(true);

        try {
            const fechaActual = new Date().toISOString();

            const nuevoApunte = {
                idMateria,
                titulo,
                contenido: '<p><br></p>',
                fechaCreacion: fechaActual,
                fechaModificacion: fechaActual
            };

            const respuesta = await apunteService.crear(nuevoApunte);

            let apunteCreado =
                respuesta && typeof respuesta === 'object'
                    ? respuesta
                    : null;

            if (!apunteCreado || !obtenerIdApunte(apunteCreado)) {
                const apuntesActualizados = await apunteService.obtenerPorMateria(idMateria);
                setApuntes(apuntesActualizados);

                apunteCreado =
                    [...apuntesActualizados]
                        .reverse()
                        .find((apunte) => obtenerTituloApunte(apunte) === titulo) || null;
            }

            if (!apunteCreado) {
                throw new Error('El apunte se creó, pero no se pudo recuperar desde la API.');
            }

            const apunteParaAbrir = {
                ...apunteCreado,
                idMateria:
                    apunteCreado.idMateria ||
                    apunteCreado.IdMateria ||
                    apunteCreado.id_materia ||
                    idMateria,
                titulo: obtenerTituloApunte(apunteCreado),
                Titulo: obtenerTituloApunte(apunteCreado),
                contenido: obtenerContenidoApunte(apunteCreado),
                Contenido: obtenerContenidoApunte(apunteCreado)
            };

            setMostrarModalNuevo(false);
            setTituloNuevoApunte('');

            if (onVerApunte) {
                onVerApunte(apunteParaAbrir);
            }
        } catch (error) {
            console.error('Error al crear apunte:', error);
            alert('Error al crear el apunte. Revisá la consola para ver el detalle.');
        } finally {
            setCreandoApunte(false);
        }
    };

    const abrirModalEliminar = (apunte) => {
        setApunteAEliminar(apunte);
    };

    const cerrarModalEliminar = () => {
        if (eliminandoApunte) return;
        setApunteAEliminar(null);
    };

    const confirmarEliminarApunte = async () => {
        if (!apunteAEliminar || eliminandoApunte) return;

        const id = obtenerIdApunte(apunteAEliminar);

        if (!id) {
            alert('No se encontró el ID del apunte.');
            return;
        }

        setEliminandoApunte(true);

        try {
            await apunteService.eliminar(id);

            setApuntes((prevApuntes) =>
                prevApuntes.filter((apunte) => obtenerIdApunte(apunte) !== id)
            );

            setApunteAEliminar(null);
        } catch (error) {
            console.error('Error al eliminar apunte:', error);
            alert('No se pudo eliminar el apunte. Revisá la consola.');
        } finally {
            setEliminandoApunte(false);
        }
    };

    const formatearFechaModificacion = (apunte) => {
        const fecha = obtenerFechaModificacion(apunte);

        if (!fecha) return 'Sin fecha';

        const date = new Date(fecha);
        date.setHours(date.getHours() - 3);

        const hora = date.toLocaleTimeString('es-AR', {
            hour: '2-digit',
            minute: '2-digit',
            hour12: false
        });

        const dia = String(date.getDate()).padStart(2, '0');
        const mes = String(date.getMonth() + 1).padStart(2, '0');
        const anio = String(date.getFullYear()).slice(-2);

        return `${hora} - ${dia}/${mes}/${anio}`;
    };

    return (
        <div style={estilos.contenedorPrincipal}>
            <div style={estilos.cabecera}>
                <div style={estilos.grupoIzquierdo}>
                    <button style={estilos.btnVolver} onClick={onVolver}>
                        ← Volver a Materias
                    </button>

                    <h2 style={estilos.tituloSeccion}>
                        Apuntes de <span style={{ color: '#3A56AF' }}>{nombreMateria}</span>
                    </h2>
                </div>

                <button
                    type="button"
                    style={estilos.btnAgregar}
                    onClick={() => setMostrarModalNuevo(true)}
                >
                    + Nuevo Apunte
                </button>
            </div>

            <div style={estilos.scrollApuntes}>
                <div style={estilos.gridApuntes}>
                    {apuntes.length === 0 ? (
                        <div style={estilos.vacio}>
                            <p style={{ color: '#6A7185' }}>No hay apuntes todavía.</p>
                            <p style={{ fontSize: '0.9rem', color: '#9EA5BA' }}>
                                Hacé clic en "+ Nuevo Apunte" para empezar a estudiar.
                            </p>
                        </div>
                    ) : (
                        apuntes.map((apunte, index) => (
                            <div
                                key={obtenerIdApunte(apunte) || index}
                                style={estilos.tarjetaApunte}
                                onClick={() => {
                                    if (onVerApunte) {
                                        onVerApunte(apunte);
                                    }
                                }}
                            >
                                <h3 style={estilos.tituloApunte}>
                                    {obtenerTituloApunte(apunte)}
                                </h3>

                                <div style={estilos.fecha}>
                                    {formatearFechaModificacion(apunte)}
                                </div>

                                <div
                                    style={estilos.footerApunte}
                                    onClick={(e) => e.stopPropagation()}
                                >
                                    <button
                                        type="button"
                                        style={estilos.btnEliminarTarjeta}
                                        onClick={() => abrirModalEliminar(apunte)}
                                    >
                                        Eliminar
                                    </button>
                                </div>
                            </div>
                        ))
                    )}
                </div>
            </div>

            {mostrarModalNuevo && (
                <div style={estilos.overlayModal}>
                    <div style={estilos.modal}>
                        <h3 style={estilos.tituloModal}>Nuevo apunte</h3>

                        <form onSubmit={crearNuevoApunte} style={estilos.formulario}>
                            <label style={estilos.labelInput}>
                                Título del apunte
                            </label>

                            <input
                                type="text"
                                placeholder="Ej: Resumen clase 1"
                                value={tituloNuevoApunte}
                                onChange={(e) => setTituloNuevoApunte(e.target.value)}
                                style={estilos.input}
                                autoFocus
                                required
                            />

                            <div style={estilos.botonesModal}>
                                <button
                                    type="button"
                                    onClick={cerrarModalNuevo}
                                    style={estilos.btnCancelar}
                                    disabled={creandoApunte}
                                >
                                    Cancelar
                                </button>

                                <button
                                    type="submit"
                                    style={
                                        creandoApunte
                                            ? { ...estilos.btnCrear, ...estilos.btnDisabled }
                                            : estilos.btnCrear
                                    }
                                    disabled={creandoApunte}
                                >
                                    {creandoApunte ? 'Creando...' : 'Crear'}
                                </button>
                            </div>
                        </form>
                    </div>
                </div>
            )}

            {apunteAEliminar && (
                <div style={estilos.overlayModal}>
                    <div style={estilos.modalEliminar}>
                        <h3 style={estilos.tituloModal}>Eliminar apunte</h3>

                        <p style={estilos.textoModal}>
                            ¿Estás seguro de que querés eliminar el apunte{' '}
                            <strong>{obtenerTituloApunte(apunteAEliminar)}</strong>?
                        </p>

                        <p style={estilos.textoAdvertencia}>
                            Esta acción es irreversible. Para confirmar, mantené presionado el botón eliminar.
                        </p>

                        <div style={estilos.botonesModal}>
                            <button
                                type="button"
                                style={estilos.btnCancelar}
                                onClick={cerrarModalEliminar}
                                disabled={eliminandoApunte}
                            >
                                Cancelar
                            </button>

                            <MantenerPresionadoEliminar
                                disabled={eliminandoApunte}
                                onConfirmar={confirmarEliminarApunte}
                            />
                        </div>
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
        display: 'flex',
        flexDirection: 'column',
        overflow: 'hidden'
    },
    cabecera: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        marginBottom: '30px',
        flexShrink: 0
    },
    grupoIzquierdo: {
        display: 'flex',
        flexDirection: 'column',
        gap: '5px'
    },
    btnVolver: {
        background: 'none',
        border: 'none',
        color: '#6A7185',
        cursor: 'pointer',
        textAlign: 'left',
        fontSize: '0.9rem',
        padding: 0
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
        transition: 'all 0.2s'
    },
    scrollApuntes: {
        flex: 1,
        minHeight: 0,
        overflowY: 'auto',
        overflowX: 'hidden',
        paddingRight: '8px'
    },
    gridApuntes: {
        display: 'grid',
        gridTemplateColumns: 'repeat(auto-fill, minmax(280px, 1fr))',
        gap: '20px',
        paddingBottom: '24px'
    },
    tarjetaApunte: {
        backgroundColor: 'white',
        borderRadius: '12px',
        padding: '20px',
        border: '1px solid #E8EBFF',
        boxShadow: '0 2px 8px rgba(58, 86, 175, 0.04)',
        cursor: 'pointer',
        transition: 'transform 0.2s',
        display: 'flex',
        flexDirection: 'column',
        minHeight: '150px'
    },
    tituloApunte: {
        fontSize: '1.2rem',
        color: '#2D3247',
        margin: '0 0 15px 0'
    },
    fecha: {
        fontSize: '0.8rem',
        color: '#9EA5BA',
        display: 'flex',
        alignItems: 'center',
        gap: '5px'
    },
    footerApunte: {
        marginTop: 'auto',
        display: 'flex',
        justifyContent: 'flex-end',
        paddingTop: '18px'
    },
    btnEliminarTarjeta: {
        backgroundColor: '#FFF1F1',
        color: '#D64545',
        border: '1px solid #FFD0D0',
        padding: '8px 12px',
        borderRadius: '8px',
        cursor: 'pointer',
        fontWeight: '700',
        fontSize: '0.85rem'
    },
    vacio: {
        gridColumn: '1 / -1',
        textAlign: 'center',
        padding: '40px',
        backgroundColor: '#F9FBFF',
        borderRadius: '15px',
        border: '1px dashed #C8D5EB'
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
        padding: '35px',
        borderRadius: '20px',
        width: '430px',
        maxWidth: 'calc(100vw - 32px)',
        boxShadow: '0 10px 30px rgba(0,0,0,0.2)'
    },
    modalEliminar: {
        backgroundColor: 'white',
        padding: '35px',
        borderRadius: '20px',
        width: '430px',
        maxWidth: 'calc(100vw - 32px)',
        boxShadow: '0 10px 30px rgba(0,0,0,0.2)'
    },
    tituloModal: {
        margin: '0 0 18px 0',
        color: '#2D3247'
    },
    formulario: {
        display: 'flex',
        flexDirection: 'column',
        gap: '12px'
    },
    labelInput: {
        color: '#465365',
        fontWeight: '700',
        fontSize: '0.9rem'
    },
    input: {
        padding: '12px',
        borderRadius: '8px',
        border: '1px solid #E8EBFF',
        outline: 'none',
        fontSize: '1rem'
    },
    textoModal: {
        color: '#465365',
        lineHeight: '1.5',
        margin: '0 0 12px 0'
    },
    textoAdvertencia: {
        color: '#D64545',
        backgroundColor: '#FFF1F1',
        border: '1px solid #FFD0D0',
        borderRadius: '10px',
        padding: '12px',
        fontSize: '0.9rem',
        lineHeight: '1.4',
        margin: '0 0 22px 0',
        fontWeight: '600'
    },
    botonesModal: {
        display: 'flex',
        justifyContent: 'flex-end',
        alignItems: 'center',
        gap: '10px',
        flexWrap: 'wrap',
        marginTop: '16px'
    },
    btnCancelar: {
        background: 'none',
        border: 'none',
        color: '#6A7185',
        cursor: 'pointer',
        fontWeight: '700',
        padding: '10px 14px'
    },
    btnCrear: {
        backgroundColor: '#3A56AF',
        color: 'white',
        border: 'none',
        padding: '10px 18px',
        borderRadius: '9px',
        cursor: 'pointer',
        fontWeight: '800'
    },
    btnEliminarFinal: {
        position: 'relative',
        overflow: 'hidden',
        backgroundColor: '#D64545',
        color: 'white',
        border: 'none',
        padding: '10px 18px',
        borderRadius: '9px',
        cursor: 'pointer',
        fontWeight: '800',
        minWidth: '235px'
    },
    btnDisabled: {
        opacity: 0.7,
        cursor: 'not-allowed'
    },
    progresoEliminarWrap: {
        position: 'absolute',
        inset: 0,
        backgroundColor: 'rgba(255,255,255,0.08)'
    },
    progresoEliminar: {
        position: 'absolute',
        left: 0,
        top: 0,
        bottom: 0,
        backgroundColor: 'rgba(255,255,255,0.25)',
        transition: 'width 1.2s linear'
    },
    textoBotonEliminarFinal: {
        position: 'relative',
        zIndex: 1
    }
};

export default ApuntesDashboard;
