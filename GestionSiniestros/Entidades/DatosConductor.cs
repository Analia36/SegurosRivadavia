using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSiniestros.Entidades
{
    class DatosConductor
    {
        public int dni { get; set; }
        public int idClase { get; set; }
        public int idSubclase { get; set; }
        public String apellido { get; set; }
        public String nombre { get; set; }
        public DateTime vtoLicencia { get; set; }
    }
}
