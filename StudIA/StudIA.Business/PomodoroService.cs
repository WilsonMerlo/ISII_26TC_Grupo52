using Microsoft.EntityFrameworkCore;
using StudIA.Data;
using StudIA.Data.Entities;

namespace StudIA.Business
{
    public class PomodoroService
    {
        private readonly StudIAContext _context;

        public PomodoroService(StudIAContext context)
        {
            _context = context;
        }

        // Método para el GET
        public async Task<IEnumerable<Pomodoro>> ObtenerTodosLosPomodorosAsync()
        {
            return await _context.Pomodoros
                                 .Include(p => p.Materia)
                                 .ToListAsync();
        }

        // Método para el POST
        public async Task<Pomodoro> CrearPomodoroAsync(Pomodoro pomodoro)
        {
            _context.Pomodoros.Add(pomodoro);
            await _context.SaveChangesAsync();

            return pomodoro;
        }
        // Método para el DELETE
        public async Task<bool> EliminarPomodoroAsync(int id)
        {
            var pomodoro = await _context.Pomodoros.FindAsync(id);
            if (pomodoro == null) return false;

            _context.Pomodoros.Remove(pomodoro);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}