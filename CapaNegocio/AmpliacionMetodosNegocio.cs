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
        public DataTable ConsultarAmpliacionReporte(int numSiniestro)
        {
                return ObjAMD.ConsultarAmpliacionReporte(numSiniestro);
        }




    }


    }

    

