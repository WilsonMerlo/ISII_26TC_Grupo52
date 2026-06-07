using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;
using System.Linq;

namespace StudIA.Business
{
    public class MateriaService
    {
        private readonly StudIAContext _context;

        public MateriaService(StudIAContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Materia>> ObtenerTodasLasMateriasAsync()
        {
            return await _context.Materias.ToListAsync();
        }

        public async Task<IEnumerable<Materia>> ObtenerMateriasPorUsuarioAsync(int idUsuario)
        {
            return await _context.Materias
                .Where(m => m.IdUsuario == idUsuario)
                .ToListAsync();
        }

        public async Task<Materia> CrearMateriaAsync(Materia materia)
        {
            string nombreOriginal = materia.NombreMateria;
            int contador = 2;

            while (await _context.Materias.AnyAsync(m => m.IdUsuario == materia.IdUsuario && m.NombreMateria == materia.NombreMateria))
            {
                materia.NombreMateria = $"{nombreOriginal} ({contador})";
                contador++;
            }

            _context.Materias.Add(materia);
            await _context.SaveChangesAsync();
            return materia;
        }

        public async Task<bool> ActualizarMateriaAsync(int id, Materia materiaActualizada)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia == null) return false;

            materia.NombreMateria = materiaActualizada.NombreMateria;
            materia.Descripcion = materiaActualizada.Descripcion;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarMateriaAsync(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia == null) return false;

            _context.Materias.Remove(materia);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}