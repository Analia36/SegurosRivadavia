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
    public partial class consultarTurnoFrm : Form
    {
        public consultarTurnoFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            TurnoMetodos turnos = new TurnoMetodos();
           // dgvConsultarTurno.DataSource = turnos.ConsultarSiniestrosPorAsociado(Int32.Parse(tbDni.Text));
        }
    }
}
