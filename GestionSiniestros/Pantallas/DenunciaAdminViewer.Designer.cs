
namespace GestionSiniestros.Pantallas
{
    partial class DenunciaAdminViewer
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
            this.btnDenAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(817, 200);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnDenAdm
            // 
            this.btnDenAdm.Location = new System.Drawing.Point(12, 28);
            this.btnDenAdm.Name = "btnDenAdm";
            this.btnDenAdm.Size = new System.Drawing.Size(91, 27);
            this.btnDenAdm.TabIndex = 1;
            this.btnDenAdm.Text = "Denuncia";
            this.btnDenAdm.UseVisualStyleBackColor = true;
            this.btnDenAdm.Click += new System.EventHandler(this.btnDenAdm_Click);
            // 
            // DenunciaAdminViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 391);
            this.Controls.Add(this.btnDenAdm);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DenunciaAdminViewer";
            this.Text = "Denuncia";
            this.Load += new System.EventHandler(this.DenunciaAdminViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnDenAdm;
    }
}