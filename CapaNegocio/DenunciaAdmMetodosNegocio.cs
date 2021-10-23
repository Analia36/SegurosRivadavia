using System;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class DenunciaAdmMetodosNegocio
    {

        DenunciaMetodosDatos obdDen = new DenunciaMetodosDatos();

        public DataTable ConsultarDenuncia()
        {
            return obdDen.ConsultarDenuncia();
    }

        public DataTable ConsultarSiniestrosPorNumero(int Num_Siniestro)
        {
            return obdDen.ConsultarSiniestrosPorNumero(Num_Siniestro);
    }
}

}

