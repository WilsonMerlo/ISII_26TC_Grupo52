import React from 'react';

const formatearHoras = (minutos) => {
    const h = Math.floor(minutos / 60);
    const m = minutos % 60;

    if (h === 0) return `${m}min`;
    if (m === 0) return `${h}h`;

    return `${h}h ${m}min`;
};

const GraficoBarrasSemana = ({ datos = [] }) => {
    const maxMinutos = Math.max(...datos.map((d) => d.minutos), 1);
    const maxHorasRedondeado = Math.max(1, Math.ceil(maxMinutos / 60));
    const maxEscalaMinutos = maxHorasRedondeado * 60;

    const marcasY = Array.from({ length: 5 }, (_, index) => {
        const valor = maxEscalaMinutos - (maxEscalaMinutos / 4) * index;
        return Math.round(valor);
    });

    return (
        <div style={estilos.wrapper}>
            <div style={estilos.ejeY}>
                {marcasY.map((minutos, index) => (
                    <span key={index} style={estilos.marcaY}>
                        {formatearHoras(minutos)}
                    </span>
                ))}
            </div>

            <div style={estilos.areaGrafico}>
                <div style={estilos.lineas}>
                    {marcasY.map((_, index) => (
                        <div key={index} style={estilos.linea} />
                    ))}
                </div>

                <div style={estilos.barras}>
                    {datos.map((item) => {
                        const altura = Math.max(6, (item.minutos / maxEscalaMinutos) * 100);

                        return (
                            <div key={item.dia} style={estilos.columna}>
                                <div style={estilos.track}>
                                    <div
                                        title={`${item.dia}: ${formatearHoras(item.minutos)}`}
                                        style={{
                                            ...estilos.barra,
                                            height: `${altura}%`
                                        }}
                                    />
                                </div>

                                <span style={estilos.dia}>{item.dia}</span>
                            </div>
                        );
                    })}
                </div>
            </div>
        </div>
    );
};

const estilos = {
    wrapper: {
        display: 'grid',
        gridTemplateColumns: 'clamp(48px, 7vw, 70px) 1fr',
        gap: 'clamp(10px, 2vw, 18px)',
        width: '100%',
        height: 'clamp(260px, 38vw, 360px)',
        marginTop: 'clamp(20px, 4vw, 30px)'
    },
    ejeY: {
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'space-between',
        alignItems: 'flex-end',
        padding: '14px 0 clamp(32px, 5vw, 42px) 0',
        color: '#8B95A7',
        fontSize: 'clamp(0.65rem, 1vw, 0.78rem)',
        fontWeight: 600
    },
    marcaY: {
        lineHeight: 1,
        whiteSpace: 'nowrap'
    },
    areaGrafico: {
        position: 'relative',
        height: '100%',
        paddingTop: '14px',
        minWidth: 0
    },
    lineas: {
        position: 'absolute',
        left: 0,
        right: 0,
        top: '14px',
        bottom: 'clamp(32px, 5vw, 42px)',
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'space-between',
        zIndex: 1
    },
    linea: {
        borderBottom: '1px solid #E3E9EC'
    },
    barras: {
        position: 'relative',
        zIndex: 2,
        height: '100%',
        display: 'grid',
        gridTemplateColumns: 'repeat(7, minmax(0, 1fr))',
        gap: 'clamp(6px, 2vw, 22px)'
    },
    columna: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'flex-end',
        gap: 'clamp(8px, 2vw, 16px)',
        minWidth: 0
    },
    track: {
        width: 'clamp(28px, 5vw, 64px)',
        height: 'clamp(170px, 26vw, 260px)',
        backgroundColor: '#EEF3FB',
        borderRadius: 'clamp(8px, 1.5vw, 14px)',
        display: 'flex',
        alignItems: 'flex-end',
        overflow: 'hidden'
    },
    barra: {
        width: '100%',
        backgroundColor: '#3A5A82',
        borderRadius: 'clamp(8px, 1.5vw, 12px)',
        transition: 'height 0.25s ease'
    },
    dia: {
        color: '#465365',
        fontSize: 'clamp(0.65rem, 1.2vw, 0.85rem)',
        fontWeight: 800,
        letterSpacing: '0.05em',
        whiteSpace: 'nowrap'
    }
};

export default GraficoBarrasSemana;
