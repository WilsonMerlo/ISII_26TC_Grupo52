using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

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
        public async Task<Usuario?> ValidarLoginAsync(string correo, string contrasena)
        {
            // Busca el primer usuario que coincida con el correo y la contraseña.
            // Si no encuentra nada, devuelve null.
            return await _context.Usuarios
                                 .FirstOrDefaultAsync(u => u.Correo == correo && u.Contrasena == contrasena);
        }
    }
}