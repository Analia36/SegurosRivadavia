using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSiniestros
{
    class Domicilio
    {
        public int id { get; set; }
        public String calle { get; set; }
        public int numero { get; set; }
        public int piso { get; set; }
        public int dpto { get; set; }
        public String provincia { get; set; }
        public String localidad { get; set; }
        public int codPostal { get; set; }
        public string barrio { get; set; }
        public string pais { get; set; }
        public string interseccion { get; set; }
    }
}
