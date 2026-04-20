using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudIA.Data.Entities
{
    public class Materia
    {
        public int IdMateria { get; set; }

        [ForeignKey("Usuario")] // Esto soluciona el error
        public int IdUsuario { get; set; }

        public string NombreMateria { get; set; } = null!;
        public string? Descripcion { get; set; }

        public Usuario Usuario { get; set; } = null!;
        public ICollection<Apunte> Apuntes { get; set; } = new List<Apunte>();
    }
}
