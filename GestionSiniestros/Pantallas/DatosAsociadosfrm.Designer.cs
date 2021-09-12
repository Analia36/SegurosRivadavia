namespace GestionSiniestros.Pantallas
{
    partial class DatosAsociadosfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAsociadosfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.dtvasociado = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.laDni = new System.Windows.Forms.Label();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvasociado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "DATOS DE ASOCIADO";
            // 
            // dtvasociado
            // 
            this.dtvasociado.AllowUserToAddRows = false;
            this.dtvasociado.AllowUserToDeleteRows = false;
            this.dtvasociado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvasociado.Location = new System.Drawing.Point(20, 196);
            this.dtvasociado.Margin = new System.Windows.Forms.Padding(2);
            this.dtvasociado.Name = "dtvasociado";
            this.dtvasociado.ReadOnly = true;
            this.dtvasociado.RowHeadersWidth = 51;
            this.dtvasociado.RowTemplate.Height = 24;
            this.dtvasociado.Size = new System.Drawing.Size(648, 76);
            this.dtvasociado.TabIndex = 30;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnbuscar.FlatAppearance.BorderSize = 2;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.DimGray;
            this.btnbuscar.Location = new System.Drawing.Point(592, 23);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(76, 28);
            this.btnbuscar.TabIndex = 29;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(496, 28);
            this.tbdni.Margin = new System.Windows.Forms.Padding(2);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(76, 20);
            this.tbdni.TabIndex = 28;
            this.tbdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // laDni
            // 
            this.laDni.AutoSize = true;
            this.laDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laDni.Location = new System.Drawing.Point(424, 30);
            this.laDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDni.Name = "laDni";
            this.laDni.Size = new System.Drawing.Size(34, 17);
            this.laDni.TabIndex = 27;
            this.laDni.Text = "DNI";
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Location = new System.Drawing.Point(20, 334);
            this.dgvVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculo.Size = new System.Drawing.Size(648, 76);
            this.dgvVehiculo.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "DATOS DE VEHÍCULO";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 2;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.Location = new System.Drawing.Point(23, 436);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 30);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Location = new System.Drawing.Point(127, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 30);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(20, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(285, 142);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 37;
            this.pbFoto.TabStop = false;
            // 
            // DatosAsociadosfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(717, 476);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvasociado);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.laDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatosAsociadosfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dtvasociado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvasociado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox tbdni;
        private System.Windows.Forms.Label laDni;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}