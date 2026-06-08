export const obtenerFechaLocalISO = () => {
    const fecha = new Date();
    const offset = fecha.getTimezoneOffset();
    const fechaLocal = new Date(fecha.getTime() - offset * 60000);

    return fechaLocal.toISOString().slice(0, 19);
};