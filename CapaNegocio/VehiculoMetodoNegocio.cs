using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class VehiculoMetodoNegocio
    {
        VehiculoMetodosDatos objVMD = new VehiculoMetodosDatos();

        public DataTable ConsultarVehiculos(int id)
        {
            return objVMD.ConsultarVehiculos(id);
        }
    }
}
