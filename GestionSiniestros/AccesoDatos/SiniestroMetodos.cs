using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GestionSiniestros.AccesoDatos
{
    class SiniestroMetodos:conexionbd
    {
        #region consultas
        public void InsertarSiniestro(Siniestro siniestro)
        {
            using (SqlCommand cmd = new SqlCommand())

            {
                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Siniestro(Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado,tipo_siniestro,detalle_danios)
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";

                //INSERT INTO Siniestro(Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado)
                // VALUES(TRY_CONVERT(TIME, '12:05:06'), GETDATE(), 'Declaraion de prueba', 'Calle Rumipal barrio los naranjos', 4, 1)

                cmd.Parameters.AddWithValue("@param1", siniestro.hora);
                cmd.Parameters.AddWithValue("@param2", siniestro.fecha);
                cmd.Parameters.AddWithValue("@param3", siniestro.declaracion);
                cmd.Parameters.AddWithValue("@param4", siniestro.lugar);
                cmd.Parameters.AddWithValue("@param5", siniestro.idPoliza);
                cmd.Parameters.AddWithValue("@param6", siniestro.idEstado);
                cmd.Parameters.AddWithValue("@param7", siniestro.tipoSiniestro);
                cmd.Parameters.AddWithValue("@param8", siniestro.DetalleDanios);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // llenar con el resto de los campos

            }
        }

        public DataTable ConsultarSiniestrosPorAsociado(int dni)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = "select s.Num_siniestro as 'Número de Siniestro'," +
                            "s.fecha as Fecha," +
                             "s.lugar as Lugar," +
                             "e.Tipo as Estado," +
                             "v.Marca as Marca"+
                             "v.Modelo as Modelo" +
                             "v.Patente as Patente" +
                             "from Siniestro s, " +
                                   "Estado e, " +
                                   "vehiculo v,"+
                             "where s.id_estado = e.id " +
                             "and a.dni = " + dni +
                             " order by fecha desc ";



            /*"select s.Num_siniestro as 'Número de Siniestro'," +
                               "s.tipo_siniestro as 'Tipo de Siniestro'," +
                               "s.Hora as Hora," +
                               "s.fecha as Fecha,"+ 
                               "s.Declaracion as Declaración," +
                               "s.lugar as Lugar," +
                               "s.detalle_danios as 'Detalle de daños'," +
                               "s.id_poliza as Póliza," +
                               "e.Tipo as Estado," +
                               "s.id_informe_pericia as Pericia,"+
                               "s.id_turno as Turno " +
                          "from Siniestro s, "+
                               "Estado e, "+
                               "poliza p, "+
                               "Asociados a "+
                        "where s.id_estado = e.id "+
                          "and s.id_poliza = p.Id "+
                          "and a.id = p.id_asociado "+
                          "and a.dni = "+ dni +
                        " order by fecha desc " ; QUERY QUE ANDA */

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
