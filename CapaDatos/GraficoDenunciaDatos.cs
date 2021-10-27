using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
  public class GraficoDenunciaDatos: Conexion
    {
        public DataTable ConsultarGraficoDen()
    {


        string sqlStr = "SELECT Num_siniestro, tipo_siniestro from Siniestro";

        var da = new SqlDataAdapter(sqlStr, conectar());
        var ds = new DataSet();
        da.Fill(ds);
        DataTable dt = ds.Tables[0];

        return dt;


    }
        //public DataTable ConsultarGraficoDen2()
        //{


        //    string sqlStr = "SELECT Num_siniestro, id_informe_pericia from Siniestro ";

        //    var da = new SqlDataAdapter(sqlStr, conectar());
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    DataTable dt = ds.Tables[0];

        //    return dt;


        }

    }




