using System;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.Reporting.WinForms;

namespace GestionSiniestros.Pantallas
{
    
    public partial class DenunciaAdminViewer : Form
    {
        private int numSiniestro;
        public DenunciaAdminViewer( int numSiniestro )
        {
            InitializeComponent();
            this.numSiniestro = numSiniestro;
        }

        private void DenunciaAdminViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnDenAdm_Click(object sender, EventArgs e)
        {
            var met = new DenunciaAdmMetodosNegocio();
            var dt = met.ConsultarDenuncia(this.numSiniestro);

            var reportPath = "GestionSiniestros.Reportes.DenunciaAdmReporte.rdlc";
         //   ReportDataSource sReportDataSource = new ReportDataSource();
            ReportDataSource sReportDataSource = new ReportDataSource("DenunciaAdministrativa", dt);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;            
          //  sReportDataSource.Name = "DenunciaAdministrativa";
           // sReportDataSource.Value = dt; //.Tables[0];
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
            
            reportViewer1.RefreshReport();
        }
    }
}
