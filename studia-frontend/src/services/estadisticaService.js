const BASE_URL = import.meta.env.VITE_API_URL || 'https://localhost:7068';
const API_BASE_URL = BASE_URL.endsWith('/api') ? BASE_URL : `${BASE_URL}/api`;

const DIAS_SEMANA = ['LUN', 'MAR', 'MIÉ', 'JUE', 'VIE', 'SÁB', 'DOM'];

const leerRespuesta = async (response) => {
    const contentType = response.headers.get('content-type');

    if (contentType && contentType.includes('application/json')) {
        return response.json();
    }

    return response.text();
};

const inicioDeDia = (fecha) => {
    const nueva = new Date(fecha);
    nueva.setHours(0, 0, 0, 0);
    return nueva;
};

const finDeDia = (fecha) => {
    const nueva = new Date(fecha);
    nueva.setHours(23, 59, 59, 999);
    return nueva;
};

const sumarDias = (fecha, cantidad) => {
    const nueva = new Date(fecha);
    nueva.setDate(nueva.getDate() + cantidad);
    return nueva;
};

const sumarMeses = (fecha, cantidad) => {
    const nueva = new Date(fecha);
    nueva.setMonth(nueva.getMonth() + cantidad);
    return nueva;
};

const inicioDeSemana = (fecha) => {
    const nueva = inicioDeDia(fecha);
    const dia = nueva.getDay();
    const diferencia = dia === 0 ? -6 : 1 - dia;

    nueva.setDate(nueva.getDate() + diferencia);
    return nueva;
};

const finDeSemana = (fecha) => {
    const inicio = inicioDeSemana(fecha);
    return finDeDia(sumarDias(inicio, 6));
};

const inicioDeMes = (fecha) => {
    const nueva = new Date(fecha);
    nueva.setDate(1);
    nueva.setHours(0, 0, 0, 0);
    return nueva;
};

const finDeMes = (fecha) => {
    const nueva = new Date(fecha);
    nueva.setMonth(nueva.getMonth() + 1);
    nueva.setDate(0);
    nueva.setHours(23, 59, 59, 999);
    return nueva;
};

const estaEntre = (fecha, inicio, fin) => {
    const time = fecha.getTime();
    return time >= inicio.getTime() && time <= fin.getTime();
};

const obtenerIdUsuario = (item) => {
    return Number(
        item?.idUsuario ||
        item?.IdUsuario ||
        item?.id_usuario ||
        item?.usuarioId ||
        item?.UsuarioId ||
        0
    );
};

const obtenerIdMateria = (item) => {
    return Number(
        item?.idMateria ||
        item?.IdMateria ||
        item?.id_materia ||
        item?.materiaId ||
        item?.MateriaId ||
        item?.materia?.idMateria ||
        item?.materia?.IdMateria ||
        item?.materia?.id_materia ||
        0
    );
};

const obtenerNombreMateria = (item) => {
    return (
        item?.nombreMateria ||
        item?.NombreMateria ||
        item?.nombre_materia ||
        item?.materiaNombre ||
        item?.MateriaNombre ||
        item?.materia?.nombreMateria ||
        item?.materia?.NombreMateria ||
        item?.materia?.nombre_materia ||
        ''
    );
};

const obtenerFechaPomodoro = (item) => {
    return new Date(
        item?.fecha ||
        item?.Fecha ||
        item?.fechaInicio ||
        item?.FechaInicio ||
        item?.fecha_creacion ||
        item?.fechaCreacion ||
        item?.FechaCreacion ||
        Date.now()
    );
};

const obtenerDuracionEstudioSegundos = (item) => {
    return Math.max(
        0,
        Number(
            item?.duracionEstudio ??
            item?.DuracionEstudio ??
            item?.duracion_estudio ??
            item?.tiempoEstudio ??
            item?.TiempoEstudio ??
            0
        ) || 0
    );
};

const estaCompletado = (item) => {
    const estadoFase = item?.estadoFase ?? item?.EstadoFase ?? item?.estado_fase;

    if (estadoFase === undefined || estadoFase === null) {
        const estado = item?.estado ?? item?.Estado;
        return estado === undefined || estado === null || estado === true;
    }

    if (typeof estadoFase === 'string') {
        return estadoFase.toLowerCase() === 'completado' || estadoFase === '4';
    }

    return Number(estadoFase) === 4;
};

const normalizarMateria = (materia) => {
    const idMateria = obtenerIdMateria(materia);
    const nombre = obtenerNombreMateria(materia);

    return {
        idMateria,
        materia: nombre || (idMateria ? `Materia ${idMateria}` : 'Sin materia')
    };
};

const obtenerPomodorosPorUsuario = async (idUsuario) => {
    const response = await fetch(`${API_BASE_URL}/Pomodoros/usuario/${idUsuario}`);

    if (!response.ok) {
        const errorText = await response.text();
        console.error('Error al obtener pomodoros para estadísticas:', response.status, errorText);
        throw new Error('Error al obtener pomodoros');
    }

    const data = await leerRespuesta(response);
    return Array.isArray(data) ? data : [];
};

const obtenerMateriasDelUsuario = async (idUsuario) => {
    try {
        const response = await fetch(`${API_BASE_URL}/Materias`);

        if (!response.ok) {
            return [];
        }

        const data = await leerRespuesta(response);
        const materias = Array.isArray(data) ? data : [];

        return materias
            .filter((materia) => {
                const materiaIdUsuario = obtenerIdUsuario(materia);

                return !materiaIdUsuario || materiaIdUsuario === Number(idUsuario);
            })
            .map(normalizarMateria)
            .filter((materia) => materia.idMateria || materia.materia);
    } catch (error) {
        console.warn('No se pudieron obtener materias para estadísticas:', error);
        return [];
    }
};

const crearDiasDeSemana = (inicioSemana) => {
    return Array.from({ length: 7 }, (_, index) => {
        const fecha = sumarDias(inicioSemana, index);

        return {
            dia: DIAS_SEMANA[index],
            fecha: fecha.toISOString().slice(0, 10),
            minutos: 0
        };
    });
};

const calcularPorDiaSemana = (sesionesSemana, inicioSemana) => {
    const porDia = crearDiasDeSemana(inicioSemana);

    sesionesSemana.forEach((sesion) => {
        const fecha = obtenerFechaPomodoro(sesion);
        const indice = Math.floor(
            (inicioDeDia(fecha).getTime() - inicioDeDia(inicioSemana).getTime()) / 86400000
        );

        if (indice >= 0 && indice < 7) {
            porDia[indice].minutos += Math.round(obtenerDuracionEstudioSegundos(sesion) / 60);
        }
    });

    return porDia;
};

const calcularPorMateria = (sesionesPeriodo, materiasUsuario) => {
    const acumuladoPorMateria = new Map();

    materiasUsuario.forEach((materia) => {
        const key = materia.idMateria || materia.materia;

        acumuladoPorMateria.set(key, {
            idMateria: materia.idMateria,
            materia: materia.materia,
            minutos: 0
        });
    });

    sesionesPeriodo.forEach((sesion) => {
        const idMateria = obtenerIdMateria(sesion);
        const nombreDesdeSesion = obtenerNombreMateria(sesion);
        const key = idMateria || nombreDesdeSesion || 'Sin materia';

        if (!acumuladoPorMateria.has(key)) {
            acumuladoPorMateria.set(key, {
                idMateria,
                materia: nombreDesdeSesion || (idMateria ? `Materia ${idMateria}` : 'Sin materia'),
                minutos: 0
            });
        }

        const actual = acumuladoPorMateria.get(key);
        actual.minutos += Math.round(obtenerDuracionEstudioSegundos(sesion) / 60);
    });

    return Array.from(acumuladoPorMateria.values()).sort((a, b) => b.minutos - a.minutos);
};

const normalizarTipoPeriodo = (tipoPeriodoMateria, periodoMateria) => {
    const valor = tipoPeriodoMateria || periodoMateria || 'semanas';

    if (valor === 'mes' || valor === 'meses') return 'meses';
    if (valor === 'semana' || valor === 'semanas') return 'semanas';

    return 'semanas';
};

const obtenerRangoPeriodoMateria = ({ tipoPeriodoMateria = 'semanas', indicePeriodoMateria = 0 }) => {
    const indiceSeguro = Math.max(0, Math.floor(Number(indicePeriodoMateria) || 0));
    const hoy = new Date();

    if (tipoPeriodoMateria === 'meses') {
        const indice = Math.min(indiceSeguro, 11);
        const mesObjetivo = sumarMeses(hoy, -indice);

        return {
            inicio: inicioDeMes(mesObjetivo),
            fin: finDeMes(mesObjetivo),
            indicePeriodoMateria: indice
        };
    }

    const indice = Math.min(indiceSeguro, 51);
    const inicioActual = inicioDeSemana(hoy);
    const inicio = sumarDias(inicioActual, -(indice * 7));

    return {
        inicio,
        fin: finDeSemana(inicio),
        indicePeriodoMateria: indice
    };
};

export const estadisticaService = {
    obtenerEstadisticas: async ({
        fechaInicioSemana,
        fechaFinSemana,
        periodoMateria,
        tipoPeriodoMateria = 'semanas',
        indicePeriodoMateria = 0
    } = {}) => {
        const idUsuario = Number(localStorage.getItem('idUsuario'));

        if (!idUsuario) {
            throw new Error('No se encontró el usuario logueado');
        }

        const inicioSemana = inicioDeDia(fechaInicioSemana || new Date());
        const finSemana = finDeDia(fechaFinSemana || sumarDias(inicioSemana, 6));

        const tipoNormalizado = normalizarTipoPeriodo(tipoPeriodoMateria, periodoMateria);
        const rangoPeriodoMateria = obtenerRangoPeriodoMateria({
            tipoPeriodoMateria: tipoNormalizado,
            indicePeriodoMateria
        });

        const [pomodoros, materiasUsuario] = await Promise.all([
            obtenerPomodorosPorUsuario(idUsuario),
            obtenerMateriasDelUsuario(idUsuario)
        ]);

        const sesionesValidas = pomodoros.filter((pomodoro) => {
            const fecha = obtenerFechaPomodoro(pomodoro);
            return estaCompletado(pomodoro) && !Number.isNaN(fecha.getTime());
        });

        const sesionesSemana = sesionesValidas.filter((pomodoro) =>
            estaEntre(obtenerFechaPomodoro(pomodoro), inicioSemana, finSemana)
        );

        const sesionesPeriodoMateria = sesionesValidas.filter((pomodoro) =>
            estaEntre(obtenerFechaPomodoro(pomodoro), rangoPeriodoMateria.inicio, rangoPeriodoMateria.fin)
        );

        const porDia = calcularPorDiaSemana(sesionesSemana, inicioSemana);
        const porMateria = calcularPorMateria(sesionesPeriodoMateria, materiasUsuario);

        const totalSemanaMinutos = porDia.reduce((acc, item) => acc + item.minutos, 0);
        const totalPeriodoMateriaMinutos = porMateria.reduce((acc, item) => acc + item.minutos, 0);

        const maxDiaSemanaMinutos = Math.max(...porDia.map((item) => item.minutos), 0);

        const maxSesionSemanaMinutos = Math.max(
            ...sesionesSemana.map((sesion) =>
                Math.ceil(obtenerDuracionEstudioSegundos(sesion) / 60)
            ),
            0
        );

        return {
            fechaInicioSemana: inicioSemana.toISOString(),
            fechaFinSemana: finSemana.toISOString(),
            fechaInicioPeriodoMateria: rangoPeriodoMateria.inicio.toISOString(),
            fechaFinPeriodoMateria: rangoPeriodoMateria.fin.toISOString(),
            tipoPeriodoMateria: tipoNormalizado,
            indicePeriodoMateria: rangoPeriodoMateria.indicePeriodoMateria,
            totalSemanaMinutos,
            totalPeriodoMateriaMinutos,
            maxEscalaSemanaMinutos: Math.max(maxDiaSemanaMinutos, maxSesionSemanaMinutos, 1),
            porDia,
            porMateria
        };
    },

    obtenerEstadisticasSemana: async ({ fechaInicio, fechaFin } = {}) => {
        return estadisticaService.obtenerEstadisticas({
            fechaInicioSemana: fechaInicio,
            fechaFinSemana: fechaFin,
            tipoPeriodoMateria: 'semanas',
            indicePeriodoMateria: 0
        });
    }
};