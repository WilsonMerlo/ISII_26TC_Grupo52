const API_URL = 'https://localhost:7068/api/Apuntes';

const leerRespuesta = async (response) => {
    const contentType = response.headers.get('content-type');

    if (contentType && contentType.includes('application/json')) {
        return response.json();
    }

    return response.text();
};

const obtenerIdApunte = (apunte) => {
    return apunte?.idApunte || apunte?.IdApunte || apunte?.id_apunte || apunte?.id || apunte?.Id;
};

const obtenerIdMateria = (apunte) => {
    return apunte?.idMateria || apunte?.IdMateria || apunte?.id_materia || apunte?.idMateriaActiva;
};

const obtenerTitulo = (apunte) => {
    return apunte?.titulo || apunte?.Titulo || '';
};

const obtenerContenido = (apunte) => {
    return apunte?.contenido || apunte?.Contenido || '<p><br></p>';
};

const normalizarParaBackend = (apunte) => {
    const idApunte = obtenerIdApunte(apunte);
    const idMateria = Number(obtenerIdMateria(apunte));

    const payload = {
        idMateria,
        titulo: obtenerTitulo(apunte),
        contenido: obtenerContenido(apunte),
        fechaCreacion:
            apunte?.fechaCreacion ||
            apunte?.FechaCreacion ||
            apunte?.fecha_creacion ||
            new Date().toISOString(),
        fechaModificacion:
            apunte?.fechaModificacion ||
            apunte?.FechaModificacion ||
            apunte?.fecha_modificacion ||
            null
    };

    if (idApunte) {
        payload.idApunte = Number(idApunte);
    }

    return payload;
};

export const apunteService = {
    obtenerPorMateria: async (idMateria) => {
        try {
            const response = await fetch(`${API_URL}/materia/${idMateria}`);

            if (!response.ok) {
                const errorText = await response.text();
                console.error('Error al obtener apuntes:', response.status, errorText);
                throw new Error('Error al obtener los apuntes');
            }

            const data = await leerRespuesta(response);
            return Array.isArray(data) ? data : [];
        } catch (error) {
            console.error('Error en apunteService.obtenerPorMateria:', error);
            return [];
        }
    },

    crear: async (apunte) => {
        const payload = normalizarParaBackend(apunte);

        if (!payload.idMateria) {
            throw new Error('No se encontró idMateria para crear el apunte');
        }

        if (!payload.titulo.trim()) {
            throw new Error('El título del apunte es obligatorio');
        }

        if (!payload.contenido) {
            payload.contenido = '<p><br></p>';
        }

        const response = await fetch(API_URL, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(payload)
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al crear apunte:', response.status, errorText, payload);
            throw new Error('Error al crear el apunte');
        }

        return leerRespuesta(response);
    },

    guardar: async (apunte) => {
        const id = obtenerIdApunte(apunte);

        if (!id) {
            return apunteService.crear(apunte);
        }

        const ok = await apunteService.actualizar(id, apunte);

        if (!ok) {
            throw new Error('Error al actualizar el apunte');
        }

        return true;
    },

    actualizar: async (id, apunteActualizado) => {
        try {
            const payload = normalizarParaBackend({
                ...apunteActualizado,
                idApunte: id
            });

            const response = await fetch(`${API_URL}/${id}`, {
                method: 'PUT',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(payload)
            });

            if (!response.ok) {
                const errorText = await response.text();
                console.error('Error actualizando apunte:', response.status, errorText, payload);
                return false;
            }

            return true;
        } catch (error) {
            console.error('Error actualizando apunte:', error);
            return false;
        }
    },

    obtenerPorId: async (idApunte) => {
        try {
            const response = await fetch(`${API_URL}/${idApunte}`);

            if (!response.ok) {
                const errorText = await response.text();
                console.error('Error obteniendo apunte por ID:', response.status, errorText);
                throw new Error('Error al obtener el apunte');
            }

            return await leerRespuesta(response);
        } catch (error) {
            console.error('Error obteniendo el apunte por ID:', error);
            return null;
        }
    }
};