import React from 'react';

const colores = ['#3A5A82', '#536073', '#5B5D78', '#7A8FB5', '#A7B7D7', '#C8D5EB'];

const formatearHoras = (minutos) => {
    const h = Math.floor(minutos / 60);
    const m = minutos % 60;

    if (h === 0) return `${m}min`;
    if (m === 0) return `${h}h`;

    return `${h}h ${m}min`;
};

const crearSegmentos = (datos, total) => {
    let acumulado = 0;
    const radio = 40;
    const circunferencia = 2 * Math.PI * radio;

    return datos.map((item, index) => {
        const porcentaje = total > 0 ? item.minutos / total : 0;
        const longitud = porcentaje * circunferencia;
        const segmento = {
            ...item,
            color: colores[index % colores.length],
            porcentaje,
            dashArray: `${longitud} ${circunferencia - longitud}`,
            dashOffset: -acumulado
        };

        acumulado += longitud;
        return segmento;
    });
};

const GraficoTortaMaterias = ({ datos = [] }) => {
    const total = datos.reduce((acc, item) => acc + item.minutos, 0);
    const segmentos = crearSegmentos(datos, total);

    return (
        <section style={estilos.card}>
            <div style={estilos.header}>
                <h3 style={estilos.titulo}>Distribución por Materia</h3>
                <p style={estilos.subtitulo}>Porcentaje de tiempo dedicado a cada materia.</p>
            </div>

            {datos.length === 0 || total === 0 ? (
                <div style={estilos.vacio}>Todavía no hay datos para mostrar.</div>
            ) : (
                <div style={estilos.contenido}>
                    <div style={estilos.donutWrap}>
                        <svg viewBox="0 0 100 100" style={estilos.svg}>
                            <circle
                                cx="50"
                                cy="50"
                                r="40"
                                fill="transparent"
                                stroke="#E3E9EC"
                                strokeWidth="12"
                            />

                            {segmentos.map((segmento, index) => (
                                <circle
                                    key={`${segmento.materia}-${index}`}
                                    cx="50"
                                    cy="50"
                                    r="40"
                                    fill="transparent"
                                    stroke={segmento.color}
                                    strokeWidth="12"
                                    strokeDasharray={segmento.dashArray}
                                    strokeDashoffset={segmento.dashOffset}
                                    strokeLinecap="round"
                                    transform="rotate(-90 50 50)"
                                />
                            ))}
                        </svg>

                        <div style={estilos.centroDonut}>
                            <strong style={estilos.total}>{formatearHoras(total)}</strong>
                            <span style={estilos.totalLabel}>Total</span>
                        </div>
                    </div>

                    <div style={estilos.leyenda}>
                        {segmentos.map((item, index) => (
                            <div key={`${item.materia}-${index}`} style={estilos.itemLeyenda}>
                                <div style={estilos.infoMateria}>
                                    <span style={{ ...estilos.punto, backgroundColor: item.color }} />
                                    <span style={estilos.nombreMateria}>{item.materia}</span>
                                </div>

                                <div style={estilos.valores}>
                                    <strong>{Math.round(item.porcentaje * 100)}%</strong>
                                    <span>{formatearHoras(item.minutos)}</span>
                                </div>
                            </div>
                        ))}
                    </div>
                </div>
            )}
        </section>
    );
};

const estilos = {
    card: {
        backgroundColor: 'white',
        borderRadius: '18px',
        border: '1px solid #E8EBFF',
        boxShadow: '0 4px 12px rgba(58, 86, 175, 0.05)',
        padding: 'clamp(22px, 4vw, 32px)',
        marginTop: '24px'
    },
    header: {
        marginBottom: 'clamp(20px, 4vw, 28px)'
    },
    titulo: {
        margin: 0,
        color: '#2B3437',
        fontSize: 'clamp(1.1rem, 2.4vw, 1.4rem)',
        fontWeight: 800
    },
    subtitulo: {
        margin: '6px 0 0',
        color: '#586064',
        fontSize: 'clamp(0.85rem, 1.6vw, 1rem)'
    },
    contenido: {
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'space-around',
        gap: 'clamp(24px, 5vw, 40px)',
        flexWrap: 'wrap'
    },
    donutWrap: {
        position: 'relative',
        width: 'clamp(180px, 28vw, 260px)',
        height: 'clamp(180px, 28vw, 260px)',
        flexShrink: 0
    },
    svg: {
        width: '100%',
        height: '100%'
    },
    centroDonut: {
        position: 'absolute',
        inset: 0,
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'center',
        alignItems: 'center',
        textAlign: 'center'
    },
    total: {
        color: '#2B3437',
        fontSize: 'clamp(1.3rem, 3vw, 2rem)'
    },
    totalLabel: {
        color: '#8B95A7',
        textTransform: 'uppercase',
        letterSpacing: '0.12em',
        fontSize: 'clamp(0.6rem, 1vw, 0.7rem)',
        fontWeight: 800
    },
    leyenda: {
        flex: 1,
        minWidth: 'min(100%, 260px)',
        maxWidth: '520px',
        display: 'flex',
        flexDirection: 'column',
        gap: '12px'
    },
    itemLeyenda: {
        backgroundColor: '#F1F4F6',
        borderRadius: '14px',
        padding: 'clamp(12px, 2vw, 14px) clamp(12px, 2vw, 16px)',
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        gap: '16px',
        flexWrap: 'wrap'
    },
    infoMateria: {
        display: 'flex',
        alignItems: 'center',
        gap: '12px'
    },
    punto: {
        width: '12px',
        height: '12px',
        borderRadius: '50%',
        flexShrink: 0
    },
    nombreMateria: {
        color: '#2B3437',
        fontWeight: 700,
        fontSize: 'clamp(0.85rem, 1.4vw, 1rem)'
    },
    valores: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'flex-end',
        color: '#3A5A82',
        fontWeight: 800,
        fontSize: 'clamp(0.8rem, 1.3vw, 0.9rem)'
    },
    vacio: {
        color: '#8B95A7',
        textAlign: 'center',
        padding: '40px'
    }
};

export default GraficoTortaMaterias;
