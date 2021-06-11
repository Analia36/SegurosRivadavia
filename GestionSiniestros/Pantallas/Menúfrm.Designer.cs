namespace GestionSiniestros.Pantallas
{
    partial class Menúfrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeSiniestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSiniestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónAsociadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.gestiónAsociadosToolStripMenuItem,
            this.gestiónDeVehiculosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1183, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarSiniestrosToolStripMenuItem,
            this.registroDeSiniestroToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ingresoToolStripMenuItem.Text = "Siniestros";
            // 
            // registroDeSiniestroToolStripMenuItem
            // 
            this.registroDeSiniestroToolStripMenuItem.Name = "registroDeSiniestroToolStripMenuItem";
            this.registroDeSiniestroToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.registroDeSiniestroToolStripMenuItem.Text = "Registro de Siniestro";
            this.registroDeSiniestroToolStripMenuItem.Click += new System.EventHandler(this.registroDeSiniestroToolStripMenuItem_Click);
            // 
            // consultarSiniestrosToolStripMenuItem
            // 
            this.consultarSiniestrosToolStripMenuItem.Name = "consultarSiniestrosToolStripMenuItem";
            this.consultarSiniestrosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultarSiniestrosToolStripMenuItem.Text = "Consultar Siniestros";
            this.consultarSiniestrosToolStripMenuItem.Click += new System.EventHandler(this.consultarSiniestrosToolStripMenuItem_Click);
            // 
            // gestiónAsociadosToolStripMenuItem
            // 
            this.gestiónAsociadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTurnosToolStripMenuItem});
            this.gestiónAsociadosToolStripMenuItem.Name = "gestiónAsociadosToolStripMenuItem";
            this.gestiónAsociadosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.gestiónAsociadosToolStripMenuItem.Text = "Turnos de Inspección";
            // 
            // consultarTurnosToolStripMenuItem
            // 
            this.consultarTurnosToolStripMenuItem.Name = "consultarTurnosToolStripMenuItem";
            this.consultarTurnosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.consultarTurnosToolStripMenuItem.Text = "Consultar Turnos";
            // 
            // gestiónDeVehiculosToolStripMenuItem
            // 
            this.gestiónDeVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarInformeToolStripMenuItem,
            this.registroDeVehiculoToolStripMenuItem});
            this.gestiónDeVehiculosToolStripMenuItem.Name = "gestiónDeVehiculosToolStripMenuItem";
            this.gestiónDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gestiónDeVehiculosToolStripMenuItem.Text = " Informe de Pericia";
            // 
            // consultarInformeToolStripMenuItem
            // 
            this.consultarInformeToolStripMenuItem.Name = "consultarInformeToolStripMenuItem";
            this.consultarInformeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarInformeToolStripMenuItem.Text = "Consultar Informe";
            // 
            // registroDeVehiculoToolStripMenuItem
            // 
            this.registroDeVehiculoToolStripMenuItem.Name = "registroDeVehiculoToolStripMenuItem";
            this.registroDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.registroDeVehiculoToolStripMenuItem.Text = "Resolución";
            this.registroDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroDeVehiculoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menúfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menúfrm";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menúfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem registroDeSiniestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSiniestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónAsociadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}