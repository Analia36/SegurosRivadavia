using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.Reporting.WinForms;

namespace GestionSiniestros.Pantallas
{
    public partial class DenunciaAdminViewer : Form
    {
        public DenunciaAdminViewer()
        {
            InitializeComponent();
        }

        private void DenunciaAdminViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnDenAdm_Click(object sender, EventArgs e)
        {
            var met = new DenunciaAdmMetodosNegocio();
            var dt = met.ConsultarDenuncia();

            var reportPath = "GestionSiniestros.Reportes.DenunciaAdmReporte.rdlc";
            ReportDataSource sReportDataSource = new ReportDataSource();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            sReportDataSource.Name = "DenunciaAdministrativa";
            sReportDataSource.Value = dt; //.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
