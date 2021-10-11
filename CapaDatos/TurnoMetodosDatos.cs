using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class TurnoMetodosDatos: Conexion
    {
        #region inserts
        public int InsertarTurno( TurnoInspeccionEntidad turno)

        {
            Int32 idDomicilio = 0;
            int idTurno = 0;
            using (SqlCommand cmd = new SqlCommand())

            {
                
                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Domicilio(Calle, Numero, Piso, Dpto, Provincia, Localidad, Cod_Postal)
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7);SELECT SCOPE_IDENTITY();";

                cmd.Parameters.AddWithValue("@param1", turno.domicilio.calle);
                cmd.Parameters.AddWithValue("@param2", turno.domicilio.numero);
                cmd.Parameters.AddWithValue("@param3", turno.domicilio.piso);
                cmd.Parameters.AddWithValue("@param4", turno.domicilio.dpto);
                cmd.Parameters.AddWithValue("@param5", turno.domicilio.provincia);
                cmd.Parameters.AddWithValue("@param6", turno.domicilio.localidad);
                cmd.Parameters.AddWithValue("@param7", turno.domicilio.codPostal);

                try
                {
                    //idDomicilio = cmd.ExecuteNonQuery();
                    idDomicilio = Convert.ToInt32(cmd.ExecuteScalar());

                    //int modified = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                                 
               
            

                cmd.Parameters.Clear();
                
                cmd.CommandText = @"INSERT INTO Turno_inspeccion(Hora, id_domicilio_inspeccion, id_perito, fecha, telefono_socio, telefono_perito)
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6);SELECT SCOPE_IDENTITY();";


                cmd.Parameters.AddWithValue("@param1", turno.hora);
                cmd.Parameters.AddWithValue("@param2", idDomicilio);
                cmd.Parameters.AddWithValue("@param3", turno.idPerito);
                cmd.Parameters.AddWithValue("@param4", turno.fecha);
                cmd.Parameters.AddWithValue("@param5", turno.telefono_socio);
                cmd.Parameters.AddWithValue("@param6", turno.telefono_perito);                



                try
                {
                    idTurno = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            return idTurno;       
        }

        public DataTable InsertarTurno()
        {
            throw new NotImplementedException();
        }
        #endregion


        public void bajaTurno(int numSiniestro)

        {
            using (SqlCommand cmd = new SqlCommand())

            {

                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"update Turno_inspeccion 
                                     set fecha_baja = getdate()
                                     where num_inspeccion in  ( select id_turno
                                                                  from Siniestro
				                                                  where Num_siniestro = @param1)";

                cmd.Parameters.AddWithValue("@param1", numSiniestro);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


       


        #region consultas

        public DataTable ConsultarTurno(int num_siniestro)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = " SELECT s.Num_siniestro,t.fecha,t.Hora,pe.Nombre,pe.apellido,pe.telefono " +
                            " FROM Turno_inspeccion t " +
                            " INNER JOIN Siniestro s " +
                            " ON t.Num_inspeccion = s.id_turno " +
                            " INNER JOIN Perito pe " +
                            " ON pe.Codigo = t.id_perito " +
                            " WHERE Num_siniestro = " + num_siniestro +
                            " AND fecha_baja is null"; 

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

        public DataTable llenarBoxPeritos()
        {
            DataTable dt = new DataTable();
            
            string sqlStr = "select zona,codigo"+
                             " from Perito"+
                             " order by codigo";

            try
            {

                var da = new SqlDataAdapter(sqlStr, conectar());
                da.Fill(dt);            
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
