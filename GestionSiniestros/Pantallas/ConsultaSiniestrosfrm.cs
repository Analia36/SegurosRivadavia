using System;
using System.Windows.Forms;
using GestionSiniestros.AccesoDatos;

namespace GestionSiniestros.Pantallas
{
    public partial class ConsultaSiniestrosfrm : Form
    {
        public ConsultaSiniestrosfrm()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int valor;                      
            bool esNumero = int.TryParse(tbDni.Text, out valor);

            if (tbDni.Text == "")
            {
                MessageBox.Show("Debe ingresar Dni para poder realizar la consulta.");
                return;
            }

            if (!esNumero)
            {
               MessageBox.Show("El valor ingresado debe ser un número.");
               return;
            }

            SiniestroMetodos siniestros = new SiniestroMetodos();
            dgvSiniestro.DataSource = siniestros.ConsultarSiniestrosPorAsociado(Int32.Parse(tbDni.Text));

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
