using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StudIA.Data.Entities
{
    // 1. EL ENUMERADOR PARA LA BASE DE DATOS
    public enum FasePomodoro
    {
        Pendiente = 0,
        EnCurso = 1,
        Pausado = 2,
        EnDescanso = 3,
        Completado = 4
    }

    // 2. LA INTERFAZ DEL PATRÓN STATE
    public interface IEstadoPomodoro
    {
        void Pausar(Pomodoro contexto);
        void Reanudar(Pomodoro contexto);
        void Finalizar(Pomodoro contexto);
        void SaltarFase(Pomodoro contexto);
    }

    // 3. LA ENTIDAD PRINCIPAL
    [Table("Pomodoros")]
    public class Pomodoro
    {
        [Key]
        [Column("id_pomodoro")]
        public int IdPomodoro { get; set; }

        [Required]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("id_materia")]
        public int? IdMateria { get; set; }

        [Column("id_apunte")]
        public int? IdApunte { get; set; }

        [Required]
        [Column("fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [Column("duracion_estudio")]
        public int DuracionEstudio { get; set; }

        [Required]
        [Column("duracion_descanso")]
        public int DuracionDescanso { get; set; }

        // --- INICIO IMPLEMENTACIÓN STATE ---
        [Required]
        [Column("estado_fase")]
        public FasePomodoro EstadoFase { get; set; }

        // Evalúa el estado en tiempo real, resolviendo el problema de EF Core
        [NotMapped]
        [JsonIgnore]
        public IEstadoPomodoro EstadoActual => EstadoFase switch
        {
            FasePomodoro.Pendiente => new EstadoPendiente(),
            FasePomodoro.EnCurso => new EstadoEnCurso(),
            FasePomodoro.Pausado => new EstadoPausado(),
            FasePomodoro.EnDescanso => new EstadoEnDescanso(),
            FasePomodoro.Completado => new EstadoCompletado(),
            _ => new EstadoPendiente()
        };

        // Delegación de acciones (Polimorfismo puro)
        public void Pausar() => EstadoActual.Pausar(this);
        public void Reanudar() => EstadoActual.Reanudar(this);
        public void Finalizar() => EstadoActual.Finalizar(this);
        public void SaltarFase() => EstadoActual.SaltarFase(this);
        // --- FIN IMPLEMENTACIÓN STATE ---

        // Relaciones
        [JsonIgnore]
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }

        [JsonIgnore]
        [ForeignKey("IdMateria")]
        public Materia? Materia { get; set; }

        [JsonIgnore]
        [ForeignKey("IdApunte")]
        public Apunte? Apunte { get; set; }
    }

    // 4. CLASES CONCRETAS DE ESTADO (Comportamientos específicos)
    public class EstadoPendiente : IEstadoPomodoro
    {
        public void Pausar(Pomodoro contexto) => throw new InvalidOperationException("No se puede pausar un temporizador que no ha iniciado.");
        public void Reanudar(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.EnCurso;
        public void Finalizar(Pomodoro contexto) => throw new InvalidOperationException("No se puede finalizar una sesión sin iniciar.");
        public void SaltarFase(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.EnDescanso;
    }

    public class EstadoEnCurso : IEstadoPomodoro
    {
        public void Pausar(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.Pausado;
        public void Reanudar(Pomodoro contexto) => throw new InvalidOperationException("El temporizador ya está corriendo.");
        public void Finalizar(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.Completado;
        public void SaltarFase(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.EnDescanso;
    }

    public class EstadoPausado : IEstadoPomodoro
    {
        public void Pausar(Pomodoro contexto) => throw new InvalidOperationException("La sesión ya se encuentra pausada.");
        public void Reanudar(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.EnCurso;
        public void Finalizar(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.Completado;
        public void SaltarFase(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.EnDescanso;
    }

    public class EstadoEnDescanso : IEstadoPomodoro
    {
        public void Pausar(Pomodoro contexto) => throw new InvalidOperationException("No se puede pausar el tiempo de descanso.");
        public void Reanudar(Pomodoro contexto) => throw new InvalidOperationException("Ya estás en la fase de descanso.");
        public void Finalizar(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.Completado;
        public void SaltarFase(Pomodoro contexto) => contexto.EstadoFase = FasePomodoro.Completado;
    }

    public class EstadoCompletado : IEstadoPomodoro
    {
        public void Pausar(Pomodoro contexto) => throw new InvalidOperationException("El pomodoro ya finalizó.");

        // ACÁ CAMBIAMOS EL TEXTO PARA CUANDO INTENTEN INICIAR/REANUDAR
        public void Reanudar(Pomodoro contexto) => throw new InvalidOperationException("No se puede volver a iniciar un temporizador que ya finalizó.");

        public void Finalizar(Pomodoro contexto) => throw new InvalidOperationException("El pomodoro ya finalizó.");
        public void SaltarFase(Pomodoro contexto) => throw new InvalidOperationException("El pomodoro ya finalizó.");
    }
}
