using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class SiniestroEntidad
    {
        public int Num_siniestro { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Fecha { get; set; }
        public String Declaracion { get; set; }
        public String Lugar { get; set; }
        public int id_poliza { get; set; }
        public int id_informe_pericia { get; set; }
        public int id_estado { get; set; }
        public int id_turno { get; set; }
        public String tipo_siniestro { get; set; }
        public String detalle_danios { get; set; }
        public ConductorEntidad conductor { get; set; }
        public String estadoDescripcion { get; set; }
    }
}
