using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GestionSiniestros
{
    class ADInformePericia : conexionbd
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

        #region insertar

        public void InsertarArchivo(String numSiniestro,String fileLocation, byte[] pdfFile)
        {
            using (SqlCommand cmd = new SqlCommand())

            {
                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT into dbo.TB_Archivo (nombre, archivo,numSiniestro) VALUES (@param1,@param2,@param3)";


                cmd.Parameters.AddWithValue("@param1", fileLocation);
                cmd.Parameters.AddWithValue("@param2", pdfFile);
                cmd.Parameters.AddWithValue("@param3", numSiniestro);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }        

            }

        }
        #endregion

        #region

        public byte[] getDocument(int numSiniestro)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                {
                    cmd.Connection = conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"select archivo from TB_Archivo where numSiniestro = @siniestro";
                    cmd.Parameters.AddWithValue("@siniestro", numSiniestro);
                    return cmd.ExecuteScalar() as byte[];
                }
            }
        }

        #endregion

    }
}
