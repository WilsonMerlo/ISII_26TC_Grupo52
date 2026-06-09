using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Xunit;
using StudIA.Data;
using StudIA.Data.Entities;
using StudIA.Business;

namespace StudIA.Tests
{
    public class ApunteTests
    {
        // Helper para generar una base de datos limpia e independiente por cada test
        private DbContextOptions<StudIAContext> ObtenerOpcionesBdEnMemoria(string nombreBd)
        {
            return new DbContextOptionsBuilder<StudIAContext>()
                .UseInMemoryDatabase(databaseName: nombreBd)
                .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning)) // <-- Agrega esta línea
                .Options;
        }

        // =========================================================================
        // TRAZABILIDAD: Caso de Uso "Crear Apunte" (Tabla 7)
        // =========================================================================

        [Fact]
        public async Task CrearApunteAsync_CumplePostCondiciones_CreaInstanciaYAsignaFechas()
        {
            // Arrange
            var options = ObtenerOpcionesBdEnMemoria("DB_CrearApunte_Normal");
            using var context = new StudIAContext(options);

            // Pre-condición: El sistema conoce la Materia seleccionada
            context.Usuarios.Add(new Usuario { IdUsuario = 1, Nombre = "Est", Correo = "e@e.com", Contrasena = "123" });
            context.Materias.Add(new Materia { IdMateria = 10, IdUsuario = 1, NombreMateria = "Sistemas" });
            await context.SaveChangesAsync();

            var service = new ApunteService(context);
            var nuevoApunte = new Apunte
            {
                IdMateria = 10,
                Titulo = "Introducción a Hilos",
                Contenido = "Este es el contenido de prueba."
            };

            // Act
            var resultado = await service.CrearApunteAsync(nuevoApunte);

            // Assert (Post-condiciones)
            var apunteEnDb = await context.Apuntes.FindAsync(resultado.IdApunte);

            Assert.NotNull(apunteEnDb); // Se creó una instancia
            Assert.Equal(10, apunteEnDb.IdMateria); // Se asoció a la instancia de Materia
            Assert.Equal("Introducción a Hilos", apunteEnDb.Titulo); // Se asignó el título
            Assert.Equal("Este es el contenido de prueba.", apunteEnDb.Contenido); // Se asignó el contenido

            // Se asignó la fecha y hora actual
            Assert.True(apunteEnDb.FechaCreacion <= DateTime.UtcNow);
        }

        [Fact]
        public async Task CrearApunteAsync_TituloDuplicado_AgregaSufijoIncremental()
        {
            // Arrange
            var options = ObtenerOpcionesBdEnMemoria("DB_CrearApunte_Duplicado");
            using var context = new StudIAContext(options);

            context.Usuarios.Add(new Usuario { IdUsuario = 1, Nombre = "Est", Correo = "e@e.com", Contrasena = "123" });
            context.Materias.Add(new Materia { IdMateria = 10, IdUsuario = 1, NombreMateria = "Sistemas" });

            // Insertamos un apunte que YA existe en la materia
            context.Apuntes.Add(new Apunte { IdApunte = 1, IdMateria = 10, Titulo = "Resumen Unidad 1", Contenido = "...", FechaCreacion = DateTime.UtcNow });
            await context.SaveChangesAsync();

            var service = new ApunteService(context);
            var nuevoApunte = new Apunte
            {
                IdMateria = 10,
                Titulo = "Resumen Unidad 1", // Colisión intencional de nombre
                Contenido = "Contenido nuevo"
            };

            // Act
            var resultado = await service.CrearApunteAsync(nuevoApunte);

            // Assert (Post-condición: Si ya existe, se asignó con un sufijo incremental)
            Assert.Equal("Resumen Unidad 1 (2)", resultado.Titulo);
        }

        // =========================================================================
        // TRAZABILIDAD: Caso de Uso "Eliminar Apunte" (Tabla 13)
        // =========================================================================

        [Fact]
        public async Task EliminarApunteAsync_IdNoExiste_CancelaOperacion()
        {
            // Arrange
            var options = ObtenerOpcionesBdEnMemoria("DB_EliminarApunte_Inexistente");
            using var context = new StudIAContext(options);
            var service = new ApunteService(context);

            // Act: Intentamos borrar el id 999 que no está en la BD en memoria
            var resultado = await service.EliminarApunteAsync(999);

            // Assert (Excepciones: Si el idApunte no existe, se cancela la operación)
            Assert.False(resultado);
        }

    }
}