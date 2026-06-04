using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudIA.Data.Entities;

[Table("Progresos")]
public class Progreso
{
    [Key]
    [Column("id_progreso")]
    public int IdProgreso { get; set; }

    [Required]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Required]
    [Column("id_materia")]
    public int IdMateria { get; set; }

    [Required]
    [Column("segundos_acumulados")]
    public int SegundosAcumulados { get; set; }

    // Relaciones
    [ForeignKey("IdUsuario")]
    public Usuario Usuario { get; set; } = null!;
    [ForeignKey("IdMateria")]
    public Materia Materia { get; set; } = null!;
}