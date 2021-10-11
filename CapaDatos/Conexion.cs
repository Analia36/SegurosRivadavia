using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Conexion
    {
        private SqlConnection sCon = new SqlConnection();
        private string con = "Data Source=DESKTOP-F19K3V3; Initial Catalog=Seguros_Rivadavia; Integrated Security=true";
        /* variables de coexion que necesito configurar para conectar al sql server. 1° varaible, data source: definicion del nombre del servidor
         mas la conexion q hago a la base. La segunda variable, es la seguridad integrada: SSPI (que estoy usando la seguridad de windows.
         y la tercer variable es el catálogo inicial: le dice de mi motor de bd con q base me quiero conectar).
         Por otro lado el estring de conexión la definio con una constante por que la llena con un valor fijo.*/

        public SqlConnection conectar()
        {

            try
            {
                sCon = new SqlConnection(con);

                if (sCon.State.Equals(ConnectionState.Open))
                {
                    sCon.Close();
                }
                else
                {
                    sCon.Open();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            return sCon;
        }
    }
}
