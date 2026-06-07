import React from 'react';

const formatearHoras = (minutos) => {
    const total = Math.max(0, Math.round(Number(minutos) || 0));
    const h = Math.floor(total / 60);
    const m = total % 60;

    if (h === 0) return `${m}min`;
    if (m === 0) return `${h}h`;

    return `${h}h ${m}min`;
};

const GraficoBarrasSemana = ({ datos = [], maxEscalaMinutos }) => {
    const maxDatos = Math.max(...datos.map((d) => Number(d.minutos) || 0), 0);
    const maxEscala = Math.max(Number(maxEscalaMinutos) || maxDatos || 1, 1);

    return (
        <div style={estilos.wrapper}>
            <div style={estilos.areaGrafico}>
                <div style={estilos.barras}>
                    {datos.map((item) => {
                        const minutos = Number(item.minutos) || 0;
                        const altura = minutos > 0
                            ? Math.min(100, Math.max(6, (minutos / maxEscala) * 100))
                            : 0;

                        return (
                            <div key={item.fecha || item.dia} style={estilos.columna}>
                                <div style={estilos.track}>
                                    <div
                                        title={`${item.dia}: ${formatearHoras(minutos)}`}
                                        style={{
                                            ...estilos.barra,
                                            height: `${altura}%`
                                        }}
                                    />
                                </div>

                                <span style={estilos.dia}>{item.dia}</span>
                                <span style={estilos.valorDia}>{formatearHoras(minutos)}</span>
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
        gridTemplateColumns: '1fr',
        width: '100%',
        height: 'clamp(280px, 38vw, 380px)',
        marginTop: 'clamp(20px, 4vw, 30px)'
    },
    areaGrafico: {
        position: 'relative',
        height: '100%',
        paddingTop: '14px',
        minWidth: 0
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
        gap: 'clamp(5px, 1vw, 8px)',
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
    },
    valorDia: {
        color: '#8B95A7',
        fontSize: 'clamp(0.58rem, 1vw, 0.72rem)',
        fontWeight: 700,
        whiteSpace: 'nowrap'
    }
};

export default GraficoBarrasSemana;
