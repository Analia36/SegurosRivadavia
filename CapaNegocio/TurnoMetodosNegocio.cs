using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class TurnoMetodosNegocio
    {
        TurnoMetodosDatos objTMD = new TurnoMetodosDatos();

        public int InsertarTurno(TurnoInspeccionEntidad turno)
        {
            return objTMD.InsertarTurno(turno);
        }

        public DataTable ConsultarTurno(int num_siniestro)
        {

            return objTMD.ConsultarTurno(num_siniestro);
        }

        public void bajaTurno(int numSiniestro)
        {
            objTMD.bajaTurno(numSiniestro);
        }

        public DataTable llenarBoxPeritos()
        {
            return objTMD.llenarBoxPeritos();
        }

     }
}
