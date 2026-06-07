const API_BASE_URL =
    import.meta.env.VITE_API_URL || 'https://localhost:7068/api';

const API_URL = `${API_BASE_URL}/Usuarios`;

export const usuarioService = {
    actualizarDatos: async (idUsuario, datos) => {
        const response = await fetch(
            `${API_URL}/${idUsuario}/datos`,
            {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(datos)
            }
        );

        if (!response.ok) {
            const error = await response.text();
            throw new Error(error || 'Error actualizando datos');
        }

        return response.json();
    },

    cambiarContrasena: async (
        idUsuario,
        contrasenaActual,
        nuevaContrasena
    ) => {
        const response = await fetch(
            `${API_URL}/${idUsuario}/contrasena`,
            {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    contrasenaActual,
                    nuevaContrasena
                })
            }
        );

        const data = await response.json();

        if (!response.ok) {
            throw new Error(
                data.error ||
                data.mensaje ||
                'Error al cambiar contraseña'
            );
        }

        return data;
    }
};