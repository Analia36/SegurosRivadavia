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
    public class InformePericiaNegocio
    {

        ADInformePericiaDatos objIPD = new ADInformePericiaDatos();
        
        public DataTable InsertarInformePericia()
        {
            return objIPD.InsertarInformePericia();
        }

        public void InsertarArchivo(String numSiniestro, String fileLocation, byte[] pdfFile)
        {
            objIPD.InsertarArchivo(numSiniestro, fileLocation, pdfFile);
        }

        public byte[] getDocument(int numSiniestro)
        {
            return objIPD.getDocument(numSiniestro);
        }

     }
}
