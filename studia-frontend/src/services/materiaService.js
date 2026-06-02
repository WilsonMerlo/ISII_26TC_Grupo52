const API_URL = 'https://localhost:7068/api/Materias';

export const materiaService = {
    obtenerTodas: async () => {
        const response = await fetch(API_URL);
        if (!response.ok) throw new Error('Error al obtener materias');
        return response.json();
    },
    crear: async (materia) => {
        const response = await fetch(API_URL, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(materia)
        });
        if (!response.ok) throw new Error('Error al crear materia');
        return response.json();
    },
    eliminar: async (id) => {
        const response = await fetch(`${API_URL}/${id}`, { method: 'DELETE' });
        if (!response.ok) throw new Error('Error al eliminar materia');
        return response.text(); 
    }
};