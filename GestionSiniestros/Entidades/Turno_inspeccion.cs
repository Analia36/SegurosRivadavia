using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSiniestros
{
    class Turno_inspeccion
    {
        public int numInspeccion { get; set; }
        public DateTime hora { get; set; }
        public int idDomicilioInspeccion { get; set; }
        public int idPerito { get; set; }
    }
}
