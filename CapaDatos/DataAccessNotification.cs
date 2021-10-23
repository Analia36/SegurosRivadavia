using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DataAccessNotification:Conexion
    {

        #region queries

        public DataSet getSiniestrosANotificar(int days)
        {

           string sqlStr = "select s.* " +
                           "  from[Seguros_Rivadavia].[dbo].[Siniestro] s " +
                           " where id_turno is null " +
                           "   and DATEDIFF(day, fecha, getdate()) > " + days +
                           "   order by fecha" ;
           DataSet ds = new DataSet();
           SqlDataAdapter data = new SqlDataAdapter(sqlStr, conectar());
           data.Fill(ds);
           return ds;

        }


        public DataSet getSiniestrosSinFinalizarANotificar(int days)
        {

            string sqlStr = "SELECT num_siniestro," +
                            " s.fecha as fechaSiniestro, " +
		                    " t.fecha as fechaTurno " +
                            " FROM SINIESTRO S " +
                            "    INNER JOIN Turno_inspeccion t on(s.id_turno = t.Num_inspeccion) " +
                            " WHERE DATEDIFF(day, t.fecha, getdate()) > " + days +
                            "  and id_estado<> 3"; 
            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter(sqlStr, conectar());
            data.Fill(ds);
            return ds;

        }


        #endregion
    }
}
