using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;


namespace CapaDatos
{
    public class GraficoEstados : Conexion
    {


        public DataTable ConsultarReprteEs()
        {
            //var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string sqlStr = "SELECT count(1) as CantidadSiniestro, Estado.Tipo " +
                    
                    "FROM Siniestro INNER JOIN Estado ON Siniestro.id_estado = Estado.id  " +
                    " group BY Estado.Tipo ";



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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return dt;
            }




        }

        public DataTable ConsultarGraficoEs()
        {


            string sqlStr = "SELECT count(1) as CantidadSiniestro, Estado.Tipo " +

                    "FROM Siniestro INNER JOIN Estado ON Siniestro.id_estado = Estado.id  " +
                    " group BY Estado.Tipo ";

            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;


        }


    }



}



