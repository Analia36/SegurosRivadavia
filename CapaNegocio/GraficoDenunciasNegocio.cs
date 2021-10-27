using System;
using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class GraficoDenunciasNegocio

    {

        GraficoDenunciaDatos objGraDen = new GraficoDenunciaDatos();



        public DataTable ConsultarGraficoDen()
        {
            return objGraDen.ConsultarGraficoDen();
        }

        //public DataTable ConsultarGraficoDen2()
        //{
        //    return objGraDen.ConsultarGraficoDen2();
        //}
    }
}
