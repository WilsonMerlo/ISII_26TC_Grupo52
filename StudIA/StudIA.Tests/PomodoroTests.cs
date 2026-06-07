using Xunit;
using StudIA.Data.Entities;
using System;

namespace StudIA.Tests
{
    public class PomodoroTests
    {
        [Fact]
        public void Reanudar_DesdePendiente_CambiaAEnCurso()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.Pendiente };

            // Act
            pomodoro.Reanudar();

            // Assert
            Assert.Equal(FasePomodoro.EnCurso, pomodoro.EstadoFase);
        }

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

        [Fact]
        public void Reanudar_DesdeEnCurso_LanzaExcepcion()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.EnCurso };

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => pomodoro.Reanudar());
            Assert.Equal("El temporizador ya está corriendo.", ex.Message);
        }

        [Fact]
        public void Pausar_DesdeCompletado_LanzaExcepcion()
        {
            // Arrange
            var pomodoro = new Pomodoro { EstadoFase = FasePomodoro.Completado };

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => pomodoro.Pausar());
            Assert.Equal("El pomodoro ya finalizó.", ex.Message);
        }

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