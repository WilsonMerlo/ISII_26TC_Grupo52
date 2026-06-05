import React, { useEffect, useMemo, useState } from 'react';
import GraficoBarrasSemana from '../components/estadisticas/GraficoBarrasSemana';
import GraficoTortaMaterias from '../components/estadisticas/GraficoTortaMaterias';
import SelectorSemana from '../components/estadisticas/SelectorSemana';
import { estadisticaService } from '../services/estadisticaService';

const inicioDeSemana = (fecha) => {
    const nueva = new Date(fecha);
    const dia = nueva.getDay();
    const diferencia = dia === 0 ? -6 : 1 - dia;

    nueva.setDate(nueva.getDate() + diferencia);
    nueva.setHours(0, 0, 0, 0);

    return nueva;
};

const finDeSemana = (fecha) => {
    const inicio = inicioDeSemana(fecha);
    const fin = new Date(inicio);

    fin.setDate(inicio.getDate() + 6);
    fin.setHours(23, 59, 59, 999);

    return fin;
};

const formatearTotal = (minutos) => {
    const h = Math.floor(minutos / 60);
    const m = minutos % 60;

    return `${h}h ${String(m).padStart(2, '0')}min`;
};

const EstadisticasDashboard = () => {
    const [semanaSeleccionada, setSemanaSeleccionada] = useState(() => {
        const hoy = new Date();

        return {
            inicio: inicioDeSemana(hoy),
            fin: finDeSemana(hoy)
        };
    });

    const [datos, setDatos] = useState({
        totalSemanaMinutos: 0,
        porDia: [],
        porMateria: []
    });

    const [cargando, setCargando] = useState(true);

    useEffect(() => {
        const cargarDatos = async () => {
            try {
                setCargando(true);

                const resultado = await estadisticaService.obtenerEstadisticasSemana({
                    fechaInicio: semanaSeleccionada.inicio.toISOString(),
                    fechaFin: semanaSeleccionada.fin.toISOString()
                });

                setDatos(resultado);
            } catch (error) {
                console.error('Error cargando estadísticas:', error);
            } finally {
                setCargando(false);
            }
        };

        cargarDatos();
    }, [semanaSeleccionada]);

    const rangoSemana = useMemo(() => {
        return `${semanaSeleccionada.inicio.toLocaleDateString('es-AR', {
            day: '2-digit',
            month: '2-digit'
        })} - ${semanaSeleccionada.fin.toLocaleDateString('es-AR', {
            day: '2-digit',
            month: '2-digit',
            year: '2-digit'
        })}`;
    }, [semanaSeleccionada]);

    return (
        <div style={estilos.contenedor}>
            <section style={estilos.header}>
                <div>
                    <h1 style={estilos.titulo}>Estadísticas de Estudio</h1>
                    <p style={estilos.subtitulo}>
                        Mide tu progreso y optimiza tus periodos de enfoque profundo.
                    </p>
                </div>
            </section>

            <section style={estilos.cardPrincipal}>
                <div style={estilos.cardHeader}>
                    <div>
                        <div style={estilos.totalSemana}>
                            {cargando ? 'Cargando...' : formatearTotal(datos.totalSemanaMinutos)}
                        </div>
                        <p style={estilos.labelSemana}>Semana seleccionada · {rangoSemana}</p>
                    </div>

                    <SelectorSemana
                        semanaSeleccionada={semanaSeleccionada}
                        onAplicar={setSemanaSeleccionada}
                    />
                </div>

                <GraficoBarrasSemana datos={datos.porDia} />
            </section>

            <GraficoTortaMaterias datos={datos.porMateria} />
        </div>
    );
};

const estilos = {
    contenedor: {
        padding: 'clamp(22px, 4vw, 48px)',
        width: '100%',
        boxSizing: 'border-box',
        backgroundColor: '#F1F4F6',
        minHeight: '100%',
        overflowX: 'hidden'
    },
    header: {
        marginBottom: 'clamp(26px, 4vw, 38px)'
    },
    titulo: {
        margin: 0,
        color: '#2B3437',
        fontSize: 'clamp(2rem, 5vw, 3rem)',
        lineHeight: 1.05,
        fontWeight: 900,
        letterSpacing: '-0.04em'
    },
    subtitulo: {
        margin: '12px 0 0',
        color: '#586064',
        fontSize: 'clamp(0.95rem, 2vw, 1.15rem)'
    },
    cardPrincipal: {
        backgroundColor: 'white',
        borderRadius: '18px',
        border: '1px solid #E8EBFF',
        boxShadow: '0 4px 12px rgba(58, 86, 175, 0.05)',
        padding: 'clamp(22px, 4vw, 42px)'
    },
    cardHeader: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'flex-start',
        gap: '24px',
        marginBottom: '18px',
        flexWrap: 'wrap'
    },
    totalSemana: {
        color: '#3A5A82',
        fontSize: 'clamp(2rem, 5vw, 3rem)',
        lineHeight: 1,
        fontWeight: 900,
        letterSpacing: '-0.05em'
    },
    labelSemana: {
        margin: '8px 0 0',
        color: '#586064',
        textTransform: 'uppercase',
        letterSpacing: '0.12em',
        fontSize: 'clamp(0.62rem, 1.2vw, 0.72rem)',
        fontWeight: 800
    }
};

export default EstadisticasDashboard;
