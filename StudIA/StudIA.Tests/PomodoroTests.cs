using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using StudIA.Data;
using StudIA.Data.Entities;
using StudIA.Business;

namespace StudIA.Tests
{
    public class PomodoroServiceTests
    {
        // Helper para generar una base de datos limpia e independiente por cada test
        private DbContextOptions<StudIAContext> ObtenerOpcionesBdEnMemoria(string nombreBd)
        {
            return new DbContextOptionsBuilder<StudIAContext>()
                .UseInMemoryDatabase(databaseName: nombreBd)
                .Options;
        }

        // -------------------------------------------------------------------------
        // TRAZABILIDAD: Caso de Uso "Crear Pomodoro" -> Post-condiciones (Éxito)
        // -------------------------------------------------------------------------
        [Fact]
        public async Task CrearPomodoroAsync_IniciaConEstadoCompletado_GuardaCorrectamente()
        {
            // Arrange: Preparamos la BD en memoria y un usuario base
            var options = new DbContextOptionsBuilder<StudIAContext>()
                .UseInMemoryDatabase(databaseName: "DB_Pomodoro_Completado")
                .Options;

            using var context = new StudIAContext(options);
            context.Usuarios.Add(new Usuario { IdUsuario = 1, Nombre = "Estudiante", Correo = "test@test.com", Contrasena = "123" });
            await context.SaveChangesAsync();

            var service = new PomodoroService(context);

            // Configuramos un Pomodoro que ya viene completado (como exige el CU al finalizar el timer)
            var nuevoPomodoro = new Pomodoro
            {
                IdUsuario = 1,
                Fecha = DateTime.UtcNow,
                DuracionEstudio = 1500, // 25 min
                DuracionDescanso = 300, // 5 min
                EstadoFase = FasePomodoro.Completado
            };

            // Act: Ejecutamos el servicio
            var resultado = await service.CrearPomodoroAsync(nuevoPomodoro);

            // Assert: Verificamos que el estado se mantuvo y se guardó
            var pomodoroEnDb = await context.Pomodoros.FindAsync(resultado.IdPomodoro);
            Assert.NotNull(pomodoroEnDb);
            Assert.Equal(FasePomodoro.Completado, pomodoroEnDb.EstadoFase);
        }

        [Fact]
        public async Task CrearPomodoroAsync_TiemposValidos_PersisteDuracionesCorrectas()
        {
            // Arrange: Preparamos la BD en memoria y un usuario base
            var options = new DbContextOptionsBuilder<StudIAContext>()
                .UseInMemoryDatabase(databaseName: "DB_Pomodoro_Tiempos")
                .Options;

            using var context = new StudIAContext(options);
            context.Usuarios.Add(new Usuario { IdUsuario = 2, Nombre = "Estudiante2", Correo = "test2@test.com", Contrasena = "123" });
            await context.SaveChangesAsync();

            var service = new PomodoroService(context);

            // Configuramos un Pomodoro con tiempos específicos
            var nuevoPomodoro = new Pomodoro
            {
                IdUsuario = 2,
                Fecha = DateTime.UtcNow,
                DuracionEstudio = 3000, // 50 min
                DuracionDescanso = 600, // 10 min
                EstadoFase = FasePomodoro.Completado
            };

            // Act: Ejecutamos el servicio
            var resultado = await service.CrearPomodoroAsync(nuevoPomodoro);

            // Assert: Verificamos que EF Core no truncó ni alteró los enteros
            var pomodoroEnDb = await context.Pomodoros.FindAsync(resultado.IdPomodoro);
            Assert.Equal(3000, pomodoroEnDb.DuracionEstudio);
            Assert.Equal(600, pomodoroEnDb.DuracionDescanso);
        }
    }
}