using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class VehiculoMetodosDatos: Conexion
    {
        #region consultas

        public DataTable ConsultarVehiculos(int id)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = "select v.marca as Marca,v.Modelo,v.Anio,v.Color,v.Patente,p.Id as Poliza,p.cobertura as Cobertura"+
                            " from vehiculo v,"+
                             "poliza p" +
                            " where v.Id = p.id_vehiculo"+
                            " and id_asociado = " + id;

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

        public DataTable ConsultarVehiculos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
