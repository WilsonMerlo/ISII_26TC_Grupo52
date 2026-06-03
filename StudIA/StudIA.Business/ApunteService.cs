using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

namespace StudIA.Business
{
    public class ApunteService
    {
        private readonly StudIAContext _context;

        public ApunteService(StudIAContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Apunte>> ObtenerApuntesPorMateriaAsync(int idMateria)
        {
            return await _context.Apuntes
                                 .Where(a => a.IdMateria == idMateria)
                                 .OrderByDescending(a => a.FechaModificacion)
                                 .ToListAsync();
        }

        public async Task<Apunte> CrearApunteAsync(Apunte apunte)
        {
            apunte.FechaCreacion = DateTime.UtcNow;
            apunte.FechaModificacion = null; // Fuerza el nulo en la creación

            _context.Apuntes.Add(apunte);
            await _context.SaveChangesAsync();
            return apunte;
        }

        public async Task<bool> ActualizarApunteAsync(int id, Apunte apunteActualizado)
        {
            var apunte = await _context.Apuntes.FindAsync(id);
            if (apunte == null) return false;

            apunte.Titulo = apunteActualizado.Titulo;
            apunte.Contenido = apunteActualizado.Contenido;
            apunte.FechaModificacion = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarApunteAsync(int id)
        {
            var apunte = await _context.Apuntes.FindAsync(id);
            if (apunte == null) return false;

            // --- SOLUCIÓN AL ERROR 500 ---
            // Le decimos a SQL que ponga el IdApunte en NULL para todos los pomodoros asociados,
            // ANTES de borrar el apunte de la base de datos.
            await _context.Pomodoros
                          .Where(p => p.IdApunte == id)
                          .ExecuteUpdateAsync(s => s.SetProperty(p => p.IdApunte, (int?)null));
            // -----------------------------

            _context.Apuntes.Remove(apunte);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}