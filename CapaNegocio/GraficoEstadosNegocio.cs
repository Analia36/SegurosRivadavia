using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;



namespace CapaNegocio
{
    public class GraficoEstadosNegocio
    {

        GraficoEstados objEs = new GraficoEstados();

        public DataTable ConsultarReprteEs()
            {
            return objEs.ConsultarReprteEs();
        }


        public DataTable ConsultarGraficoEs()
        {
            return objEs.ConsultarGraficoEs();
        }
    }


}
