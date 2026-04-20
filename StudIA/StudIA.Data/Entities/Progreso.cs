using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIA.Data.Entities;

public class Progreso
{
    public int IdProgreso { get; set; }
    public int IdUsuario { get; set; }
    public int? IdMateria { get; set; } // Opcional para progreso general
    public float AvancePorcentual { get; set; }
    public string? Comentarios { get; set; }

    // Relaciones
    public Usuario Usuario { get; set; } = null!;
    public Materia? Materia { get; set; }
}