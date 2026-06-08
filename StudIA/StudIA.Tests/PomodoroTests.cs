using Xunit;
using StudIA.Data.Entities;
using System;

namespace StudIA.Tests
{
    public class PomodoroTests
    {
        // PU-01: Reanudar desde Pendiente
        [Fact] // [Fact] indica que es un test unitario simple sin parámetros.
        public void Reanudar_DesdePendiente_CambiaAEnCurso()
        {
            // Arrange: Preparamos la entidad simulando que recién se creó.
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.Pendiente };

            // Act: Disparamos la acción del usuario.
            pomodoro.Reanudar();

            // Assert: Verificamos que la máquina de estados mutó correctamente.
            Assert.Equal(FasePomodoro.EnCurso, pomodoro.EstadoFase);
        }

        // PU-02: Pausar desde EnCurso
        [Fact]
        public void Pausar_DesdeEnCurso_CambiaAPausado()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.EnCurso };

            // Act
            pomodoro.Pausar();

            // Assert
            Assert.Equal(FasePomodoro.Pausado, pomodoro.EstadoFase);
        }

        // PU-01 (Alternativo): Error al reanudar algo ya en curso
        [Fact]
        public void Reanudar_DesdeEnCurso_LanzaExcepcion()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.EnCurso };

            // Act & Assert: Cuando testeamos excepciones, Assert.Throws captura el error esperado.
            // Si pomodoro.Reanudar() no "crashea", el test falla.
            var ex = Assert.Throws<InvalidOperationException>(() => pomodoro.Reanudar());

            // Verificamos que el mensaje de error sea exactamente el programado.
            Assert.Equal("El temporizador ya está corriendo.", ex.Message);
        }

        // PU-02 (Alternativo): Error al pausar algo completado
        [Fact]
        public void Pausar_DesdeCompletado_LanzaExcepcion()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.Completado };

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => pomodoro.Pausar());
            Assert.Equal("El pomodoro ya finalizó.", ex.Message);
        }

        // PU-03: Saltar Fase
        [Fact]
        public void SaltarFase_DesdeEnDescanso_CambiaACompletado()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.EnDescanso };

            // Act
            pomodoro.SaltarFase();

            // Assert
            Assert.Equal(FasePomodoro.Completado, pomodoro.EstadoFase);
        }
    }
}