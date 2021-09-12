namespace GestionSiniestros.Pantallas
{
    partial class ingresoTurnoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoTurnoFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumSiniestro = new System.Windows.Forms.TextBox();
            this.dtpFecha_turno = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHora_turno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbpais = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbprovincia = new System.Windows.Forms.ComboBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbobservacion = new System.Windows.Forms.TextBox();
            this.txtcodpost = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.cbbarrio = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_telefonoSocio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_perito = new System.Windows.Forms.ComboBox();
            this.txt_telefonoPerito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese número de siniestro";
            // 
            // txtNumSiniestro
            // 
            this.txtNumSiniestro.Enabled = false;
            this.txtNumSiniestro.Location = new System.Drawing.Point(267, 19);
            this.txtNumSiniestro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumSiniestro.Name = "txtNumSiniestro";
            this.txtNumSiniestro.Size = new System.Drawing.Size(265, 23);
            this.txtNumSiniestro.TabIndex = 1;
            this.txtNumSiniestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFecha_turno
            // 
            this.dtpFecha_turno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_turno.Location = new System.Drawing.Point(267, 59);
            this.dtpFecha_turno.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_turno.Name = "dtpFecha_turno";
            this.dtpFecha_turno.Size = new System.Drawing.Size(265, 23);
            this.dtpFecha_turno.TabIndex = 2;
            this.dtpFecha_turno.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // dtpHora_turno
            // 
            this.dtpHora_turno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_turno.Location = new System.Drawing.Point(267, 99);
            this.dtpHora_turno.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHora_turno.Name = "dtpHora_turno";
            this.dtpHora_turno.ShowUpDown = true;
            this.dtpHora_turno.Size = new System.Drawing.Size(265, 23);
            this.dtpHora_turno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perito";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1063, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbpais);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbprovincia);
            this.groupBox1.Controls.Add(this.txtBarrio);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbobservacion);
            this.groupBox1.Controls.Add(this.txtcodpost);
            this.groupBox1.Controls.Add(this.tbAltura);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.cbbarrio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(567, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 303);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio de turno:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(109, 65);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(121, 23);
            this.txtLocalidad.TabIndex = 38;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(376, 65);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 23);
            this.txt_numero.TabIndex = 37;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Intersección";
            // 
            // cbpais
            // 
            this.cbpais.FormattingEnabled = true;
            this.cbpais.Items.AddRange(new object[] {
            "Seleccione",
            "Argentina"});
            this.cbpais.Location = new System.Drawing.Point(109, 252);
            this.cbpais.Name = "cbpais";
            this.cbpais.Size = new System.Drawing.Size(121, 26);
            this.cbpais.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Pais *";
            // 
            // cbprovincia
            // 
            this.cbprovincia.FormattingEnabled = true;
            this.cbprovincia.Items.AddRange(new object[] {
            "Seleccione",
            "Córdoba"});
            this.cbprovincia.Location = new System.Drawing.Point(109, 176);
            this.cbprovincia.Name = "cbprovincia";
            this.cbprovincia.Size = new System.Drawing.Size(121, 26);
            this.cbprovincia.TabIndex = 33;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(109, 138);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(121, 23);
            this.txtBarrio.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Provincia *";
            // 
            // tbobservacion
            // 
            this.tbobservacion.Location = new System.Drawing.Point(109, 264);
            this.tbobservacion.Name = "tbobservacion";
            this.tbobservacion.Size = new System.Drawing.Size(0, 23);
            this.tbobservacion.TabIndex = 15;
            // 
            // txtcodpost
            // 
            this.txtcodpost.Location = new System.Drawing.Point(109, 213);
            this.txtcodpost.Name = "txtcodpost";
            this.txtcodpost.Size = new System.Drawing.Size(121, 23);
            this.txtcodpost.TabIndex = 14;
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(376, 100);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(100, 23);
            this.tbAltura.TabIndex = 9;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(109, 98);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(121, 23);
            this.txt_calle.TabIndex = 8;
            // 
            // cbbarrio
            // 
            this.cbbarrio.AutoSize = true;
            this.cbbarrio.Location = new System.Drawing.Point(38, 138);
            this.cbbarrio.Name = "cbbarrio";
            this.cbbarrio.Size = new System.Drawing.Size(56, 18);
            this.cbbarrio.TabIndex = 6;
            this.cbbarrio.Text = "Barrio *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Cód. Postal *";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "Localidad *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(298, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 18);
            this.label18.TabIndex = 1;
            this.label18.Text = "Altura *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "Calle *";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(36, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Generar turno ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_telefonoSocio
            // 
            this.txt_telefonoSocio.Location = new System.Drawing.Point(265, 188);
            this.txt_telefonoSocio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefonoSocio.Name = "txt_telefonoSocio";
            this.txt_telefonoSocio.Size = new System.Drawing.Size(265, 23);
            this.txt_telefonoSocio.TabIndex = 29;
            this.txt_telefonoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_telefonoSocio.TextChanged += new System.EventHandler(this.txt_telefonoSocio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Teléfono socio *";
            // 
            // cbo_perito
            // 
            this.cbo_perito.FormattingEnabled = true;
            this.cbo_perito.Items.AddRange(new object[] {
            "Seleccione"});
            this.cbo_perito.Location = new System.Drawing.Point(267, 140);
            this.cbo_perito.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_perito.Name = "cbo_perito";
            this.cbo_perito.Size = new System.Drawing.Size(265, 26);
            this.cbo_perito.TabIndex = 33;
            // 
            // txt_telefonoPerito
            // 
            this.txt_telefonoPerito.Location = new System.Drawing.Point(265, 234);
            this.txt_telefonoPerito.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefonoPerito.Name = "txt_telefonoPerito";
            this.txt_telefonoPerito.Size = new System.Drawing.Size(265, 23);
            this.txt_telefonoPerito.TabIndex = 35;
            this.txt_telefonoPerito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_telefonoPerito.TextChanged += new System.EventHandler(this.txt_telefonoPerito_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Teléfono perito *";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Location = new System.Drawing.Point(428, 337);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(265, 41);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnBorrar.Location = new System.Drawing.Point(830, 340);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(265, 41);
            this.btnBorrar.TabIndex = 37;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // ingresoTurnoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1157, 443);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txt_telefonoPerito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_perito);
            this.Controls.Add(this.txt_telefonoSocio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHora_turno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha_turno);
            this.Controls.Add(this.txtNumSiniestro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ingresoTurnoFrm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingresoTurnoFrm";
            this.Load += new System.EventHandler(this.ingresoTurnoFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumSiniestro;
        private System.Windows.Forms.DateTimePicker dtpFecha_turno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHora_turno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbpais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbprovincia;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbobservacion;
        private System.Windows.Forms.TextBox txtcodpost;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label cbbarrio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_telefonoSocio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_perito;
        private System.Windows.Forms.TextBox txt_telefonoPerito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}