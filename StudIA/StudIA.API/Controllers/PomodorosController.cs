using Microsoft.AspNetCore.Mvc;
using StudIA.Business;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PomodorosController : ControllerBase
    {
        private readonly PomodoroService _pomodoroService;

        // Inyectamos el Servicio
        public PomodorosController(PomodoroService pomodoroService)
        {
            _pomodoroService = pomodoroService;
        }

        // GET: api/pomodoros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pomodoro>>> GetPomodoros()
        {
            var pomodoros = await _pomodoroService.ObtenerTodosLosPomodorosAsync();

            if (pomodoros == null || !pomodoros.Any())
            {
                return NotFound("Aún no hay pomodoros registrados.");
            }

            return Ok(pomodoros);
        }

        // POST: api/pomodoros
        [HttpPost]
        public async Task<ActionResult<Pomodoro>> PostPomodoro(Pomodoro pomodoro)
        {
            // Le pasamos el objeto al servicio para que lo guarde en la DB
            var nuevoPomodoro = await _pomodoroService.CrearPomodoroAsync(pomodoro);

            return Ok(nuevoPomodoro);
        }
    }
}