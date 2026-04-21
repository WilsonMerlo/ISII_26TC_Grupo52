using Microsoft.AspNetCore.Mvc;
using StudIA.Business;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuariosController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // POST: api/usuarios
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            var nuevoUsuario = await _usuarioService.CrearUsuarioAsync(usuario);
            return Ok(nuevoUsuario);
        }

        // --- NUEVO ENDPOINT DE LOGIN ---
        // POST: api/usuarios/login
        [HttpPost("login")]
        public async Task<ActionResult<Usuario>> Login([FromBody] LoginRequest login)
        {
            // Le pedimos al servicio que valide los datos
            var usuario = await _usuarioService.ValidarLoginAsync(login.Correo, login.Contrasena);

            if (usuario == null)
            {
                // Si devuelve null, tiramos un error 401 (No Autorizado)
                return Unauthorized("Correo o contraseña incorrectos.");
            }

            // Si está todo bien, devolvemos un 200 OK con los datos del usuario
            return Ok(usuario);
        }
    }

    // --- CLASE PARA RECIBIR EL JSON DE LOGIN ---
    public class LoginRequest
    {
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}