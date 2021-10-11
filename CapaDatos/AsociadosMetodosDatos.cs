using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class AsociadosMetodosDatos: Conexion
    {
        #region consultas

        public DataTable ConsultarPorNumeroDni(int dni) /*consultar por patente (modificar)*/
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();            
            string sqlStr = "select a.id,"+
                            "a.Nombre,"+
                            "a.Apellido," +
                            "a.Dni," +
                            "a.Telefono," +
                            "a.email," +
                            "d.Calle," +
                            "d.Numero," +
                            "d.Piso," +
                            "d.Dpto," +
                            "d.Provincia," +
                            "d.Localidad," +
                            "d.Calle," +
                            "d.Barrio," +
                            "d.Pais" +
                         " from Asociados a,"+
                          " Domicilio d"+
                        " where a.id_domicilio = d.id"+
                         " and a.Dni =" + dni;

            try
            {

                var da = new SqlDataAdapter(sqlStr, conectar());
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }

            return dt;
        }

        public DataTable ConsultarPorNumeroDni()
        {
            throw new NotImplementedException();
        }

        public DataTable Login(String usuario, string password)
        {
            string queryString = "select count(*) from login where usuario ='" + usuario + "' and password ='" + password + "'";


            SqlDataAdapter da = new SqlDataAdapter(queryString,conectar());

            DataTable dt = new DataTable();
            da.Fill(dt);           

            return dt;
        }


        #endregion
    }
}
