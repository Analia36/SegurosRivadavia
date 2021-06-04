using System;
using System.Data;

using System.Windows.Forms;
using GestionSiniestros.AccesoDatos;

namespace GestionSiniestros.Pantallas
{
    public partial class Datos_Asociadosfrm : Form
    {
        public Datos_Asociadosfrm()
        {
            InitializeComponent();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int valor;
            bool esNumero = int.TryParse(tbpoliza.Text, out valor);

            if (tbpoliza.Text == "")
            {
                MessageBox.Show("Debe ingresar número de póliza para poder realizar la consulta.");
                return;
            }

            if (!esNumero)
            {
                MessageBox.Show("El valor ingresado debe ser un número.");
                tbpoliza.Text = "";
                return;
            }

            AsociadosMetodos asociado = new AsociadosMetodos();
            DataTable tableDatosAsociados = asociado.ConsultarPorNumeroPoliza(Int32.Parse(tbpoliza.Text));

            if (tableDatosAsociados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para la póliza seleccionada.");
                return;

            }

            VehiculoMetodos vehiculo = new VehiculoMetodos();
            DataTable tableDatosVehiculo = vehiculo.ConsultarPorIdVehiculo(Int32.Parse(tableDatosAsociados.Rows[0]["id_vehiculo"].ToString()));
            tableDatosAsociados.Columns.Remove("id_vehiculo");
            dtvasociado.DataSource = tableDatosAsociados;
            dgvVehiculo.DataSource = tableDatosVehiculo;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbpoliza.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en la póliza.");
                return;
            }
            Registrofrm frm = new Registrofrm(Int32.Parse(tbpoliza.Text));
            this.Hide();
            frm.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
