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

        public DataTable consultarhistorial(int Num_siniestro)
        {
            return ObjAMD.consultarhistorial(Num_siniestro);
        }
    }
}
