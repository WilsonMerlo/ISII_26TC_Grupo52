using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudIA.Data.Entities;

[Table("Usuarios")]
public class Usuario
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Required]
    [StringLength(100)]
    [Column("nombre")]
    public string Nombre { get; set; } = null!;

    [Required]
    [StringLength(150)]
    [Column("correo")]
    public string Correo { get; set; } = null!;

    [Required]
    [StringLength(255)]
    [Column("contraseña")]
    public string Contrasena { get; set; } = null!;

    // Relaciones
    public ICollection<Materia> Materias { get; set; } = new List<Materia>();
}