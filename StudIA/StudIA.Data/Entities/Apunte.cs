using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIA.Data.Entities
{
    public class Apunte
    {
        public int IdApunte { get; set; }
        public int IdMateria { get; set; } // FK
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        // Relaciones
        public Materia Materia { get; set; } = null!;
    }
}
