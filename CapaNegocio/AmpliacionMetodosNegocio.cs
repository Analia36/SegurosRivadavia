using System;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class AmpliacionMetodosNegocio
    {
        AmpliacionMetodosDatos ObjAMD = new AmpliacionMetodosDatos();

        public DataTable insertarAmpliacion(AmpliacionEntidad ampliacion)
        {
            return ObjAMD.insertarAmpliacion();
        }

        public DataTable consultarhistorial(int Num_Siniestro)
        {
            return ObjAMD.consultarhistorial(Num_Siniestro);
        }
        public DataTable ConsultarAmpliacionReporte()
        {
                return ObjAMD.ConsultarAmpliacionReporte();
            }




        //public object ConsultarAmpliacionReporte()
        //{
        //    throw new NotImplementedException();


        //public object ConsultarAmpliacionReporte()
        //{
        //    throw new NotImplementedException();
        //}


        //   public DataTable ConsultarAmpliacionReporteNum()

        //        {

        //        return objAMD.ConsultarAmpliacionReporteNum();
        //}
    }


    }

    

