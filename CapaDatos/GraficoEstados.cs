using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.GraficoEstadosEntidad;

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
                string sqlStr = "SELECT Siniestro.Num_siniestro, Estado.Tipo ," +
                                "FROM Siniestro INNER JOIN Estado ON Siniestro.id_estado = Estado.id," +
                                "ORDER BY Estado.Tipo ";
                                

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


            string sqlStr = "SELECT Num_siniestro, id_estado from Siniestro ";

            var da = new SqlDataAdapter(sqlStr, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;


        }


    }



}



