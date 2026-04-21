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

            if (materias == null || !materias.Any())
            {
                return NotFound("No se encontraron materias.");
            }

            return Ok(materias);
        }
    }
}