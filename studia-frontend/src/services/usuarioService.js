const API_BASE_URL =
    import.meta.env.VITE_API_URL || 'https://localhost:7068/api';

const API_URL = `${API_BASE_URL}/Usuarios`;

export const usuarioService = {
    actualizar: async (idUsuario, usuario) => {
        const response = await fetch(
            `${API_URL}/${idUsuario}`,
            {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(usuario)
            }
        );

        if (!response.ok) {
            const error = await response.text();
            throw new Error(error || 'Error al actualizar usuario');
        }

        return response.json();
    }
};