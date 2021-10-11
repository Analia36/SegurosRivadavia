using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TurnoInspeccionEntidad
    {
        public int numInspeccion { get; set; }
        public DateTime hora { get; set; }
        public int idDomicilioInspeccion { get; set; }
        public int idPerito { get; set; }
        public DateTime fecha { get; set; }
        public int telefono_socio { get; set; }
        public int telefono_perito { get; set; }
        public DomicilioEntidad domicilio { get; set; }
    }
}
