using System;
using System.Data;

using System.Windows.Forms;
using GestionSiniestros.AccesoDatos;

namespace GestionSiniestros.Pantallas
{
    public partial class DatosAsociadosfrm : Form
    {
        public DatosAsociadosfrm()
        {
            InitializeComponent();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int valor;
            bool esNumero = int.TryParse(tbdni.Text, out valor);

            if (tbdni.Text == "")
            {
                MessageBox.Show("Debe ingresar número de póliza para poder realizar la consulta.");
                return;
            }

            if (!esNumero)
            {
                MessageBox.Show("El valor ingresado debe ser un número.");
                tbdni.Text = "";
                return;
            }

            AsociadosMetodos asociado = new AsociadosMetodos();
            DataTable tableDatosAsociados = asociado.ConsultarPorNumeroDni(Int32.Parse(tbdni.Text));

            if (tableDatosAsociados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para el dni seleccionado.");
                return;

            }

            VehiculoMetodos vehiculo = new VehiculoMetodos();
            DataTable tableDatosVehiculo = vehiculo.ConsultarVehiculos(Int32.Parse(tableDatosAsociados.Rows[0]["id"].ToString()));
            tableDatosAsociados.Columns.Remove("id");
            dtvasociado.DataSource = tableDatosAsociados;
            dgvVehiculo.DataSource = tableDatosVehiculo;

            int AltoDelGrid = 0;

            // Sumo el alto de la fila que representa el encabezado de las Columnas     
            AltoDelGrid = AltoDelGrid + dgvVehiculo.ColumnHeadersHeight;

            // Ahora recorro el DataGridView y sumo el alto de cada fila                             
            for (var i = 0; i < dgvVehiculo.Rows.Count ; i++)
            {
                AltoDelGrid = AltoDelGrid + dgvVehiculo.Rows[i].Height;
            }

            dgvVehiculo.Height = AltoDelGrid;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbdni.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el dni.");
                return;
            }

            String poliza = dgvVehiculo.SelectedCells[5].Value.ToString();
            Registrofrm frm = new Registrofrm(Int32.Parse(poliza));
            //this.Hide();
            frm.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       
    }
}
