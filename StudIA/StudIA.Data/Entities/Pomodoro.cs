using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIA.Data.Entities
{
    public class Pomodoro
    {
        public int IdPomodoro { get; set; }
        public int IdUsuario { get; set; }
        public int IdMateria { get; set; } // FK Obligatoria
        public int? IdApunte { get; set; }  // FK Opcional (Flexible)
        public DateTime Fecha { get; set; }
        public int DuracionEstudio { get; set; }
        public int DuracionDescanso { get; set; }
        // Relaciones
        public Materia Materia { get; set; } = null!;
        public Apunte? Apunte { get; set; }
    }
}
