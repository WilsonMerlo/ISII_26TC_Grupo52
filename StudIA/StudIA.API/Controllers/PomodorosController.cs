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
            var nuevoPomodoro = await _pomodoroService.CrearPomodoroAsync(pomodoro);

            return Ok(nuevoPomodoro);
        }

        // DELETE: api/pomodoros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePomodoro(int id)
        {
            var resultado = await _pomodoroService.EliminarPomodoroAsync(id);

            if (!resultado)
            {
                return NotFound("El pomodoro no se encontró o ya fue eliminado.");
            }

            return NoContent(); // Retorna 204 No Content (Éxito)
        }

        // GET: api/pomodoros/usuario/5
        [HttpGet("usuario/{idUsuario}")]
        public async Task<ActionResult<IEnumerable<Pomodoro>>> GetPomodorosUsuario(int idUsuario)
        {
            var pomodoros = await _pomodoroService.ObtenerPomodorosPorUsuarioAsync(idUsuario);

            // Si no tiene historial, devolvemos una lista vacía con un 200 OK para que React no rompa
            if (pomodoros == null || !pomodoros.Any())
            {
                return Ok(new List<Pomodoro>());
            }

            return Ok(pomodoros);
        }

        // POST: api/pomodoros/5/accion/pausar
        [HttpPost("{id}/accion/{tipoAccion}")]
        public async Task<IActionResult> EjecutarAccion(int id, string tipoAccion, [FromBody] ActionPomodoroDto? dto)
        {
            try
            {
                int? estudio = dto?.DuracionEstudio;
                int? descanso = dto?.DuracionDescanso;

                var pomodoro = await _pomodoroService.EjecutarAccionPomodoroAsync(id, tipoAccion, estudio, descanso);

                if (pomodoro == null)
                {
                    return NotFound(new { mensaje = "Pomodoro no encontrado." });
                }

                return Ok(pomodoro);
            }
            catch (InvalidOperationException ex)
            {
                // Si el patrón State rechaza la acción (ej: pausar cuando ya está finalizado), 
                // devolvemos un 400 Bad Request con el mensaje de error.
                return BadRequest(new { error = ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        // PUT: api/pomodoros/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPomodoro(int id, [FromBody] ActualizarDuracionesDto dto)
        {
            if (id != dto.IdPomodoro)
            {
                return BadRequest(new { mensaje = "El ID de la ruta no coincide con el ID del cuerpo." });
            }

            var modificado = await _pomodoroService.ActualizarDuracionesAsync(id, dto.DuracionEstudio, dto.DuracionDescanso);

            if (!modificado)
            {
                return NotFound(new { mensaje = "Pomodoro no encontrado." });
            }

            return NoContent(); // Retorna 204 Exito sin contenido
        }
    }



    // DTO para recibir las duraciones opcionales desde el frontend
    public class ActionPomodoroDto
    {
        public int? DuracionEstudio { get; set; }
        public int? DuracionDescanso { get; set; }
    }

    public class ActualizarDuracionesDto
    {
        public int IdPomodoro { get; set; }
        public int DuracionEstudio { get; set; }
        public int DuracionDescanso { get; set; }
    }




}