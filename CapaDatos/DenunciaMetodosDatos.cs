using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
  public   class DenunciaMetodosDatos : Conexion
    {
       

        public DataTable ConsultarDenuncia(int numSiniestro)
        {

            //var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string sqlStr = "SELECT s.*,e.Tipo as estadoDescripcion " +
                                " FROM Siniestro s " +
                                " inner join Estado e on(s.id_estado = e.id) " +
                                " where Num_siniestro = " + numSiniestro;
     
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

        }

    }
