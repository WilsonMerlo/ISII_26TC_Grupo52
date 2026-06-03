const API_URL = 'https://localhost:7068/api/Apuntes';

export const apunteService = {
    obtenerPorMateria: async (idMateria) => {
        try {
            // 👇 ¡Llamamos a la ruta exacta de Wilson! 👇
            const response = await fetch(`${API_URL}/materia/${idMateria}`);
            
            if (!response.ok) throw new Error('Error al obtener los apuntes');
            
            const data = await response.json();
            console.log("🕵️‍♀️ Datos desde la API de Wilson:", data); // Nuestro espía
            return data;
        } catch (error) {
            console.error("Error en apunteService:", error);
            return [];
        }
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
    },

    actualizar: async (id, apunteActualizado) => {
        try {
            const response = await fetch(`${API_URL}/${id}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(apunteActualizado)
            });
            return response.ok;
        } catch (error) {
            console.error("Error actualizando apunte:", error);
            return false;
        }
    },

    obtenerPorId: async (idApunte) => {
        try {
            // Llama al endpoint de Wilson para buscar 1 solo apunte
            const response = await fetch(`${API_URL}/${idApunte}`);
            
            if (!response.ok) throw new Error('Error al obtener el apunte');
            
            return await response.json();
        } catch (error) {
            console.error("Error obteniendo el apunte por ID:", error);
            return null;
        }
    }


};