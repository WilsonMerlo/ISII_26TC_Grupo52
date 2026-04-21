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
        public async Task<Usuario> CrearUsuarioAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }
    }
}