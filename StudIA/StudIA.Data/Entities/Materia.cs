using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIA.Data.Entities
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public int IdUsuario { get; set; } // FK
        public string NombreMateria { get; set; } = null!;
        public string? Descripcion { get; set; }
        // Relaciones
        public Usuario Usuario { get; set; } = null!;
        public ICollection<Apunte> Apuntes { get; set; } = new List<Apunte>();
    }
}
}
