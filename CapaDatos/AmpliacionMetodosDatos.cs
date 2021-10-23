using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;


namespace CapaDatos
 
{
    public class AmpliacionMetodosDatos : Conexion 
    {


        #region insertar 
        public void insertarAmpliacion( AmpliacionEntidad ampliacion)
        {

            using (SqlCommand cmd = new SqlCommand())

            {


       //         INSERT INTO Ampliacion(Num_siniestro, AmpliacionSin, Fecha)
       //VALUES(7, 'ampliacion', GETDATE());


                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Ampliacion(Num_siniestro, AmpliacionSin, Fecha)
                            VALUES(@param1,@param2,@param3,@param4)";

                cmd.Parameters.AddWithValue("@param1", ampliacion.id);
                cmd.Parameters.AddWithValue("@param2", ampliacion.Num_Siniestro);
                cmd.Parameters.AddWithValue("@param3", ampliacion.AmpliacionSin);
                cmd.Parameters.AddWithValue("@param4", ampliacion.Fecha);
                

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


            #endregion
        }

        public DataTable insertarAmpliacion()
        {
            throw new NotImplementedException();
        }
        #region consulta


        public DataTable consultarhistorial(int Num_Siniestro)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = " select  a.id as 'Id'," +
                      "a.Num_Siniestro as 'Número de Siniestro', " +
                     " a.fecha as Fecha," +
                     " a.AmpliacionSin as 'Ampliacion'" +
                      
                    " from Ampliacion a " +
                    " where " +
                    " a.Num_Siniestro = " + Num_Siniestro +
                    " order by fecha desc ";

            try
            {

                var da = new SqlDataAdapter(sqlStr, conectar());
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return dt;
        }



        #endregion

        public DataTable ConsultarAmpliacionReporte()
        {
            var dt = new DataTable();
            try
            {
                string sqlStr = "create procedure Ampliacion_Siniestro @Num_Siniestro int," +
                                 "as," +
                                 "begin," +
                                 "select Ampliacion.id, Ampliacion.Num_Siniestro, Ampliacion.AmpliacionSin, Ampliacion.Fecha, Siniestro.Num_siniestro," +
                                 "from Ampliacion," +
                                 "inner join Siniestro on Siniestro.Num_siniestro = Ampliacion.Num_Siniestro where Ampliacion.Num_Siniestro = @Param2";


                //var c = AbrirConexion();
                var ds = new DataSet();
                var da = new SqlDataAdapter(sqlStr, conectar());
                ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return dt;
            }



          
    }
}

}






