using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class SiniestroMetodosDatos: Conexion
    {
        #region consultas
        public void InsertarSiniestro(SiniestroEntidad siniestro)
        {
            int idSiniestro = 0;

            using (SqlCommand cmd = new SqlCommand())

            {
                cmd.Connection = conectar();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO Siniestro(Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado,tipo_siniestro,detalle_danios)
                            VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8);SELECT SCOPE_IDENTITY();";

                //INSERT INTO Siniestro(Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado)
                // VALUES(TRY_CONVERT(TIME, '12:05:06'), GETDATE(), 'Declaraion de prueba', 'Calle Rumipal barrio los naranjos', 4, 1)

                cmd.Parameters.AddWithValue("@param1", siniestro.Hora);
                cmd.Parameters.AddWithValue("@param2", siniestro.Fecha);
                cmd.Parameters.AddWithValue("@param3", siniestro.Declaracion);
                cmd.Parameters.AddWithValue("@param4", siniestro.Lugar);
                cmd.Parameters.AddWithValue("@param5", siniestro.id_poliza);
                cmd.Parameters.AddWithValue("@param6", siniestro.id_estado);
                cmd.Parameters.AddWithValue("@param7", siniestro.tipo_siniestro);
                cmd.Parameters.AddWithValue("@param8", siniestro.detalle_danios);

                try
                {
                    idSiniestro = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // llenar con el resto de los campos

                cmd.Parameters.Clear();

                cmd.CommandText = @"INSERT INTO Datos_conductor(dni,apellido,nombre,vto_licencia,id_clase,id_sub_clase, Num_siniestro)
                                    values(@param1,@param2,@param3,@param4,@param5,@param6,@param7);";

                cmd.Parameters.AddWithValue("@param1", siniestro.conductor.dni);
                cmd.Parameters.AddWithValue("@param2", siniestro.conductor.apellido);
                cmd.Parameters.AddWithValue("@param3", siniestro.conductor.nombre);
                cmd.Parameters.AddWithValue("@param4", siniestro.conductor.vtoLicencia);
                cmd.Parameters.AddWithValue("@param5", siniestro.conductor.idClase);
                cmd.Parameters.AddWithValue("@param6", siniestro.conductor.idSubclase);
                cmd.Parameters.AddWithValue("@param7", idSiniestro);
                                

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

        public void updateEstado(int numSiniestro, int estado, int idturno)
        {
            throw new NotImplementedException();
        }

        public void updateFinalizarSiniestro(int numSiniestro)
        {
            throw new NotImplementedException();
        }

        public DataTable InsertarSiniestro()
        {
            throw new NotImplementedException();
        }

        public DataTable ConsultarSiniestrosPorAsociado(int dni)
        {
            DataTable dt = new DataTable();
            var ds = new DataSet();
            string sqlStr = "SELECT v.Patente,v.Marca,v.Modelo,s.Num_siniestro,s.Fecha,s.Declaracion,s.Lugar,s.id_poliza as poliza, p.fecha_inicio,p.fecha_fin, e.tipo as estado " +
                            "FROM asociados a " +
                            "INNER JOIN poliza p " +
                            "    ON a.id = p.id_asociado " +
                            "inner join  vehiculo v " +
                            "    on p.id_vehiculo = v.Id " +
                            "inner join siniestro s " +
                            "    on s.id_poliza = p.Id " +
                            "inner join Estado e " +
                            "   on e.id = s.id_estado " +
                            "WHERE dni = " + dni +
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

        public DataTable llenarBoxClaseCarnet()
        {
            DataTable dt = new DataTable();

            string sqlStr = " select tipo, id " +
                            " from Clase_carnet ";

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

        public DataTable llenarBoxSubClaseCarnet(int idClase)
        {
            DataTable dt = new DataTable();

            string sqlStr = " select sc.id, sc.sub_clase+'-'+sc.descripcion as subclase " +
                            " from Sub_clase_carnet sc " +
                            " where sc.id_clase = "+idClase;

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


       public DataTable ConsultarReporteDenuncia()
         {

            //var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string sqlStr = "SELECT Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado,tipo_siniestro,detalle_danios  FROM Siniestro   ";
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




            //public DataTable ConsultarDenuncia()
            //{

            //    //var ds = new DataSet();
            //    var dt = new DataTable();
            //    try
            //    {
            //        string sqlStr = "SELECT Hora,Fecha,Declaracion,Lugar,id_poliza,id_estado,tipo_siniestro,detalle_danios  FROM Siniestro   ";
            //        //var c = AbrirConexion();
            //        var ds = new DataSet();
            //        var da = new SqlDataAdapter(sqlStr, conectar());
            //        ds = new DataSet();
            //        da.Fill(ds);
            //        dt = ds.Tables[0];

            //        return dt;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            //        return dt;
            //    }

                //agregando metodo para traer datos de la denunca consultada reporte
        }


    }

    }

