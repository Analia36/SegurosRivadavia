
namespace GestionSiniestros.Pantallas
{
    partial class AmpliacionViewer
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
            this.Ampliacion = new System.Windows.Forms.Button();
            this.Grafico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(50, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Ampliacion
            // 
            this.Ampliacion.Location = new System.Drawing.Point(64, 13);
            this.Ampliacion.Name = "Ampliacion";
            this.Ampliacion.Size = new System.Drawing.Size(75, 23);
            this.Ampliacion.TabIndex = 1;
            this.Ampliacion.Text = "Ampliacion";
            this.Ampliacion.UseVisualStyleBackColor = true;
            this.Ampliacion.Click += new System.EventHandler(this.Ampliacion_Click);
            // 
            // Grafico
            // 
            this.Grafico.Location = new System.Drawing.Point(202, 13);
            this.Grafico.Name = "Grafico";
            this.Grafico.Size = new System.Drawing.Size(75, 23);
            this.Grafico.TabIndex = 2;
            this.Grafico.Text = "Grafico";
            this.Grafico.UseVisualStyleBackColor = true;
            // 
            // AmpliacionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grafico);
            this.Controls.Add(this.Ampliacion);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AmpliacionViewer";
            this.Text = "AmpliacionViewer";
            this.Load += new System.EventHandler(this.AmpliacionViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button Ampliacion;
        private System.Windows.Forms.Button Grafico;
    }
}