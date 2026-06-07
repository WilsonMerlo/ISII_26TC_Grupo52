using Microsoft.AspNetCore.Mvc;
using StudIA.Business;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly MateriaService _materiaService;

        public MateriasController(MateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMaterias()
        {
            var materias = await _materiaService.ObtenerTodasLasMateriasAsync();
            if (materias == null || !materias.Any()) return NotFound("No se encontraron materias.");
            return Ok(materias);
        }

        [HttpGet("usuario/{idUsuario}")]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMateriasPorUsuario(int idUsuario)
        {
            var materias = await _materiaService.ObtenerMateriasPorUsuarioAsync(idUsuario);

            return Ok(materias);
        }

        [HttpPost]
        public async Task<ActionResult<Materia>> PostMateria(Materia materia)
        {
            var nuevaMateria = await _materiaService.CrearMateriaAsync(materia);
            return CreatedAtAction(nameof(GetMaterias), new { id = nuevaMateria.IdMateria }, nuevaMateria);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateria(int id, Materia materia)
        {
            var resultado = await _materiaService.ActualizarMateriaAsync(id, materia);
            if (!resultado) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateria(int id)
        {
            var resultado = await _materiaService.EliminarMateriaAsync(id);
            if (!resultado) return NotFound();
            return NoContent();
        }
    }
}