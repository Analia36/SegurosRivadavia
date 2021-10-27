using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
  public   class DenunciaMetodosDatos : Conexion
    {
        public DataTable ConsultarSiniestrosPorNumero(int Num_Siniestro)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = "SELECT v.Patente,v.Marca,v.Modelo, s.Fecha,s.Declaracion,s.Lugar,s.id_poliza as poliza, p.fecha_inicio,p.fecha_fin, e.tipo as estado " +
                            "FROM asociados   a      " +
                            "INNER JOIN poliza p " +
                            "    ON a.id = p.id_asociado " +
                            "inner join  vehiculo v " +
                            "    on p.id_vehiculo = v.Id " +
                            "inner join Siniestro s " +
                            "    on s.id_poliza = p.Id " +
                            "inner join Estado e " +
                            "   on e.id = s.id_estado " +
                            "WHERE Num_Siniestro = " + Num_Siniestro +
                            "ORDER BY " +
                            "    fecha DESC";
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
