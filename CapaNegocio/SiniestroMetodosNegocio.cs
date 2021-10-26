using System;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class SiniestroMetodosNegocio
    {
        SiniestroMetodosDatos objSMD = new SiniestroMetodosDatos();

        
        public void InsertarSiniestro(SiniestroEntidad siniestro)
        {
            objSMD.InsertarSiniestro(siniestro);
        }

        public DataTable ConsultarSiniestrosPorAsociado(int dni)
        {
            return objSMD.ConsultarSiniestrosPorAsociado(dni);
        }

        //consulstamos stros por asoc
        public DataTable ConsultarReporteDenuncia()
        {
            return objSMD.ConsultarReporteDenuncia();
        }


        public void updateFinalizarSiniestro(int v)
        {
            throw new NotImplementedException();
        }

        public object llenarBoxSubClaseCarnet(int valor)
        {
            throw new NotImplementedException();
        }

        public object llenarBoxClaseCarnet()
        {
            throw new NotImplementedException();
        }

        public void updateEstado(int v1, int v2, int idturno)
        {
            throw new NotImplementedException();
        }






}

}

         








