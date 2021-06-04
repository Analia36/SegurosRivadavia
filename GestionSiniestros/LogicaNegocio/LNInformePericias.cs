using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionSiniestros
{
    class LNInformePericias
    {

        public void AltaInformePericia(Informe_pericia pericia)
        {
            conexionbd conexion = new conexionbd();
            SqlConnection conn = conexion.conectar();

            ADInformePericia InfPericia = new ADInformePericia();            

            InfPericia.InsertarInformePericia(pericia,conn);

            conn.Close();

        }
    }
}
