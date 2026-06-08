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
                                 .OrderByDescending(a => a.FechaModificacion ?? a.FechaCreacion)
                                 .ToListAsync();
        }

        public async Task<Apunte> CrearApunteAsync(Apunte apunte)
        {
            apunte.Titulo = await GenerarTituloDisponibleAsync(
                apunte.IdMateria,
                apunte.Titulo
            );

            apunte.FechaCreacion = DateTime.Now;
            apunte.FechaModificacion = DateTime.Now;

            _context.Apuntes.Add(apunte);
            await _context.SaveChangesAsync();

            return apunte;
        }

        private async Task<string> GenerarTituloDisponibleAsync(int idMateria, string tituloSolicitado)
        {
            var tituloBase = (tituloSolicitado ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(tituloBase))
            {
                tituloBase = "Sin título";
            }

            var titulosExistentes = await _context.Apuntes
                .Where(a => a.IdMateria == idMateria)
                .Select(a => a.Titulo)
                .ToListAsync();

            if (!titulosExistentes.Contains(tituloBase))
            {
                return tituloBase;
            }

            var contador = 2;
            var tituloCandidato = $"{tituloBase} ({contador})";

            while (titulosExistentes.Contains(tituloCandidato))
            {
                contador++;
                tituloCandidato = $"{tituloBase} ({contador})";
            }

            return tituloCandidato;
        }

        public async Task<bool> ActualizarApunteAsync(int id, Apunte apunteActualizado)
        {
            var apunte = await _context.Apuntes.FindAsync(id);
            if (apunte == null) return false;

            apunte.Titulo = apunteActualizado.Titulo;
            apunte.Contenido = apunteActualizado.Contenido;
            apunte.FechaModificacion = DateTime.Now;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarApunteAsync(int id)
        {
            var apunte = await _context.Apuntes.FindAsync(id);
            if (apunte == null) return false;

            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                await _context.Pomodoros
                              .Where(p => p.IdApunte == id)
                              .ExecuteUpdateAsync(s => s.SetProperty(p => p.IdApunte, (int?)null));

                _context.Apuntes.Remove(apunte);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
