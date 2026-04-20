using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudIA.Data.Entities;

[Table("Pomodoros")]
public class Pomodoro
{
    [Key]
    [Column("id_pomodoro")]
    public int IdPomodoro { get; set; }

    [Required]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Required]
    [Column("id_materia")]
    public int IdMateria { get; set; }

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

    [Required]
    [Column("estado")]
    public bool Estado { get; set; } // Según diccionario: true/false

    // Relaciones
    [ForeignKey("IdUsuario")]
    public Usuario Usuario { get; set; } = null!;
    [ForeignKey("IdMateria")]
    public Materia Materia { get; set; } = null!;
    [ForeignKey("IdApunte")]
    public Apunte? Apunte { get; set; }
}