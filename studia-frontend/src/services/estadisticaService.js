const minutos = (h, m = 0) => h * 60 + m;

export const estadisticaService = {
    obtenerEstadisticasSemana: async ({ fechaInicio, fechaFin } = {}) => {
        // Datos mock. Después se reemplaza por fetch al backend.
        return {
            fechaInicio,
            fechaFin,
            totalSemanaMinutos: minutos(18, 30),

            porDia: [
                { dia: 'LUN', fecha: '2026-06-02', minutos: minutos(2, 30) },
                { dia: 'MAR', fecha: '2026-06-03', minutos: minutos(4, 10) },
                { dia: 'MIÉ', fecha: '2026-06-04', minutos: minutos(1, 45) },
                { dia: 'JUE', fecha: '2026-06-05', minutos: minutos(3, 30) },
                { dia: 'VIE', fecha: '2026-06-06', minutos: minutos(5, 5) },
                { dia: 'SÁB', fecha: '2026-06-07', minutos: minutos(1, 15) },
                { dia: 'DOM', fecha: '2026-06-08', minutos: minutos(0, 15) },
            ],

            porMateria: [
                { materia: 'Cálculo', minutos: minutos(7, 30) },
                { materia: 'Estadística', minutos: minutos(5, 15) },
                { materia: 'Álgebra', minutos: minutos(3, 45) },
                { materia: 'Programación', minutos: minutos(2, 0) },
            ]
        };
    }
};