const API_BASE_URL = import.meta.env.VITE_API_URL || 'https://localhost:7068/api';
const API_URL = `${API_BASE_URL}/Materias`;

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

    crear: async (materia) => {
        const response = await fetch(API_URL, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(materia)
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al crear materia:', response.status, errorText);
            throw new Error('Error al crear materia');
        }

        return response.json();
    },

    eliminar: async (id) => {
        const response = await fetch(`${API_URL}/${id}`, {
            method: 'DELETE'
        });

        if (!response.ok) {
            const errorText = await response.text();
            console.error('Error al eliminar materia:', response.status, errorText);
            throw new Error('Error al eliminar materia');
        }

        return response.text();
    }
};