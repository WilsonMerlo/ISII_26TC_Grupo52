using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PomodorosController : ControllerBase
    {
        private readonly StudIAContext _context;

        public PomodorosController(StudIAContext context)
        {
            _context = context;
        }

        // GET: api/pomodoros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pomodoro>>> GetPomodoros()
        {
            // Usamos .Include() para que además del ID, viaje toda la info de la Materia
            var pomodoros = await _context.Pomodoros
                                          .Include(p => p.Materia)
                                          .ToListAsync();

            if (pomodoros == null || !pomodoros.Any())
            {
                return NotFound("Aún no hay pomodoros registrados.");
            }

            return Ok(pomodoros);
        }
    }
}