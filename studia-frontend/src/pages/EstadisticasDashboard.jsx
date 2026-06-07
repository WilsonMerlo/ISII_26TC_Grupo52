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
    const total = Math.max(0, Math.round(Number(minutos) || 0));
    const h = Math.floor(total / 60);
    const m = total % 60;

    if (h === 0) return `${m}min`;
    if (m === 0) return `${h}h`;

    return `${h}h ${m}min`;
};

const formatearRango = (inicio, fin) => {
    if (!inicio || !fin) return '';

    const inicioDate = new Date(inicio);
    const finDate = new Date(fin);

    const inicioTexto = inicioDate.toLocaleDateString('es-AR', {
        day: 'numeric',
        month: 'numeric'
    });

    const finTexto = finDate.toLocaleDateString('es-AR', {
        day: '2-digit',
        month: '2-digit',
        year: '2-digit'
    });

    return `${inicioTexto} - ${finTexto}`;
};

const EstadisticasDashboard = () => {
    const [semanaSeleccionada, setSemanaSeleccionada] = useState(() => {
        const hoy = new Date();

        return {
            inicio: inicioDeSemana(hoy),
            fin: finDeSemana(hoy)
        };
    });

    const [tipoPeriodoMateria, setTipoPeriodoMateria] = useState('semanas');
    const [indicePeriodoMateria, setIndicePeriodoMateria] = useState(0);

    const [datos, setDatos] = useState({
        totalSemanaMinutos: 0,
        totalPeriodoMateriaMinutos: 0,
        maxEscalaSemanaMinutos: 1,
        porDia: [],
        porMateria: []
    });

    const [cargando, setCargando] = useState(true);

    const maxPeriodosMateria = tipoPeriodoMateria === 'meses' ? 12 : 52;

    useEffect(() => {
        const cargarDatos = async () => {
            try {
                setCargando(true);

                const resultado = await estadisticaService.obtenerEstadisticas({
                    fechaInicioSemana: semanaSeleccionada.inicio.toISOString(),
                    fechaFinSemana: semanaSeleccionada.fin.toISOString(),
                    tipoPeriodoMateria,
                    indicePeriodoMateria
                });

                setDatos(resultado);
            } catch (error) {
                console.error('Error cargando estadísticas:', error);
            } finally {
                setCargando(false);
            }
        };

        cargarDatos();
    }, [semanaSeleccionada, tipoPeriodoMateria, indicePeriodoMateria]);

    const rangoSemana = useMemo(() => {
        return formatearRango(semanaSeleccionada.inicio, semanaSeleccionada.fin);
    }, [semanaSeleccionada]);

    const rangoPeriodoMateria = useMemo(() => {
        return formatearRango(
            datos.fechaInicioPeriodoMateria,
            datos.fechaFinPeriodoMateria
        );
    }, [datos.fechaInicioPeriodoMateria, datos.fechaFinPeriodoMateria]);

    const cambiarTipoPeriodoMateria = (nuevoTipo) => {
        setTipoPeriodoMateria(nuevoTipo);
        setIndicePeriodoMateria(0);
    };

    const irPeriodoAnteriorMateria = () => {
        setIndicePeriodoMateria((actual) => Math.min(actual + 1, maxPeriodosMateria - 1));
    };

    const irPeriodoSiguienteMateria = () => {
        setIndicePeriodoMateria((actual) => Math.max(actual - 1, 0));
    };

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

                <GraficoBarrasSemana
                    datos={datos.porDia}
                    maxEscalaMinutos={datos.maxEscalaSemanaMinutos}
                />
            </section>

            <GraficoTortaMaterias
                datos={datos.porMateria}
                tipoPeriodo={tipoPeriodoMateria}
                onTipoPeriodoChange={cambiarTipoPeriodoMateria}
                rangoPeriodo={rangoPeriodoMateria}
                totalPeriodoMinutos={datos.totalPeriodoMateriaMinutos}
                cargando={cargando}
                indicePeriodo={indicePeriodoMateria}
                maxPeriodos={maxPeriodosMateria}
                onPeriodoAnterior={irPeriodoAnteriorMateria}
                onPeriodoSiguiente={irPeriodoSiguienteMateria}
            />
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
