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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menúfrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeSiniestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSiniestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.gestiónDeVehiculosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(635, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeSiniestroToolStripMenuItem,
            this.consultarSiniestrosToolStripMenuItem,
            this.ampliacionToolStripMenuItem});
            this.ingresoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ingresoToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.ingresoToolStripMenuItem.Text = "Siniestros";
            // 
            // registroDeSiniestroToolStripMenuItem
            // 
            this.registroDeSiniestroToolStripMenuItem.Name = "registroDeSiniestroToolStripMenuItem";
            this.registroDeSiniestroToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registroDeSiniestroToolStripMenuItem.Text = "Registro de Siniestro";
            this.registroDeSiniestroToolStripMenuItem.Click += new System.EventHandler(this.registroDeSiniestroToolStripMenuItem_Click);
            // 
            // consultarSiniestrosToolStripMenuItem
            // 
            this.consultarSiniestrosToolStripMenuItem.Name = "consultarSiniestrosToolStripMenuItem";
            this.consultarSiniestrosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.consultarSiniestrosToolStripMenuItem.Text = "Consultar Siniestros";
            this.consultarSiniestrosToolStripMenuItem.Click += new System.EventHandler(this.consultarSiniestrosToolStripMenuItem_Click);
            // 
            // ampliacionToolStripMenuItem
            // 
            this.ampliacionToolStripMenuItem.Name = "ampliacionToolStripMenuItem";
            this.ampliacionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ampliacionToolStripMenuItem.Text = "Ampliacion Denuncia";
            this.ampliacionToolStripMenuItem.Click += new System.EventHandler(this.ampliacionToolStripMenuItem_Click);
            // 
            // gestiónDeVehiculosToolStripMenuItem
            // 
            this.gestiónDeVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarInformeToolStripMenuItem,
            this.registroDeVehiculoToolStripMenuItem});
            this.gestiónDeVehiculosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gestiónDeVehiculosToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.gestiónDeVehiculosToolStripMenuItem.Name = "gestiónDeVehiculosToolStripMenuItem";
            this.gestiónDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(157, 21);
            this.gestiónDeVehiculosToolStripMenuItem.Text = " Informe de Pericia";
            // 
            // consultarInformeToolStripMenuItem
            // 
            this.consultarInformeToolStripMenuItem.Name = "consultarInformeToolStripMenuItem";
            this.consultarInformeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultarInformeToolStripMenuItem.Text = "Consultar Informe";
            this.consultarInformeToolStripMenuItem.Click += new System.EventHandler(this.consultarInformeToolStripMenuItem_Click);
            // 
            // registroDeVehiculoToolStripMenuItem
            // 
            this.registroDeVehiculoToolStripMenuItem.Name = "registroDeVehiculoToolStripMenuItem";
            this.registroDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.registroDeVehiculoToolStripMenuItem.Text = "Resolución";
            this.registroDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registroDeVehiculoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menúfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(635, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palace Script MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menúfrm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.MediumBlue;
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
        private System.Windows.Forms.ToolStripMenuItem gestiónDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliacionToolStripMenuItem;
    }
}