using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;
using BCrypt.Net;

namespace StudIA.Business
{
    public class UsuarioService
    {
        private readonly StudIAContext _context;

        public UsuarioService(StudIAContext context)
        {
            _context = context;
        }

        // Método para registrar al usuario (POST)
        public async Task<Usuario> CrearUsuarioAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        // Método para validar el Login 
        public async Task<Usuario?> ValidarLoginAsync(string correo, string contrasena)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Correo == correo);

            if (usuario == null)
            {
                return null;
            }

            var contrasenaGuardada = usuario.Contrasena ?? "";

            var pareceHash =
                contrasenaGuardada.StartsWith("$2a$") ||
                contrasenaGuardada.StartsWith("$2b$") ||
                contrasenaGuardada.StartsWith("$2y$");

            if (pareceHash)
            {
                try
                {
                    var valido = BCrypt.Net.BCrypt.Verify(contrasena, contrasenaGuardada);
                    return valido ? usuario : null;
                }
                catch
                {
                    return null;
                }
            }

            if (contrasenaGuardada == contrasena)
            {
                usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword(contrasena);
                await _context.SaveChangesAsync();

                return usuario;
            }

            return null;
        }

        public async Task<Usuario?> ActualizarDatosUsuarioAsync(int id, string nombre, string correo)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.IdUsuario == id);

            if (usuario == null)
            {
                return null;
            }

            usuario.Nombre = nombre;
            usuario.Correo = correo;

            await _context.SaveChangesAsync();

            return usuario;
        }

        public class ResultadoCambioContrasena
        {
            public bool Exito { get; set; }
            public string Mensaje { get; set; } = string.Empty;
        }

        public async Task<ResultadoCambioContrasena> CambiarContrasenaAsync(
    int id,
    string contrasenaActual,
    string nuevaContrasena)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.IdUsuario == id);

            if (usuario == null)
            {
                return new ResultadoCambioContrasena
                {
                    Exito = false,
                    Mensaje = "Usuario no encontrado"
                };
            }

            var contrasenaValida = BCrypt.Net.BCrypt.Verify(
                contrasenaActual,
                usuario.Contrasena
            );

            if (!contrasenaValida)
            {
                return new ResultadoCambioContrasena
                {
                    Exito = false,
                    Mensaje = "La contraseña actual es incorrecta"
                };
            }

            if (contrasenaActual == nuevaContrasena)
            {
                return new ResultadoCambioContrasena
                {
                    Exito = false,
                    Mensaje = "La nueva contraseña debe ser diferente a la actual"
                };
            }

            usuario.Contrasena =
                BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);

            await _context.SaveChangesAsync();

            return new ResultadoCambioContrasena
            {
                Exito = true,
                Mensaje = "Contraseña actualizada correctamente"
            };
        }


    }
}