using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using StudIA.Business;
using StudIA.Data;
using StudIA.Data.Entities;
using Xunit;

namespace StudIA.Tests
{
    public class ApunteServiceTests
    {
        // Función auxiliar para simular el DbContext de Entity Framework sin tocar SQL Server.
        private Mock<StudIAContext> CreateMockContext()
        {
            var options = new DbContextOptions<StudIAContext>();
            return new Mock<StudIAContext>(options);
        }

        // PU-04: Crear apunte sin título
        [Theory] // [Theory] permite correr este mismo test varias veces con distintos datos.
        [InlineData(null)]   // Corrida 1: tituloInvalido = null
        [InlineData("")]     // Corrida 2: tituloInvalido = ""
        [InlineData("   ")]  // Corrida 3: tituloInvalido = "   "
        public async Task CrearApunteAsync_TituloNuloOVacio_AsignaSinTitulo(string? tituloInvalido)
        {
            // Arrange: Preparamos la BD falsa en memoria.
            var mockContext = CreateMockContext();
            var apuntesList = new List<Apunte>();
            var apuntesMock = apuntesList.AsQueryable().BuildMockDbSet(); // Convertimos la lista en una tabla DbSet simulada.

            mockContext.Object.Apuntes = apuntesMock.Object;

            // Instanciamos el servicio inyectándole la BD falsa.
            var service = new ApunteService(mockContext.Object);

            var apunte = new Apunte
            {
                IdMateria = 1,
                Titulo = tituloInvalido!, // Le pasamos el dato inyectado por [InlineData]
                Contenido = "Contenido test"
            };

            // Act: Llamamos al método.
            var resultado = await service.CrearApunteAsync(apunte);

            // Assert: Comprobaciones.
            // 1. Verificamos que el sistema forzó un título por defecto.
            Assert.StartsWith("Sin título", resultado.Titulo);

            // 2. Verificamos que se haya ejecutado el comando INSERT (Add) exactamente 1 vez.
            apuntesMock.Verify(a => a.Add(It.IsAny<Apunte>()), Times.Once);

            // 3. Verificamos que se haya hecho el commit en la BD (SaveChangesAsync) exactamente 1 vez.
            mockContext.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        // PU-05: Eliminar apunte inexistente
        [Fact]
        public async Task EliminarApunteAsync_IdNoExiste_RetornaFalse()
        {
            // Arrange: Preparamos BD falsa vacía.
            var mockContext = CreateMockContext();
            var apuntesMock = new List<Apunte>().AsQueryable().BuildMockDbSet();

            // Forzamos el comportamiento del Mock: le decimos que cuando el código intente 
            // buscar un apunte (FindAsync), siempre devuelva null (simulando que no existe).
            apuntesMock.Setup(m => m.FindAsync(It.IsAny<object[]>())).ReturnsAsync((Apunte?)null);

            mockContext.Object.Apuntes = apuntesMock.Object;

            var service = new ApunteService(mockContext.Object);

            // Act: Intentamos borrar el id 999.
            var resultado = await service.EliminarApunteAsync(999);

            // Assert: Verificamos que el método devuelva 'false' abortando la operación en lugar de crashear.
            Assert.False(resultado);
        }
    }
}