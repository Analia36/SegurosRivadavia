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
    public partial class GraficoEstadoViewer : Form
    {
        public GraficoEstadoViewer()
        {
            InitializeComponent();
        }

        private void GraficoEstadoViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void btnRepEs_Click(object sender, EventArgs e)
        {
            {
                var met = new GraficoEstadosNegocio();
                var dt = met.ConsultarReprteEs();

                var reportPath = "GestionSiniestros.Reportes.EstadosRdlc.rdlc";
                ReportDataSource sReportDataSource = new ReportDataSource();

                this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                sReportDataSource.Name = "DataSet1";
                sReportDataSource.Value = dt; //.Tables[0];
                reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
                reportViewer1.RefreshReport();

            }
        }

        private void btnGraEs_Click(object sender, EventArgs e)
        {
            {
                var met = new GraficoEstadosNegocio();
                var dt = met.ConsultarGraficoEs();

                var reportPath = "GestionSiniestros.Reportes.GraficoEstados.rdlc";
                ReportDataSource sReportDataSource = new ReportDataSource();

                this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                sReportDataSource.Name = "DataSet1";
                sReportDataSource.Value = dt; //.Tables[0];
                reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
                reportViewer1.RefreshReport();
                // en grafico relacionamos fecha 
            }
        }
    }

}
