const API_URL = 'https://localhost:7068/api/Apuntes';

export const apunteService = {
    obtenerPorMateria: async (idMateria) => {
        const response = await fetch(`${API_URL}/materia/${idMateria}`);
        if (!response.ok) throw new Error('Error al obtener apuntes');
        return response.json();
    },
    guardar: async (apunte) => {
        const method = apunte.idApunte ? 'PUT' : 'POST';
        const url = apunte.idApunte ? `${API_URL}/${apunte.idApunte}` : API_URL;
        
        const response = await fetch(url, {
            method,
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(apunte)
        });
        if (!response.ok) throw new Error('Error al guardar el apunte');
        return response.json();
    }
};