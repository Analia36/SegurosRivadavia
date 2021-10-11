using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class AsociadosMetodosNegocio
    {
        AsociadosMetodosDatos objAMD = new AsociadosMetodosDatos();

        public DataTable ConsultarPorNumeroDni (int dni)
        {
            return objAMD.ConsultarPorNumeroDni(dni);
        }

        public DataTable Login(String usuario, string password)
        {
            return objAMD.Login(usuario,password);
        }
    }
}
