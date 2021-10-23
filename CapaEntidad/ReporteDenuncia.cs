using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class ReporteDenuncia
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public int dni { get; set; }
        public int telefono { get; set; }
        public String email { get; set; }
        public int idDomicilio { get; set; }
         public int numSiniestro { get; set; }
        public DateTime hora { get; set; }
        public DateTime fecha { get; set; }
        public String declaracion { get; set; }
        public String lugar { get; set; }
        public int idPoliza { get; set; }

        public String tipoSiniestro { get; set; }
        public String DetalleDanios { get; set; }
        public ConductorEntidad conductor { get; set; }
    }
}
