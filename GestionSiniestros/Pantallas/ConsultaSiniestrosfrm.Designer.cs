namespace GestionSiniestros.Pantallas
{
    partial class ConsultaSiniestrosfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSiniestrosfrm));
            this.lbDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvSiniestro = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnConsultarTurno = new System.Windows.Forms.Button();
            this.dgvConsultarTurno = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnResolucion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiniestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDni.Location = new System.Drawing.Point(118, 47);
            this.lbDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(32, 17);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "Dni";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(176, 43);
            this.tbDni.Margin = new System.Windows.Forms.Padding(4);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(132, 23);
            this.tbDni.TabIndex = 1;
            this.tbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.DimGray;
            this.btnConsultar.Location = new System.Drawing.Point(329, 35);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 32);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvSiniestro
            // 
            this.dgvSiniestro.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvSiniestro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSiniestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiniestro.Location = new System.Drawing.Point(90, 192);
            this.dgvSiniestro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSiniestro.Name = "dgvSiniestro";
            this.dgvSiniestro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiniestro.Size = new System.Drawing.Size(1034, 183);
            this.dgvSiniestro.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Location = new System.Drawing.Point(1023, 398);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAmpliar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAmpliar.FlatAppearance.BorderSize = 2;
            this.btnAmpliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmpliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpliar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAmpliar.Location = new System.Drawing.Point(88, 398);
            this.btnAmpliar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(180, 32);
            this.btnAmpliar.TabIndex = 5;
            this.btnAmpliar.Text = "Ampliación de denuncia";
            this.btnAmpliar.UseVisualStyleBackColor = false;
            this.btnAmpliar.Click += new System.EventHandler(this.btnAmpliar_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTurno.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnTurno.FlatAppearance.BorderSize = 2;
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurno.ForeColor = System.Drawing.Color.DimGray;
            this.btnTurno.Location = new System.Drawing.Point(300, 398);
            this.btnTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(200, 32);
            this.btnTurno.TabIndex = 6;
            this.btnTurno.Text = "Turno de inspección";
            this.btnTurno.UseVisualStyleBackColor = false;
            this.btnTurno.Click += new System.EventHandler(this.btnIngresarTurno_Click);
            // 
            // btnConsultarTurno
            // 
            this.btnConsultarTurno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarTurno.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultarTurno.FlatAppearance.BorderSize = 2;
            this.btnConsultarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTurno.ForeColor = System.Drawing.Color.DimGray;
            this.btnConsultarTurno.Location = new System.Drawing.Point(554, 398);
            this.btnConsultarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarTurno.Name = "btnConsultarTurno";
            this.btnConsultarTurno.Size = new System.Drawing.Size(137, 32);
            this.btnConsultarTurno.TabIndex = 7;
            this.btnConsultarTurno.Text = "Consultar turno";
            this.btnConsultarTurno.UseVisualStyleBackColor = false;
            this.btnConsultarTurno.Click += new System.EventHandler(this.btnConsultarTurno_Click);
            // 
            // dgvConsultarTurno
            // 
            this.dgvConsultarTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultarTurno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultarTurno.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvConsultarTurno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultarTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultarTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarTurno.Location = new System.Drawing.Point(90, 448);
            this.dgvConsultarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultarTurno.Name = "dgvConsultarTurno";
            this.dgvConsultarTurno.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarTurno.Size = new System.Drawing.Size(1033, 183);
            this.dgvConsultarTurno.TabIndex = 8;
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaja.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBaja.FlatAppearance.BorderSize = 2;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.DimGray;
            this.btnBaja.Location = new System.Drawing.Point(1024, 647);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 32);
            this.btnBaja.TabIndex = 9;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnResolucion
            // 
            this.btnResolucion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResolucion.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnResolucion.FlatAppearance.BorderSize = 2;
            this.btnResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolucion.ForeColor = System.Drawing.Color.DimGray;
            this.btnResolucion.Location = new System.Drawing.Point(717, 398);
            this.btnResolucion.Margin = new System.Windows.Forms.Padding(4);
            this.btnResolucion.Name = "btnResolucion";
            this.btnResolucion.Size = new System.Drawing.Size(137, 32);
            this.btnResolucion.TabIndex = 10;
            this.btnResolucion.Text = "Resolver";
            this.btnResolucion.UseVisualStyleBackColor = false;
            this.btnResolucion.Click += new System.EventHandler(this.btnResolucion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaSiniestrosfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1191, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResolucion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dgvConsultarTurno);
            this.Controls.Add(this.btnConsultarTurno);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.btnAmpliar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvSiniestro);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbDni);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultaSiniestrosfrm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaSiniestros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiniestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvSiniestro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAmpliar;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnConsultarTurno;
        private System.Windows.Forms.DataGridView dgvConsultarTurno;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnResolucion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}