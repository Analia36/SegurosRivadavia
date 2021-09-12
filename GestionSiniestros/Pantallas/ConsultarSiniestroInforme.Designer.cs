namespace GestionSiniestros.Pantallas
{
    partial class ConsultarSiniestroInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarSiniestroInforme));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.dgvSiniestro = new System.Windows.Forms.DataGridView();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiniestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.DimGray;
            this.btnConsultar.Location = new System.Drawing.Point(215, 13);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(75, 18);
            this.tbDni.Margin = new System.Windows.Forms.Padding(4);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(132, 20);
            this.tbDni.TabIndex = 4;
            this.tbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDni.Location = new System.Drawing.Point(23, 22);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(33, 13);
            this.lbDni.TabIndex = 6;
            this.lbDni.Text = "DNI *";
            // 
            // dgvSiniestro
            // 
            this.dgvSiniestro.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvSiniestro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSiniestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiniestro.Location = new System.Drawing.Point(16, 55);
            this.dgvSiniestro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSiniestro.Name = "dgvSiniestro";
            this.dgvSiniestro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiniestro.Size = new System.Drawing.Size(684, 148);
            this.dgvSiniestro.TabIndex = 7;
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInforme.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnInforme.FlatAppearance.BorderSize = 2;
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.ForeColor = System.Drawing.Color.DimGray;
            this.btnInforme.Location = new System.Drawing.Point(16, 210);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(116, 31);
            this.btnInforme.TabIndex = 8;
            this.btnInforme.Text = "Ver o Cargar Informe";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Location = new System.Drawing.Point(138, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 31);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ptbFoto
            // 
            this.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFoto.Image = ((System.Drawing.Image)(resources.GetObject("ptbFoto.Image")));
            this.ptbFoto.Location = new System.Drawing.Point(321, 210);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(329, 106);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 10;
            this.ptbFoto.TabStop = false;
            // 
            // ConsultarSiniestroInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(714, 328);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.dgvSiniestro);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tbDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarSiniestroInforme";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarSiniestroInforme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiniestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.DataGridView dgvSiniestro;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox ptbFoto;
    }
}