using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSiniestros.Pantallas
{
    public partial class ReporteEstados : Form
    {
        public ReporteEstados()
        {
            InitializeComponent();
        }

        private void ReporteEstados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
