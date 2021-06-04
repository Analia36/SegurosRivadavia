using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionSiniestros.AccesoDatos
{
    class AsociadosMetodos:conexionbd
    {
        #region consultas

        public DataTable ConsultarPorNumeroPoliza(int numeroPoliza) /*consultar por patente (modificar)*/
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();            
            string sqlStr = "SELECT a.Nombre, a.Apellido, a.Dni, a.Telefono, a.email, p.cobertura, p.id_vehiculo, " + 
                                    "d.Calle,d.Numero,d.Piso,d.Dpto, d.Provincia, d.Localidad, d.Cod_Postal "+
                               "FROM asociados a, " +
                                    "poliza p, "+
	                                "Domicilio d " +
                            "WHERE a.id = p.id_asociado " +
                                "and a.id_domicilio = d.Id " +
                                "and p.id = " + numeroPoliza;

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
