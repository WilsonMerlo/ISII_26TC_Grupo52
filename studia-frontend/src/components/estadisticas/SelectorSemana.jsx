import React, { useMemo, useState } from 'react';

const meses = [
    'Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio',
    'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'
];

const diasCortos = ['LU', 'MA', 'MI', 'JU', 'VI', 'SA', 'DO'];

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

const mismoDia = (a, b) => {
    return (
        a.getFullYear() === b.getFullYear() &&
        a.getMonth() === b.getMonth() &&
        a.getDate() === b.getDate()
    );
};

const estaEntre = (fecha, inicio, fin) => {
    return fecha >= inicio && fecha <= fin;
};

const formatearRango = (inicio, fin) => {
    const opciones = { day: 'numeric', month: 'short' };

    return `${inicio.toLocaleDateString('es-AR', opciones)} - ${fin.toLocaleDateString('es-AR', {
        ...opciones,
        year: 'numeric'
    })}`;
};

const SelectorSemana = ({ semanaSeleccionada, onAplicar }) => {
    const [abierto, setAbierto] = useState(false);
    const [mesVisible, setMesVisible] = useState(() => new Date(semanaSeleccionada?.inicio || new Date()));
    const [fechaTemporal, setFechaTemporal] = useState(() => new Date(semanaSeleccionada?.inicio || new Date()));

    const hoy = new Date();
    hoy.setHours(23, 59, 59, 999);

    const semanaTemporal = useMemo(() => {
        const inicio = inicioDeSemana(fechaTemporal);
        const fin = finDeSemana(fechaTemporal);

        return { inicio, fin };
    }, [fechaTemporal]);

    const diasCalendario = useMemo(() => {
        const anio = mesVisible.getFullYear();
        const mes = mesVisible.getMonth();

        const primerDiaMes = new Date(anio, mes, 1);
        const offset = primerDiaMes.getDay() === 0 ? 6 : primerDiaMes.getDay() - 1;

        const primerDiaGrilla = new Date(primerDiaMes);
        primerDiaGrilla.setDate(primerDiaMes.getDate() - offset);

        return Array.from({ length: 35 }, (_, index) => {
            const fecha = new Date(primerDiaGrilla);
            fecha.setDate(primerDiaGrilla.getDate() + index);

            return fecha;
        });
    }, [mesVisible]);

    const esMesActual = () => {
        const actual = new Date();

        return (
            mesVisible.getFullYear() === actual.getFullYear() &&
            mesVisible.getMonth() === actual.getMonth()
        );
    };

    const cambiarMes = (cantidad) => {
        setMesVisible((actual) => {
            const nuevo = new Date(actual);
            nuevo.setMonth(actual.getMonth() + cantidad);
            return nuevo;
        });
    };

    const irAHoy = () => {
        const hoyActual = new Date();

        setMesVisible(hoyActual);
        setFechaTemporal(hoyActual);
    };

    const aplicarSemana = () => {
        onAplicar?.(semanaTemporal);
        setAbierto(false);
    };

    return (
        <div style={estilos.wrapper}>
            <button style={estilos.boton} onClick={() => setAbierto(!abierto)}>
                <span className="material-symbols-outlined" style={estilos.icono}>calendar_today</span>
                Seleccionar semana
                <span className="material-symbols-outlined" style={estilos.icono}>expand_more</span>
            </button>

            {abierto && (
                <div style={estilos.popover}>
                    <div style={estilos.headerCalendario}>
                        <h3 style={estilos.mesTitulo}>
                            {meses[mesVisible.getMonth()]} {mesVisible.getFullYear()}
                        </h3>

                        <div style={estilos.navMes}>
                            <button type="button" style={estilos.btnHoy} onClick={irAHoy}>
                                Hoy
                            </button>

                            <button type="button" style={estilos.btnMes} onClick={() => cambiarMes(-1)}>
                                ‹
                            </button>

                            <button
                                type="button"
                                style={{
                                    ...estilos.btnMes,
                                    ...(esMesActual() ? estilos.btnMesDeshabilitado : {})
                                }}
                                disabled={esMesActual()}
                                onClick={() => cambiarMes(1)}
                            >
                                ›
                            </button>
                        </div>
                    </div>

                    <div style={estilos.gridDias}>
                        {diasCortos.map((dia) => (
                            <div key={dia} style={estilos.diaHeader}>{dia}</div>
                        ))}

                        {diasCalendario.map((fecha) => {
                            const fueraDeMes = fecha.getMonth() !== mesVisible.getMonth();
                            const esHoy = mismoDia(fecha, hoy);
                            const esInicio = mismoDia(fecha, semanaTemporal.inicio);
                            const esFin = mismoDia(fecha, semanaTemporal.fin);
                            const enRango = estaEntre(fecha, semanaTemporal.inicio, semanaTemporal.fin);
                            const esFuturo = fecha > hoy;

                            return (
                                <button
                                    key={fecha.toISOString()}
                                    type="button"
                                    disabled={esFuturo}
                                    style={{
                                        ...estilos.diaBoton,
                                        ...(fueraDeMes ? estilos.fueraMes : {}),
                                        ...(esHoy ? estilos.diaHoy : {}),
                                        ...(enRango ? estilos.diaEnRango : {}),
                                        ...(esInicio || esFin ? estilos.diaExtremo : {}),
                                        ...(esFuturo ? estilos.diaDeshabilitado : {})
                                    }}
                                    onClick={() => !esFuturo && setFechaTemporal(fecha)}
                                >
                                    {fecha.getDate()}
                                </button>
                            );
                        })}
                    </div>

                    <div style={estilos.footer}>
                        <p style={estilos.labelSemana}>Semana seleccionada</p>
                        <strong style={estilos.rango}>
                            {formatearRango(semanaTemporal.inicio, semanaTemporal.fin)}
                        </strong>

                        <div style={estilos.acciones}>
                            <button style={estilos.btnAplicar} onClick={aplicarSemana}>
                                Aplicar
                            </button>

                            <button style={estilos.btnCancelar} onClick={() => setAbierto(false)}>
                                Cancelar
                            </button>
                        </div>
                    </div>
                </div>
            )}
        </div>
    );
};

const estilos = {
    wrapper: {
        position: 'relative'
    },
    boton: {
        display: 'flex',
        alignItems: 'center',
        gap: '10px',
        backgroundColor: '#F1F4F6',
        color: '#2B3437',
        border: '1px solid rgba(171, 179, 183, 0.25)',
        padding: '12px 18px',
        borderRadius: '12px',
        fontWeight: 700,
        cursor: 'pointer'
    },
    icono: {
        fontSize: '20px',
        color: '#3A5A82'
    },
    popover: {
        position: 'absolute',
        right: 0,
        top: 'calc(100% + 14px)',
        width: '380px',
        backgroundColor: 'white',
        borderRadius: '18px',
        boxShadow: '0 18px 45px rgba(45, 50, 71, 0.18)',
        border: '1px solid #E3E9EC',
        padding: '24px',
        zIndex: 100
    },
    headerCalendario: {
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        marginBottom: '18px',
        gap: '12px'
    },
    mesTitulo: {
        margin: 0,
        color: '#2B3437',
        fontSize: '1.15rem'
    },
    navMes: {
        display: 'flex',
        alignItems: 'center',
        gap: '8px'
    },
    btnHoy: {
        height: '32px',
        border: '1px solid #DDE5F4',
        backgroundColor: '#F6F8FE',
        borderRadius: '8px',
        cursor: 'pointer',
        color: '#3A5A82',
        fontWeight: 800,
        padding: '0 12px'
    },
    btnMes: {
        width: '32px',
        height: '32px',
        border: 'none',
        backgroundColor: 'transparent',
        borderRadius: '8px',
        cursor: 'pointer',
        fontSize: '1.5rem',
        color: '#2B3437'
    },
    btnMesDeshabilitado: {
        opacity: 0.35,
        cursor: 'not-allowed'
    },
    gridDias: {
        display: 'grid',
        gridTemplateColumns: 'repeat(7, 1fr)',
        gap: '4px',
        textAlign: 'center'
    },
    diaHeader: {
        color: '#9EA5BA',
        fontSize: '0.75rem',
        fontWeight: 800,
        padding: '8px 0'
    },
    diaBoton: {
        height: '40px',
        border: 'none',
        backgroundColor: 'transparent',
        color: '#2B3437',
        borderRadius: '10px',
        cursor: 'pointer',
        fontWeight: 600
    },
    diaHoy: {
        boxShadow: 'inset 0 0 0 2px #3A5A82'
    },
    diaEnRango: {
        backgroundColor: '#F1F4F6'
    },
    diaExtremo: {
        backgroundColor: '#3A5A82',
        color: 'white',
        boxShadow: '0 4px 10px rgba(58, 90, 130, 0.25)'
    },
    fueraMes: {
        color: '#C8D0D6',
        opacity: 0.7
    },
    diaDeshabilitado: {
        opacity: 0.35,
        cursor: 'not-allowed',
        pointerEvents: 'none'
    },
    footer: {
        borderTop: '1px solid #E3E9EC',
        marginTop: '24px',
        paddingTop: '22px'
    },
    labelSemana: {
        color: '#9EA5BA',
        textTransform: 'uppercase',
        letterSpacing: '0.12em',
        fontSize: '0.72rem',
        fontWeight: 800,
        margin: '0 0 6px 0'
    },
    rango: {
        display: 'block',
        color: '#2B3437',
        marginBottom: '18px',
        fontSize: '1.05rem'
    },
    acciones: {
        display: 'flex',
        gap: '12px'
    },
    btnAplicar: {
        flex: 1,
        backgroundColor: '#3A5A82',
        color: 'white',
        border: 'none',
        borderRadius: '10px',
        padding: '12px',
        fontWeight: 800,
        cursor: 'pointer'
    },
    btnCancelar: {
        flex: 1,
        backgroundColor: 'white',
        color: '#2B3437',
        border: '1px solid #E3E9EC',
        borderRadius: '10px',
        padding: '12px',
        fontWeight: 800,
        cursor: 'pointer'
    }
};

export default SelectorSemana;