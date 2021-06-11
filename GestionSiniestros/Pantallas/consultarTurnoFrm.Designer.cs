namespace GestionSiniestros.Pantallas
{
    partial class consultarTurnoFrm
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
            this.dgvConsultarTurno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarTurno
            // 
            this.dgvConsultarTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarTurno.Location = new System.Drawing.Point(12, 270);
            this.dgvConsultarTurno.Name = "dgvConsultarTurno";
            this.dgvConsultarTurno.Size = new System.Drawing.Size(797, 150);
            this.dgvConsultarTurno.TabIndex = 0;
            this.dgvConsultarTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(331, 102);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultarTurnoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultarTurno);
            this.Name = "consultarTurnoFrm";
            this.Text = "consultarTurnoFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTurno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button button1;
    }
}