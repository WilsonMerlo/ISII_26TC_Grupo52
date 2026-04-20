using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudIA.Data.Entities
{
    public class Apunte
    {
        [Key] // <--- Agregá esto
        public int IdApunte { get; set; }

        public int IdMateria { get; set; }
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public Materia Materia { get; set; } = null!;
    }
}
