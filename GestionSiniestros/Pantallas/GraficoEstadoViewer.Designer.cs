
namespace GestionSiniestros.Pantallas
{
    partial class GraficoEstadoViewer
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
            this.btnRepEs = new System.Windows.Forms.Button();
            this.btnGraEs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(40, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnRepEs
            // 
            this.btnRepEs.Location = new System.Drawing.Point(63, 12);
            this.btnRepEs.Name = "btnRepEs";
            this.btnRepEs.Size = new System.Drawing.Size(75, 23);
            this.btnRepEs.TabIndex = 1;
            this.btnRepEs.Text = "Reporte";
            this.btnRepEs.UseVisualStyleBackColor = true;
            this.btnRepEs.Click += new System.EventHandler(this.btnRepEs_Click);
            // 
            // btnGraEs
            // 
            this.btnGraEs.Location = new System.Drawing.Point(171, 12);
            this.btnGraEs.Name = "btnGraEs";
            this.btnGraEs.Size = new System.Drawing.Size(75, 23);
            this.btnGraEs.TabIndex = 2;
            this.btnGraEs.Text = "Grafico";
            this.btnGraEs.UseVisualStyleBackColor = true;
            this.btnGraEs.Click += new System.EventHandler(this.btnGraEs_Click);
            // 
            // GraficoEstadoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraEs);
            this.Controls.Add(this.btnRepEs);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GraficoEstadoViewer";
            this.Text = "GraficoEstadoViewer";
            this.Load += new System.EventHandler(this.GraficoEstadoViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnRepEs;
        private System.Windows.Forms.Button btnGraEs;
    }
}