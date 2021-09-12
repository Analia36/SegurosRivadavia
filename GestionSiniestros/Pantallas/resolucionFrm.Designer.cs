namespace GestionSiniestros.Pantallas
{
    partial class resolucionFrm
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
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtMontop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNumeroSiniestro = new System.Windows.Forms.TextBox();
            this.lbNumeroSiniestro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital del vehiculo *";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(268, 110);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(100, 20);
            this.txtCapital.TabIndex = 1;
            this.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCapital.TextChanged += new System.EventHandler(this.txtCapital_TextChanged);
            // 
            // txtMontop
            // 
            this.txtMontop.Location = new System.Drawing.Point(268, 167);
            this.txtMontop.Name = "txtMontop";
            this.txtMontop.Size = new System.Drawing.Size(100, 20);
            this.txtMontop.TabIndex = 3;
            this.txtMontop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontop.TextChanged += new System.EventHandler(this.txtMontop_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto peritado *";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(84, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(262, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumeroSiniestro
            // 
            this.txtNumeroSiniestro.Location = new System.Drawing.Point(268, 54);
            this.txtNumeroSiniestro.Name = "txtNumeroSiniestro";
            this.txtNumeroSiniestro.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroSiniestro.TabIndex = 6;
            this.txtNumeroSiniestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbNumeroSiniestro
            // 
            this.lbNumeroSiniestro.AutoSize = true;
            this.lbNumeroSiniestro.BackColor = System.Drawing.Color.SteelBlue;
            this.lbNumeroSiniestro.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroSiniestro.ForeColor = System.Drawing.Color.White;
            this.lbNumeroSiniestro.Location = new System.Drawing.Point(95, 60);
            this.lbNumeroSiniestro.Name = "lbNumeroSiniestro";
            this.lbNumeroSiniestro.Size = new System.Drawing.Size(140, 14);
            this.lbNumeroSiniestro.TabIndex = 7;
            this.lbNumeroSiniestro.Text = "Número de Siniestro ";
            // 
            // resolucionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(455, 334);
            this.Controls.Add(this.lbNumeroSiniestro);
            this.Controls.Add(this.txtNumeroSiniestro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMontop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resolucionFrm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "resolucionFrm";
            this.Load += new System.EventHandler(this.resolucionFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtMontop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNumeroSiniestro;
        private System.Windows.Forms.Label lbNumeroSiniestro;
    }
}