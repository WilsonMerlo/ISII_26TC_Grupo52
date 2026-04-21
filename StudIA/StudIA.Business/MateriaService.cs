using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

namespace StudIA.Business
{
    public class MateriaService
    {
        private readonly StudIAContext _context;

        // Inyectamos el contexto de la base de datos (la despensa)
        public MateriaService(StudIAContext context)
        {
            _context = context;
        }

        // Método que el Controlador va a llamar para pedir las materias
        public async Task<IEnumerable<Materia>> ObtenerTodasLasMateriasAsync()
        {
            var materias = await _context.Materias.ToListAsync();

            return materias;
        }             
    }
}
