using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionSiniestros.AccesoDatos
{
    class VehiculoMetodos:conexionbd
    {
        #region consultas

        public DataTable ConsultarPorIdVehiculo(int id)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = "select marca, modelo,anio, color, patente, capital from vehiculo where id = " + id;

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
    }
}
