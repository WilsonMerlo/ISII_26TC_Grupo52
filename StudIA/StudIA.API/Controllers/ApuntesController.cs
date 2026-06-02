using Microsoft.AspNetCore.Mvc;
using StudIA.Business;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApuntesController : ControllerBase
    {
        private readonly ApunteService _apunteService;

        public ApuntesController(ApunteService apunteService)
        {
            _apunteService = apunteService;
        }

        [HttpGet("materia/{idMateria}")]
        public async Task<ActionResult<IEnumerable<Apunte>>> GetApuntesPorMateria(int idMateria)
        {
            var apuntes = await _apunteService.ObtenerApuntesPorMateriaAsync(idMateria);
            return Ok(apuntes);
        }

        [HttpPost]
        public async Task<ActionResult<Apunte>> PostApunte(Apunte apunte)
        {
            var nuevoApunte = await _apunteService.CrearApunteAsync(apunte);
            return Ok(nuevoApunte);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutApunte(int id, [FromBody] Apunte apunteActualizado)
        {
            var resultado = await _apunteService.ActualizarApunteAsync(id, apunteActualizado);
            if (!resultado) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApunte(int id)
        {
            var resultado = await _apunteService.EliminarApunteAsync(id);
            if (!resultado) return NotFound();
            return NoContent();
        }
    }
}