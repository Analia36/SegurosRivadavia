using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class SiniestroEntidad
    {
        public int numSiniestro { get; set; }
        public DateTime hora { get; set; }
        public DateTime fecha { get; set; }
        public String declaracion { get; set; }
        public String lugar { get; set; }
        public int idPoliza { get; set; }
        public int idInformePericia { get; set; }
        public int idEstado { get; set; }
        public int idTurno { get; set; }
        public String tipoSiniestro { get; set; }
        public String DetalleDanios { get; set; }
        public ConductorEntidad conductor { get; set; }
    }
}
