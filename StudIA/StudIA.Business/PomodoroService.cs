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

        // Método para traer solo los pomodoros de un usuario específico
        public async Task<IEnumerable<Pomodoro>> ObtenerPomodorosPorUsuarioAsync(int idUsuario)
        {
            return await _context.Pomodoros
                                 .Include(p => p.Materia)
                                 .Where(p => p.IdUsuario == idUsuario)
                                 .OrderByDescending(p => p.Fecha)
                                 .ToListAsync();
        }

        // NUEVO: Método que ejecuta el patrón State
        public async Task<Pomodoro?> EjecutarAccionPomodoroAsync(int id, string accion)
        {
            var pomodoro = await _context.Pomodoros.FindAsync(id);
            if (pomodoro == null) return null;

            // Delegamos la orden. Si es ilegal, la entidad lanzará una InvalidOperationException
            switch (accion.ToLower())
            {
                case "iniciar":       // <-- Agregado
                case "reanudar":      // "iniciar" y "reanudar" hacen lo mismo
                    pomodoro.Reanudar();
                    break;
                case "pausar":
                    pomodoro.Pausar();
                    break;
                case "finalizar":
                    pomodoro.Finalizar();
                    break;
                case "saltarfase":
                    pomodoro.SaltarFase();
                    break;
                default: throw new ArgumentException("Acción no reconocida en el sistema.");
            }

            // EF Core detecta el cambio en 'EstadoFase' y hace el UPDATE
            await _context.SaveChangesAsync();
            return pomodoro;
        }
    }
}