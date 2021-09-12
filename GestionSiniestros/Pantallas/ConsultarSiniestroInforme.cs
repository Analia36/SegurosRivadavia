using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionSiniestros.AccesoDatos;


namespace GestionSiniestros.Pantallas
{
    public partial class ConsultarSiniestroInforme : Form
    {
        public ConsultarSiniestroInforme()
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

            DataTable tableSiniestros = siniestros.ConsultarSiniestrosPorAsociado(Int32.Parse(tbDni.Text));

            if (tableSiniestros.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para el dni seleccionado.");
                return;

            }
            
            dgvSiniestro.DataSource = tableSiniestros;
            dgvSiniestro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            String numeroSiniestro = dgvSiniestro.SelectedCells[3].Value.ToString();
            InformePericiaFrm form = new InformePericiaFrm(numeroSiniestro);            
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
