const RAW_API_BASE_URL =
    import.meta.env.VITE_API_URL || 'https://localhost:7068/api';

const API_BASE_URL = RAW_API_BASE_URL.endsWith('/api')
    ? RAW_API_BASE_URL
    : `${RAW_API_BASE_URL}/api`;

const API_URL = `${API_BASE_URL}/Materias`;

const leerRespuesta = async (response) => {
    const contentType = response.headers.get('content-type');

    if (contentType && contentType.includes('application/json')) {
        return response.json();
    }

    return response.text();
};

export const materiaService = {
    obtenerTodas: async () => {
        const response = await fetch(API_URL);

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al obtener materias:', response.status, errorText);
            throw new Error('Error al obtener materias');
        }

        return response.json();
    },

    obtenerPorUsuario: async (idUsuario) => {
        const response = await fetch(`${API_URL}/usuario/${idUsuario}`);

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al obtener materias del usuario:', response.status, errorText);
            throw new Error('Error al obtener materias');
        }

        const data = await leerRespuesta(response);
        return Array.isArray(data) ? data : [];
    },

    crear: async (materia) => {
        const idUsuario = Number(
            materia?.idUsuario ||
            materia?.IdUsuario ||
            localStorage.getItem('idUsuario')
        );

        const payload = {
            ...materia,
            idUsuario
        };

        const response = await fetch(API_URL, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(payload)
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al crear materia:', response.status, errorText);
            throw new Error(errorText || 'Error al crear materia');
        }

        return leerRespuesta(response);
    },

    actualizar: async (id, materia) => {
        const idUsuario = Number(
            materia?.idUsuario ||
            materia?.IdUsuario ||
            localStorage.getItem('idUsuario')
        );

        const payload = {
            ...materia,
            idUsuario
        };

        const response = await fetch(`${API_URL}/${id}`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(payload)
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al actualizar materia:', response.status, errorText);
            throw new Error(errorText || 'Error al actualizar materia');
        }

        return leerRespuesta(response);
    },

    eliminar: async (id) => {
        const response = await fetch(`${API_URL}/${id}`, {
            method: 'DELETE'
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al eliminar materia:', response.status, errorText);
            throw new Error(errorText || 'Error al eliminar materia');
        }

        return leerRespuesta(response);
    }
};