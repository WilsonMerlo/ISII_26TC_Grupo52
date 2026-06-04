import React, { useState, useEffect } from 'react';
import { apunteService } from '../services/apunteService';

const ApuntesDashboard = ({ materia, onVolver, onVerApunte }) => {
    const [apuntes, setApuntes] = useState([]);
    const [mostrarModalNuevo, setMostrarModalNuevo] = useState(false);
    const [tituloNuevoApunte, setTituloNuevoApunte] = useState('');
    const [creandoApunte, setCreandoApunte] = useState(false);

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

    const cargarApuntes = async () => {
        try {
            const idMateria = obtenerIdMateria();

            if (!idMateria) {
                setApuntes([]);
                return;
            }

            const data = await apunteService.obtenerPorMateria(idMateria);
            setApuntes(data);
        } catch (error) {
            console.error('Error al cargar los apuntes:', error);
        }
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
            const nuevoApunte = {
                idMateria,
                titulo,
                contenido: '<p><br></p>',
                fechaCreacion: new Date().toISOString()
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

    const formatearFechaModificacion = (apunte) => {
        const fecha =
            apunte.fecha_modificacion ||
            apunte.fechaModificacion ||
            apunte.FechaModificacion ||
            apunte.fecha_actualizacion ||
            apunte.fechaActualizacion ||
            apunte.FechaActualizacion ||
            apunte.updatedAt ||
            apunte.fecha_creacion ||
            apunte.fechaCreacion ||
            apunte.FechaCreacion;

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
                        </div>
                    ))
                )}
            </div>

            {mostrarModalNuevo && (
                <div style={estilos.overlayModal}>
                    <div style={estilos.modal}>
                        <h3 style={estilos.tituloModal}>Nuevo Apunte</h3>

                        <form onSubmit={crearNuevoApunte} style={estilos.formulario}>
                            <input
                                type="text"
                                placeholder="Título del apunte"
                                value={tituloNuevoApunte}
                                onChange={(e) => setTituloNuevoApunte(e.target.value)}
                                style={estilos.input}
                                autoFocus
                                required
                            />

                            <div style={estilos.botonesForm}>
                                <button
                                    type="button"
                                    onClick={() => {
                                        setMostrarModalNuevo(false);
                                        setTituloNuevoApunte('');
                                    }}
                                    style={estilos.btnCancelar}
                                    disabled={creandoApunte}
                                >
                                    Cancelar
                                </button>

                                <button
                                    type="submit"
                                    style={{
                                        ...estilos.btnGuardar,
                                        opacity: creandoApunte ? 0.7 : 1,
                                        cursor: creandoApunte ? 'not-allowed' : 'pointer'
                                    }}
                                    disabled={creandoApunte}
                                >
                                    {creandoApunte ? 'Creando...' : 'Aceptar'}
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
        boxSizing: 'border-box'
    },
    cabecera: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        marginBottom: '30px'
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
    gridApuntes: {
        display: 'grid',
        gridTemplateColumns: 'repeat(auto-fill, minmax(280px, 1fr))',
        gap: '20px'
    },
    tarjetaApunte: {
        backgroundColor: 'white',
        borderRadius: '12px',
        padding: '20px',
        border: '1px solid #E8EBFF',
        boxShadow: '0 2px 8px rgba(58, 86, 175, 0.04)',
        cursor: 'pointer',
        transition: 'transform 0.2s'
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
        width: '400px',
        boxShadow: '0 10px 30px rgba(0,0,0,0.2)'
    },
    tituloModal: {
        margin: '0 0 20px 0',
        color: '#2D3247'
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
    }
};

export default ApuntesDashboard;
