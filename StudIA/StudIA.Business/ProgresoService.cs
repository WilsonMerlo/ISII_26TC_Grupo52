using Azure.Core;
using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

namespace StudIA.Business
{
    public class ProgresoService
    {
        private readonly StudIAContext _context;

        public ProgresoService(StudIAContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Progreso>> ObtenerProgresosPorUsuarioAsync(int idUsuario)
        {
            return await _context.Progresos
                                 .Include(p => p.Materia)
                                 .Where(p => p.IdUsuario == idUsuario)
                                 .ToListAsync();
        }
        public async Task<Progreso> ActualizarProgresoAsync(int idUsuario, int idMateria, int segundosAcumulados)
        {
            var progreso = await _context.Progresos
                .FirstOrDefaultAsync(p => p.IdUsuario == idUsuario && p.IdMateria == idMateria);

            if (progreso == null)
            {
                progreso = new Progreso
                {
                    IdUsuario = idUsuario,
                    IdMateria = idMateria,
                    SegundosAcumulados = segundosAcumulados
                };
                _context.Progresos.Add(progreso);
            }
            else
            {
                progreso.SegundosAcumulados += segundosAcumulados;
            }

            await _context.SaveChangesAsync();

            return progreso; // Retorno agregado
        }
    }
}