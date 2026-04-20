using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIA.Data.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        // Relación: 1 Usuario tiene muchas Materias
        public ICollection<Materia> Materias { get; set; } = new List<Materia>();
    }
}
