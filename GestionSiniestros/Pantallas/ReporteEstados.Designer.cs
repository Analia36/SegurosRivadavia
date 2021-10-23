
namespace GestionSiniestros.Pantallas
{
    partial class ReporteEstados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporteEstado = new System.Windows.Forms.Button();
            this.btnGraEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(32, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnReporteEstado
            // 
            this.btnReporteEstado.Location = new System.Drawing.Point(43, 12);
            this.btnReporteEstado.Name = "btnReporteEstado";
            this.btnReporteEstado.Size = new System.Drawing.Size(75, 23);
            this.btnReporteEstado.TabIndex = 1;
            this.btnReporteEstado.Text = "Reporte";
            this.btnReporteEstado.UseVisualStyleBackColor = true;
            // 
            // btnGraEstado
            // 
            this.btnGraEstado.Location = new System.Drawing.Point(141, 12);
            this.btnGraEstado.Name = "btnGraEstado";
            this.btnGraEstado.Size = new System.Drawing.Size(75, 23);
            this.btnGraEstado.TabIndex = 2;
            this.btnGraEstado.Text = "Grafico";
            this.btnGraEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGraEstado.UseVisualStyleBackColor = true;
            // 
            // ReporteEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.btnGraEstado);
            this.Controls.Add(this.btnReporteEstado);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEstados";
            this.Text = "ReporteEstados";
            this.Load += new System.EventHandler(this.ReporteEstados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnReporteEstado;
        private System.Windows.Forms.Button btnGraEstado;
    }
}