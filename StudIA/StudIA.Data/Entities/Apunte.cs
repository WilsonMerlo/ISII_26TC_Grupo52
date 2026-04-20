using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Apuntes")]
public class Apunte
{
    [Key]
    [Column("id_apunte")]
    public int IdApunte { get; set; }

    [Required]
    [Column("id_materia")]
    public int IdMateria { get; set; }

    [Required]
    [StringLength(100)]
    [Column("titulo")]
    public string Titulo { get; set; } = null!;

    [Required]
    [Column("contenido")]
    public string Contenido { get; set; } = null!;

    [Required]
    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; }

    // Relaciones
    [ForeignKey("IdMateria")]
    public Materia Materia { get; set; } = null!;
}