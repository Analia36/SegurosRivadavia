using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;


namespace CapaDatos
{
    public class ADInformePericiaDatos:Conexion
    {
        public void InsertarInformePericia(InformePericiaEntidad pericia, SqlConnection conn)
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

        public DataTable InsertarInformePericia()
        {
            throw new NotImplementedException();
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
