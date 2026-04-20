using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly StudIAContext _context;

        public MateriasController(StudIAContext context)
        {
            _context = context;
        }

        // GET: api/materias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMaterias()
        {
            // Buscamos todas las materias en la base de datos
            var materias = await _context.Materias.ToListAsync();

            // Si no hay materias, devolvemos un 404 Not Found
            if (materias == null || !materias.Any())
            {
                return NotFound("No se encontraron materias.");
            }

            // Devolvemos la lista de materias con un 200 OK
            return Ok(materias);
        }
    }
}