using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using StudIA.Data.Entities;

[Table("Materias")]
public class Materia
{
    [Key]
    [Column("id_materia")]
    public int IdMateria { get; set; }

    [Required]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Required]
    [StringLength(100)]
    [Column("nombre_materia")]
    public string NombreMateria { get; set; } = null!;

    [Column("descripcion")]
    public string? Descripcion { get; set; } // Tipo 'text' en SQL mapea a string

    // Relaciones
    [JsonIgnore]
    [ForeignKey("IdUsuario")]
    public Usuario? Usuario { get; set; }

    [JsonIgnore]
    public ICollection<Apunte> Apuntes { get; set; } = new List<Apunte>();
}