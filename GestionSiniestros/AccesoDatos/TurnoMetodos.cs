using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSiniestros.AccesoDatos
{
    class TurnoMetodos: conexionbd
    {
        #region consultas
        public void InsertarTurno(Turno_inspeccion turno)

        {
            Int32 idDomicilio = 0;
            using (SqlCommand cmd = new SqlCommand())

            {
                
                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Domiclio(Calle, Numero, Piso, Dpto, Provincia, Localidad, Cod_Postal)
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7)";

                cmd.Parameters.AddWithValue("@param1", turno.domicilio.calle);
                cmd.Parameters.AddWithValue("@param2", turno.domicilio.numero);
                cmd.Parameters.AddWithValue("@param3", turno.domicilio.piso);
                cmd.Parameters.AddWithValue("@param4", turno.domicilio.dpto);
                cmd.Parameters.AddWithValue("@param5", turno.domicilio.provincia);
                cmd.Parameters.AddWithValue("@param6", turno.domicilio.localidad);
                cmd.Parameters.AddWithValue("@param7", turno.domicilio.codPostal);

                try
                {
                    cmd.ExecuteNonQuery();
                    idDomicilio = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cmd.CommandText = @"INSERT INTO Turno_inspeccion(Hora, id_domicilio_inspeccion, id_perito, fecha, telefono_socio, telefono_perito, perito)
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7)";

              
                cmd.Parameters.AddWithValue("@param1", turno.hora);
                cmd.Parameters.AddWithValue("@param2", idDomicilio);
                cmd.Parameters.AddWithValue("@param3", turno.idPerito);
                cmd.Parameters.AddWithValue("@param4", turno.fecha);
                cmd.Parameters.AddWithValue("@param5", turno.telefono_socio);
                cmd.Parameters.AddWithValue("@param6", turno.telefono_perito);
                cmd.Parameters.AddWithValue("@param7", turno.perito);

                

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



        public DataTable ConsultarTurno(int DNI)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = "";

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
