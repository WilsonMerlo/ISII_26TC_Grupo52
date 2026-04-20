using Microsoft.AspNetCore.Mvc;
using StudIA.Business; // <-- Ahora usamos la capa de negocios
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly MateriaService _materiaService;

        // Ahora inyectamos el Servicio en lugar del Contexto
        public MateriasController(MateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        // GET: api/materias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMaterias()
        {
            // Le pedimos los datos al Servicio (El Mozo le pide al Chef)
            var materias = await _materiaService.ObtenerTodasLasMateriasAsync();

            if (materias == null || !materias.Any())
            {
                return NotFound("No se encontraron materias.");
            }

            return Ok(materias);
        }
    }
}