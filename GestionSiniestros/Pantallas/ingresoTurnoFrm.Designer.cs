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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpFecha_turno = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHora_turno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbpais = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbprovincia = new System.Windows.Forms.ComboBox();
            this.tb_barrio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbobservacion = new System.Windows.Forms.TextBox();
            this.tbcodpost = new System.Windows.Forms.TextBox();
            this.cbo_localidad = new System.Windows.Forms.ComboBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.cbo_perito = new System.Windows.Forms.ComboBox();
            this.txt_telefonoPerito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese número de siniestro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dtpFecha_turno
            // 
            this.dtpFecha_turno.Location = new System.Drawing.Point(359, 137);
            this.dtpFecha_turno.Name = "dtpFecha_turno";
            this.dtpFecha_turno.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_turno.TabIndex = 2;
            this.dtpFecha_turno.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // dtpHora_turno
            // 
            this.dtpHora_turno.Location = new System.Drawing.Point(359, 187);
            this.dtpHora_turno.Name = "dtpHora_turno";
            this.dtpHora_turno.Size = new System.Drawing.Size(200, 20);
            this.dtpHora_turno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perito";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(797, 230);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbpais);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbprovincia);
            this.groupBox1.Controls.Add(this.tb_barrio);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbobservacion);
            this.groupBox1.Controls.Add(this.tbcodpost);
            this.groupBox1.Controls.Add(this.cbo_localidad);
            this.groupBox1.Controls.Add(this.tbAltura);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.cbbarrio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(606, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(495, 283);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio de turno:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(347, 77);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(2);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(76, 20);
            this.txt_numero.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Intersección";
            // 
            // cbpais
            // 
            this.cbpais.FormattingEnabled = true;
            this.cbpais.Items.AddRange(new object[] {
            "Seleccione",
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            "Colombia",
            "Perú"});
            this.cbpais.Location = new System.Drawing.Point(82, 225);
            this.cbpais.Margin = new System.Windows.Forms.Padding(2);
            this.cbpais.Name = "cbpais";
            this.cbpais.Size = new System.Drawing.Size(92, 21);
            this.cbpais.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Pais";
            // 
            // cbprovincia
            // 
            this.cbprovincia.FormattingEnabled = true;
            this.cbprovincia.Items.AddRange(new object[] {
            "Seleccione",
            "Córdoba"});
            this.cbprovincia.Location = new System.Drawing.Point(82, 138);
            this.cbprovincia.Margin = new System.Windows.Forms.Padding(2);
            this.cbprovincia.Name = "cbprovincia";
            this.cbprovincia.Size = new System.Drawing.Size(92, 21);
            this.cbprovincia.TabIndex = 33;
            // 
            // tb_barrio
            // 
            this.tb_barrio.Location = new System.Drawing.Point(82, 103);
            this.tb_barrio.Margin = new System.Windows.Forms.Padding(2);
            this.tb_barrio.Name = "tb_barrio";
            this.tb_barrio.Size = new System.Drawing.Size(92, 20);
            this.tb_barrio.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 146);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Provincia";
            // 
            // tbobservacion
            // 
            this.tbobservacion.Location = new System.Drawing.Point(82, 191);
            this.tbobservacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbobservacion.Name = "tbobservacion";
            this.tbobservacion.Size = new System.Drawing.Size(1, 20);
            this.tbobservacion.TabIndex = 15;
            // 
            // tbcodpost
            // 
            this.tbcodpost.Location = new System.Drawing.Point(82, 181);
            this.tbcodpost.Margin = new System.Windows.Forms.Padding(2);
            this.tbcodpost.Name = "tbcodpost";
            this.tbcodpost.Size = new System.Drawing.Size(92, 20);
            this.tbcodpost.TabIndex = 14;
            // 
            // cbo_localidad
            // 
            this.cbo_localidad.FormattingEnabled = true;
            this.cbo_localidad.Items.AddRange(new object[] {
            "Seleccione",
            "Córdoba"});
            this.cbo_localidad.Location = new System.Drawing.Point(82, 39);
            this.cbo_localidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_localidad.Name = "cbo_localidad";
            this.cbo_localidad.Size = new System.Drawing.Size(92, 21);
            this.cbo_localidad.TabIndex = 13;
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(347, 128);
            this.tbAltura.Margin = new System.Windows.Forms.Padding(2);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(76, 20);
            this.tbAltura.TabIndex = 9;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(82, 71);
            this.txt_calle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(92, 20);
            this.txt_calle.TabIndex = 8;
            // 
            // cbbarrio
            // 
            this.cbbarrio.AutoSize = true;
            this.cbbarrio.Location = new System.Drawing.Point(27, 110);
            this.cbbarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cbbarrio.Name = "cbbarrio";
            this.cbbarrio.Size = new System.Drawing.Size(34, 13);
            this.cbbarrio.TabIndex = 6;
            this.cbbarrio.Text = "Barrio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 181);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Cód. Post*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 47);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Localidad*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(270, 77);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Altura*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 71);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Calle*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(590, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Generar turno ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_telefonoSocio
            // 
            this.txt_telefonoSocio.Location = new System.Drawing.Point(358, 274);
            this.txt_telefonoSocio.Name = "txt_telefonoSocio";
            this.txt_telefonoSocio.Size = new System.Drawing.Size(201, 20);
            this.txt_telefonoSocio.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Teléfono socio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbo_perito
            // 
            this.cbo_perito.FormattingEnabled = true;
            this.cbo_perito.Items.AddRange(new object[] {
            "Seleccione",
            "Perito zona norte",
            "Perito zona sur",
            "...."});
            this.cbo_perito.Location = new System.Drawing.Point(358, 232);
            this.cbo_perito.Name = "cbo_perito";
            this.cbo_perito.Size = new System.Drawing.Size(121, 21);
            this.cbo_perito.TabIndex = 33;
            // 
            // txt_telefonoPerito
            // 
            this.txt_telefonoPerito.Location = new System.Drawing.Point(358, 320);
            this.txt_telefonoPerito.Name = "txt_telefonoPerito";
            this.txt_telefonoPerito.Size = new System.Drawing.Size(201, 20);
            this.txt_telefonoPerito.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Teléfono perito";
            // 
            // ingresoTurnoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 509);
            this.Controls.Add(this.txt_telefonoPerito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_perito);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ingresoTurnoFrm";
            this.Text = "ingresoTurnoFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox tb_barrio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbobservacion;
        private System.Windows.Forms.TextBox tbcodpost;
        private System.Windows.Forms.ComboBox cbo_localidad;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbo_perito;
        private System.Windows.Forms.TextBox txt_telefonoPerito;
        private System.Windows.Forms.Label label6;
    }
}