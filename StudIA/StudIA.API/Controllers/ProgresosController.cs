using Microsoft.AspNetCore.Mvc;
using StudIA.Business;
using StudIA.Data.Entities;

namespace StudIA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgresosController : ControllerBase
    {
        private readonly ProgresoService _progresoService;

        public ProgresosController(ProgresoService progresoService)
        {
            _progresoService = progresoService;
        }

        [HttpGet("usuario/{idUsuario}")]
        public async Task<ActionResult<IEnumerable<Progreso>>> GetProgresosUsuario(int idUsuario)
        {
            var progresos = await _progresoService.ObtenerProgresosPorUsuarioAsync(idUsuario);
            return Ok(progresos);
        }

        [HttpPost("actualizar")]
        public async Task<ActionResult<Progreso>> ActualizarProgreso([FromBody] UpdateProgresoRequest request)
        {
            var progreso = await _progresoService.ActualizarProgresoAsync(request.IdUsuario, request.IdMateria, request.SegundosAcumulados);
            return Ok(progreso);
        }
    }

    public class UpdateProgresoRequest
    {
        public int IdUsuario { get; set; }
        public int IdMateria { get; set; }
        public int SegundosAcumulados { get; set; }
    }
}