using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionSiniestros
{
    class ADInformePericia
    {
        public void InsertarInformePericia(Informe_pericia pericia, SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand())

            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Informe_pericia(Resolucion)
                            VALUES(@param1)";

                cmd.Parameters.AddWithValue("@param1", pericia.resolucion);                           
                cmd.ExecuteNonQuery();                                          

            }
        }
    }
}
