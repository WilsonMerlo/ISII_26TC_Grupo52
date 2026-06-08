import React, { useEffect, useMemo, useRef, useState } from 'react';
import { materiaService } from '../services/materiaService';
import { apunteService } from '../services/apunteService';
import { estadisticaService } from '../services/estadisticaService';


const obtenerIdUsuario = (item) => (
    Number(
        item?.idUsuario ||
        item?.IdUsuario ||
        item?.id_usuario ||
        item?.usuarioId ||
        item?.UsuarioId ||
        0
    )
);

const obtenerIdMateria = (materia) => (
    materia?.id_materia || materia?.idMateria || materia?.IdMateria || materia?.id || materia?.Id
);

const obtenerNombreMateria = (materia) => (
    materia?.nombre_materia || materia?.nombreMateria || materia?.NombreMateria || 'Sin nombre'
);

const obtenerDescripcionMateria = (materia) => (
    materia?.descripcion || materia?.Descripcion || ''
);

const obtenerIdApunte = (apunte) => (
    apunte?.id_apunte || apunte?.idApunte || apunte?.IdApunte || apunte?.id || apunte?.Id
);

const obtenerTituloApunte = (apunte) => (
    apunte?.titulo || apunte?.Titulo || 'Sin título'
);

const obtenerContenidoApunte = (apunte) => (
    apunte?.contenido || apunte?.Contenido || ''
);

const obtenerFechaModificacion = (apunte) => (
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

const obtenerTiempoFecha = (fechaValor) => {
    if (!fechaValor) return 0;

    const fecha = new Date(fechaValor);
    return Number.isNaN(fecha.getTime()) ? 0 : fecha.getTime();
};

const convertirHtmlATexto = (html) => {
    const texto = String(html || '').replace(/<[^>]*>/g, ' ').replace(/&nbsp;/g, ' ');
    return texto.replace(/\s+/g, ' ').trim();
};

const formatearTiempoRelativo = (fechaValor) => {
    if (!fechaValor) return 'Sin fecha';

    const fecha = new Date(fechaValor);
    if (Number.isNaN(fecha.getTime())) return 'Sin fecha';

    const diferenciaMs = Date.now() - fecha.getTime();
    const minutos = Math.floor(diferenciaMs / 60000);
    const horas = Math.floor(minutos / 60);
    const dias = Math.floor(horas / 24);

    if (minutos < 1) return 'Ahora';
    if (minutos < 60) return `Hace ${minutos} min`;
    if (horas < 24) return `Hace ${horas} h`;
    if (dias === 1) return 'Ayer';
    return `Hace ${dias} días`;
};

const MenuDashboard = ({ onNavegar }) => {
    const [materias, setMaterias] = useState([]);
    const [apuntesRecientes, setApuntesRecientes] = useState([]);
    const [estadisticas, setEstadisticas] = useState(null);
    const [cargando, setCargando] = useState(true);
    const [mostrarModalMateria, setMostrarModalMateria] = useState(false);
    const [nuevaMateria, setNuevaMateria] = useState({
        nombreMateria: '',
        descripcion: ''
    });
    const modalMateriaRef = useRef(null);
    const inputNombreMateriaRef = useRef(null);

    const nombreUsuario = localStorage.getItem('nombreUsuario') || 'Usuario';

    const cargarDatos = async () => {
        setCargando(true);

        try {
            const idUsuario = Number(localStorage.getItem('idUsuario'));

            if (!idUsuario) {
                setMaterias([]);
                setApuntesRecientes([]);
                return;
            }

            const materiasData = await materiaService.obtenerPorUsuario(idUsuario);

            const materiasNormalizadas = (Array.isArray(materiasData) ? materiasData : [])
                .filter((materia) => {
                    const idUsuarioMateria = obtenerIdUsuario(materia);
                    return !idUsuarioMateria || idUsuarioMateria === idUsuario;
                });

            const datosPorMateria = await Promise.all(
                materiasNormalizadas.map(async (materia) => {
                    const idMateria = obtenerIdMateria(materia);

                    if (!idMateria) {
                        return {
                            materia,
                            apuntes: [],
                            ultimaModificacionMs: 0
                        };
                    }

                    const apuntes = await apunteService.obtenerPorMateria(idMateria);

                    const apuntesNormalizados = (Array.isArray(apuntes) ? apuntes : []).map((apunte) => ({
                        ...apunte,
                        materiaOrigen: materia,
                        nombreMateria: obtenerNombreMateria(materia),
                        idMateria
                    }));

                    const ultimaModificacionMs = Math.max(
                        0,
                        ...apuntesNormalizados.map((apunte) =>
                            obtenerTiempoFecha(obtenerFechaModificacion(apunte))
                        )
                    );

                    return {
                        materia: {
                            ...materia,
                            ultimaModificacionApunteMs: ultimaModificacionMs
                        },
                        apuntes: apuntesNormalizados,
                        ultimaModificacionMs
                    };
                })
            );

            const materiasOrdenadas = datosPorMateria
                .map((item) => item.materia)
                .sort((a, b) => {
                    const fechaA = Number(a.ultimaModificacionApunteMs) || 0;
                    const fechaB = Number(b.ultimaModificacionApunteMs) || 0;

                    if (fechaB !== fechaA) return fechaB - fechaA;

                    return obtenerNombreMateria(a).localeCompare(
                        obtenerNombreMateria(b),
                        'es',
                        { sensitivity: 'base' }
                    );
                });

            const ultimosApuntes = datosPorMateria
                .flatMap((item) => item.apuntes)
                .sort((a, b) => {
                    const fechaA = obtenerTiempoFecha(obtenerFechaModificacion(a));
                    const fechaB = obtenerTiempoFecha(obtenerFechaModificacion(b));
                    return fechaB - fechaA;
                })
                .slice(0, 3);

            setMaterias(materiasOrdenadas);
            setApuntesRecientes(ultimosApuntes);
        } catch (error) {
            console.error('Error cargando datos del menú:', error);
        } finally {
            setCargando(false);
        }
    };

    const cargarEstadisticas = async () => {
        try {
            const data = await estadisticaService.obtenerEstadisticasSemana();
            setEstadisticas(data);
        } catch (error) {
            console.warn('No se pudieron cargar estadísticas del menú:', error);
            setEstadisticas(null);
        }
    };

    useEffect(() => {
        cargarDatos();
        cargarEstadisticas();
    }, []);

    useEffect(() => {
        if (!mostrarModalMateria) return;

        const timeoutId = setTimeout(() => {
            inputNombreMateriaRef.current?.focus();
            inputNombreMateriaRef.current?.select();
        }, 0);

        return () => clearTimeout(timeoutId);
    }, [mostrarModalMateria]);

    const materiasVisibles = useMemo(() => materias.slice(0, 3), [materias]);

    const diasSemana = estadisticas?.porDia?.length
        ? estadisticas.porDia
        : [
            { dia: 'LUN', minutos: 0 },
            { dia: 'MAR', minutos: 0 },
            { dia: 'MIÉ', minutos: 0 },
            { dia: 'JUE', minutos: 0 },
            { dia: 'VIE', minutos: 0 },
            { dia: 'SÁB', minutos: 0 },
            { dia: 'DOM', minutos: 0 }
        ];

    const maxMinutos = Math.max(...diasSemana.map((dia) => Number(dia.minutos) || 0), 1);
    const totalHorasSemana = ((estadisticas?.totalSemanaMinutos || 0) / 60).toFixed(1);

    const cerrarModalMateria = () => {
        setMostrarModalMateria(false);
        setNuevaMateria({
            nombreMateria: '',
            descripcion: ''
        });
    };

    const guardarNuevaMateria = async () => {
        if (!nuevaMateria.nombreMateria.trim()) {
            alert('El nombre de la materia es obligatorio.');
            return;
        }

        const idUsuario = Number(localStorage.getItem('idUsuario'));

        if (!idUsuario) {
            alert('No se encontró el usuario logueado. Iniciá sesión nuevamente.');
            return;
        }

        try {
            const materiaCreada = await materiaService.crear({
                idUsuario,
                nombreMateria: nuevaMateria.nombreMateria.trim(),
                descripcion: nuevaMateria.descripcion.trim()
            });

            cerrarModalMateria();
            await cargarDatos();

            if (materiaCreada && typeof materiaCreada === 'object') {
                onNavegar?.('apuntes', materiaCreada);
                return;
            }

            onNavegar?.('materias');
        } catch (error) {
            console.error('Error al crear materia:', error);
            alert('Error al crear la materia. Revisá la conexión con el servidor.');
        }
    };

    const manejarCrearMateria = async (event) => {
        event?.preventDefault();
        await guardarNuevaMateria();
    };

    useEffect(() => {
        if (!mostrarModalMateria) return;

        const manejarClickFuera = (event) => {
            if (
                modalMateriaRef.current &&
                !modalMateriaRef.current.contains(event.target)
            ) {
                cerrarModalMateria();
            }
        };

        const manejarTeclado = (event) => {
            if (event.key === 'Escape') {
                event.preventDefault();
                cerrarModalMateria();
                return;
            }

            if (event.key === 'Enter') {
                event.preventDefault();
                event.stopPropagation();
                guardarNuevaMateria();
            }
        };

        document.addEventListener('mousedown', manejarClickFuera);
        document.addEventListener('touchstart', manejarClickFuera);
        document.addEventListener('keydown', manejarTeclado, true);

        return () => {
            document.removeEventListener('mousedown', manejarClickFuera);
            document.removeEventListener('touchstart', manejarClickFuera);
            document.removeEventListener('keydown', manejarTeclado, true);
        };
    }, [mostrarModalMateria, nuevaMateria]);

    const abrirMateria = (materia) => {
        onNavegar?.('apuntes', materia);
    };

    const abrirApunte = (apunte) => {
        onNavegar?.('verApunte', {
            apunte,
            materia: apunte.materiaOrigen || {
                idMateria: apunte.idMateria,
                nombreMateria: apunte.nombreMateria
            }
        });
    };

    return (
        <div style={estilos.contenedor}>
            <section style={estilos.hero}>
                <h1 style={estilos.titulo}>Bienvenido de nuevo, {nombreUsuario}.</h1>
                <p style={estilos.subtitulo}>¿Listo para otra sesión de trabajo profundo?</p>
            </section>

            <section style={estilos.gridPrincipal}>
                <div style={estilos.cardMaterias}>
                    <div style={estilos.cardHeader}>
                        <div>
                            <span style={estilos.badge}>Gestión académica</span>
                            <h2 style={estilos.tituloSeccion}>Tus Materias</h2>
                            <p style={estilos.descripcion}>Organiza tus áreas de estudio.</p>
                        </div>

                        <button
                            type="button"
                            style={estilos.btnPrimario}
                            onClick={() => setMostrarModalMateria(true)}
                        >
                            <span style={estilos.iconoBtn}>+</span>
                            Nueva Materia
                        </button>
                    </div>

                    {cargando ? (
                        <p style={estilos.estadoVacio}>Cargando materias...</p>
                    ) : materiasVisibles.length === 0 ? (
                        <p style={estilos.estadoVacio}>Todavía no tenés materias creadas.</p>
                    ) : (
                        <div style={estilos.gridMaterias}>
                            {materiasVisibles.map((materia, index) => (
                                <button
                                    key={obtenerIdMateria(materia) || index}
                                    type="button"
                                    style={estilos.tarjetaMateria}
                                    onClick={() => abrirMateria(materia)}
                                >
                                    <div style={estilos.iconoMateria}>Σ</div>
                                    <h3 style={estilos.nombreMateria}>{obtenerNombreMateria(materia)}</h3>
                                    {obtenerDescripcionMateria(materia) && (
                                        <p style={estilos.descripcionMateria}>{obtenerDescripcionMateria(materia)}</p>
                                    )}
                                </button>
                            ))}
                        </div>
                    )}
                </div>

                <div style={estilos.cardPomodoro}>
                    <div style={estilos.cardHeaderCompacto}>
                        <div>
                            <h2 style={estilos.tituloCardChico}>Horas de Enfoque</h2>
                            <p style={estilos.descripcionChica}>Esta semana</p>
                        </div>
                        <div style={estilos.totalHoras}>{totalHorasSemana}</div>
                    </div>

                    <div style={estilos.barras}>
                        {diasSemana.map((dia, index) => {
                            const alto = Math.max(12, Math.round(((Number(dia.minutos) || 0) / maxMinutos) * 100));

                            return (
                                <div key={`${dia.dia}-${index}`} style={estilos.columnaBarra}>
                                    <div
                                        style={{
                                            ...estilos.barra,
                                            height: `${alto}%`,
                                            ...(alto === 100 ? estilos.barraActiva : {})
                                        }}
                                    />
                                    <span style={estilos.labelDia}>{String(dia.dia || '').slice(0, 1)}</span>
                                </div>
                            );
                        })}
                    </div>

                    <button
                        type="button"
                        style={estilos.btnPomodoro}
                        onClick={() => onNavegar?.('dashboard')}
                    >
                        ▶ Iniciar Pomodoro
                    </button>
                </div>
            </section>

            <section style={estilos.cardApuntes}>
                <div style={estilos.headerApuntes}>
                    <div>
                        <h2 style={estilos.tituloSeccion}>Apuntes Recientes</h2>
                        <p style={estilos.descripcion}>Tus últimos resúmenes de estudio.</p>
                    </div>

                    <button
                        type="button"
                        style={estilos.btnTexto}
                        onClick={() => onNavegar?.('materias')}
                    >
                        Ver todos los apuntes →
                    </button>
                </div>

                {apuntesRecientes.length === 0 ? (
                    <p style={estilos.estadoVacio}>Todavía no hay apuntes modificados.</p>
                ) : (
                    <div style={estilos.gridApuntes}>
                        {apuntesRecientes.map((apunte, index) => (
                            <button
                                key={obtenerIdApunte(apunte) || index}
                                type="button"
                                style={estilos.tarjetaApunte}
                                onClick={() => abrirApunte(apunte)}
                            >
                                <div style={estilos.apunteMeta}>
                                    <span style={estilos.badgeMateria}>{apunte.nombreMateria || 'Materia'}</span>
                                    <span style={estilos.fechaApunte}>{formatearTiempoRelativo(obtenerFechaModificacion(apunte))}</span>
                                </div>

                                <h3 style={estilos.tituloApunte}>{obtenerTituloApunte(apunte)}</h3>
                                <p style={estilos.descripcionApunte}>
                                    {convertirHtmlATexto(obtenerContenidoApunte(apunte)).slice(0, 120) || 'Sin contenido disponible.'}
                                </p>
                            </button>
                        ))}
                    </div>
                )}
            </section>

            {mostrarModalMateria && (
                <div style={estilos.overlayModal}>
                    <div
                        style={estilos.modal}
                        ref={modalMateriaRef}
                        onClick={(event) => event.stopPropagation()}
                    >
                        <h3 style={estilos.tituloModal}>Nueva Materia</h3>

                        <form onSubmit={manejarCrearMateria} style={estilos.formulario}>
                            <input
                                ref={inputNombreMateriaRef}
                                type="text"
                                placeholder="Nombre de la materia"
                                value={nuevaMateria.nombreMateria}
                                onChange={(event) => setNuevaMateria({
                                    ...nuevaMateria,
                                    nombreMateria: event.target.value
                                })}
                                style={estilos.input}
                            />

                            <textarea
                                placeholder="Breve descripción..."
                                value={nuevaMateria.descripcion}
                                onChange={(event) => setNuevaMateria({
                                    ...nuevaMateria,
                                    descripcion: event.target.value
                                })}
                                style={estilos.textarea}
                            />

                            <div style={estilos.accionesModal}>
                                <button
                                    type="button"
                                    style={estilos.btnCancelar}
                                    onClick={cerrarModalMateria}
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
        </div>
    );
};

const estilos = {
    contenedor: {
        height: '100%',
        overflowY: 'auto',
        padding: '48px',
        backgroundColor: '#F6F8FE',
        color: '#2D3247'
    },
    hero: {
        marginBottom: '36px'
    },
    titulo: {
        margin: 0,
        fontSize: '2.8rem',
        lineHeight: 1.08,
        fontWeight: 900,
        color: '#2B3437'
    },
    subtitulo: {
        margin: '10px 0 0 0',
        fontSize: '1rem',
        color: '#586064'
    },
    gridPrincipal: {
        display: 'grid',
        gridTemplateColumns: 'minmax(0, 2fr) minmax(280px, 0.9fr)',
        gap: '28px',
        alignItems: 'stretch'
    },
    cardMaterias: {
        backgroundColor: 'white',
        borderRadius: '18px',
        padding: '32px',
        boxShadow: '0 20px 40px rgba(63, 95, 146, 0.06)'
    },
    cardPomodoro: {
        backgroundColor: 'white',
        borderRadius: '18px',
        padding: '32px',
        boxShadow: '0 20px 40px rgba(63, 95, 146, 0.06)',
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'space-between'
    },
    cardHeader: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'flex-start',
        gap: '20px',
        marginBottom: '28px'
    },
    cardHeaderCompacto: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'flex-start',
        marginBottom: '24px'
    },
    badge: {
        display: 'inline-block',
        padding: '6px 14px',
        borderRadius: '999px',
        backgroundColor: '#D6E3FF',
        color: '#315284',
        textTransform: 'uppercase',
        letterSpacing: '0.12em',
        fontSize: '0.65rem',
        fontWeight: 900,
        marginBottom: '14px'
    },
    tituloSeccion: {
        margin: 0,
        fontSize: '1.8rem',
        color: '#2B3437',
        fontWeight: 900
    },
    tituloCardChico: {
        margin: 0,
        fontSize: '1rem',
        color: '#2B3437',
        fontWeight: 900
    },
    descripcion: {
        margin: '6px 0 0 0',
        color: '#586064'
    },
    descripcionChica: {
        margin: '4px 0 0 0',
        color: '#8A93A5',
        fontSize: '0.78rem'
    },
    btnPrimario: {
        border: 'none',
        backgroundColor: '#3A5A82',
        color: 'white',
        borderRadius: '12px',
        padding: '13px 18px',
        display: 'flex',
        alignItems: 'center',
        gap: '8px',
        cursor: 'pointer',
        fontWeight: 900
    },
    iconoBtn: {
        fontSize: '1.2rem',
        lineHeight: 1
    },
    gridMaterias: {
        display: 'grid',
        gridTemplateColumns: 'repeat(auto-fit, minmax(210px, 1fr))',
        gap: '16px'
    },
    tarjetaMateria: {
        position: 'relative',
        textAlign: 'left',
        minHeight: '140px',
        border: '1px solid #DBE4E7',
        backgroundColor: '#F8F9FA',
        borderRadius: '16px',
        padding: '20px',
        cursor: 'pointer'
    },
    iconoMateria: {
        width: '40px',
        height: '40px',
        borderRadius: '10px',
        backgroundColor: '#D6E3FF',
        color: '#315284',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
        fontWeight: 900,
        marginBottom: '16px'
    },
    nombreMateria: {
        margin: 0,
        color: '#2B3437',
        fontSize: '1.05rem',
        fontWeight: 900
    },
    descripcionMateria: {
        margin: '8px 0 0 0',
        color: '#586064',
        fontSize: '0.82rem',
        lineHeight: 1.4
    },
    totalHoras: {
        color: '#3A5A82',
        fontSize: '1.5rem',
        fontWeight: 900
    },
    barras: {
        height: '150px',
        display: 'flex',
        alignItems: 'flex-end',
        gap: '10px',
        marginBottom: '24px'
    },
    columnaBarra: {
        flex: 1,
        height: '100%',
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'flex-end',
        alignItems: 'center',
        gap: '8px'
    },
    barra: {
        width: '100%',
        borderRadius: '8px 8px 0 0',
        backgroundColor: '#D6E3FF'
    },
    barraActiva: {
        backgroundColor: '#3A5A82'
    },
    labelDia: {
        color: '#8A93A5',
        fontSize: '0.65rem',
        fontWeight: 900
    },
    btnPomodoro: {
        width: '100%',
        border: 'none',
        backgroundColor: '#3A5A82',
        color: 'white',
        borderRadius: '12px',
        padding: '14px',
        cursor: 'pointer',
        fontWeight: 900
    },
    cardApuntes: {
        marginTop: '28px',
        backgroundColor: '#EAEFF1',
        borderRadius: '18px',
        padding: '32px'
    },
    headerApuntes: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'flex-end',
        gap: '20px',
        marginBottom: '26px'
    },
    btnTexto: {
        border: 'none',
        background: 'none',
        color: '#3A5A82',
        cursor: 'pointer',
        fontWeight: 900
    },
    gridApuntes: {
        display: 'grid',
        gridTemplateColumns: 'repeat(auto-fit, minmax(240px, 1fr))',
        gap: '20px'
    },
    tarjetaApunte: {
        border: '1px solid transparent',
        backgroundColor: 'white',
        borderRadius: '14px',
        padding: '22px',
        textAlign: 'left',
        cursor: 'pointer',
        minHeight: '170px'
    },
    apunteMeta: {
        display: 'flex',
        justifyContent: 'space-between',
        gap: '12px',
        marginBottom: '16px'
    },
    badgeMateria: {
        backgroundColor: '#D6E3FF',
        color: '#315284',
        borderRadius: '5px',
        padding: '5px 8px',
        fontSize: '0.64rem',
        textTransform: 'uppercase',
        fontWeight: 900,
        maxWidth: '130px',
        overflow: 'hidden',
        textOverflow: 'ellipsis',
        whiteSpace: 'nowrap'
    },
    fechaApunte: {
        color: '#8A93A5',
        fontSize: '0.7rem',
        fontWeight: 700,
        whiteSpace: 'nowrap'
    },
    tituloApunte: {
        margin: '0 0 10px 0',
        color: '#2B3437',
        fontSize: '1rem',
        fontWeight: 900
    },
    descripcionApunte: {
        margin: 0,
        color: '#586064',
        fontSize: '0.82rem',
        lineHeight: 1.5
    },
    estadoVacio: {
        margin: 0,
        color: '#6A7185',
        backgroundColor: '#F8F9FA',
        borderRadius: '12px',
        padding: '18px'
    },
    overlayModal: {
        position: 'fixed',
        inset: 0,
        backgroundColor: 'rgba(45, 50, 71, 0.55)',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        zIndex: 2000
    },
    modal: {
        width: '430px',
        maxWidth: 'calc(100vw - 32px)',
        backgroundColor: 'white',
        borderRadius: '18px',
        padding: '30px',
        boxShadow: '0 18px 45px rgba(0,0,0,0.22)'
    },
    tituloModal: {
        margin: '0 0 20px 0',
        color: '#2D3247',
        fontSize: '1.25rem',
        fontWeight: 900
    },
    formulario: {
        display: 'flex',
        flexDirection: 'column',
        gap: '14px'
    },
    input: {
        border: '1px solid #DBE4E7',
        borderRadius: '10px',
        padding: '12px 14px',
        fontSize: '0.95rem',
        outline: 'none'
    },
    textarea: {
        border: '1px solid #DBE4E7',
        borderRadius: '10px',
        padding: '12px 14px',
        fontSize: '0.95rem',
        minHeight: '100px',
        resize: 'vertical',
        outline: 'none'
    },
    accionesModal: {
        display: 'flex',
        justifyContent: 'flex-end',
        gap: '10px',
        marginTop: '8px'
    },
    btnCancelar: {
        border: '1px solid #DBE4E7',
        backgroundColor: 'white',
        color: '#586064',
        borderRadius: '9px',
        padding: '10px 16px',
        cursor: 'pointer',
        fontWeight: 800
    },
    btnGuardar: {
        border: 'none',
        backgroundColor: '#3A5A82',
        color: 'white',
        borderRadius: '9px',
        padding: '10px 18px',
        cursor: 'pointer',
        fontWeight: 900
    }
};

export default MenuDashboard;
