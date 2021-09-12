﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSiniestros.Pantallas
{
    public partial class formularioBienvenida : Form
    {
        public formularioBienvenida()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.10;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.2;
            if (this.Opacity == 0)
            {

                timer2.Stop();
                this.Close();
            }
        }

        private void formularioBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}