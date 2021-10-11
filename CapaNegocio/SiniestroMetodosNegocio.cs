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

        public void updateEstado(int numSiniestro, int estado, int idturno)
        {
            objSMD.updateEstado(numSiniestro,estado,idturno);
        }

        public DataTable llenarBoxClaseCarnet()
        {
           return objSMD.llenarBoxClaseCarnet();
        }

        public DataTable llenarBoxSubClaseCarnet(int idClase)
        {
            return objSMD.llenarBoxSubClaseCarnet(idClase);
        }


        public void updateFinalizarSiniestro(int numSiniestro)
        {
            objSMD.updateFinalizarSiniestro(numSiniestro);
        }

     }
}
