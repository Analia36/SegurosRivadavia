using System;
using System.Windows.Forms;
using GestionSiniestros.AccesoDatos;

namespace GestionSiniestros.Pantallas
{
    public partial class Registrofrm : Form
    {
        private int poliza;

        public Registrofrm(int poliza)
        {
            this.poliza = poliza;
            InitializeComponent();
        }

        private void tbobservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cbtipodesiniestro.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe ingresar un dato en el combo de siniestro.");
                return;
            }

            if (cbolocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de localidad.");
                return;
            }

            if (cbprovincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de provincia.");
                return;
            }

            if (cbpais.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de pais.");
                return;
            }

            if (tbcalle.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo calle.");
                return;
            }

            if (tbAltura.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo Altura.");
                return;
            }

            if (tbcodpost.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo código postal.");
                return;
            }

            SiniestroMetodos AdSiniestro = new SiniestroMetodos();
            Siniestro siniestro = new Siniestro();          

            siniestro.hora = DateTime.Parse(dateTimeHora.Value.ToLongTimeString());
            siniestro.fecha = DateTime.Parse(datetime_siniestro.Value.ToShortDateString());
            siniestro.declaracion = tbDeclaracion.Text;
            siniestro.lugar = "Localidad: " + cbolocalidad.SelectedItem.ToString() + "- Calle: " + tbcalle.Text + "- Altura: " + tbAltura.Text + "- Interseccion: " + tbinterseccion.Text
                              + "- Barrio: " + tb_barrio.Text + "- Provincia: " + cbprovincia.SelectedItem.ToString() + "- Cod Postal: " + tbcodpost.Text + "- Pais: " + cbpais.SelectedItem.ToString();

            siniestro.idPoliza = this.poliza;
            siniestro.idEstado = 1; // estado inicial
            siniestro.tipoSiniestro = cbtipodesiniestro.SelectedItem.ToString();
            siniestro.DetalleDanios = tbDanios.Text;

            AdSiniestro.InsertarSiniestro(siniestro);

            MessageBox.Show("El Siniestro fue registrado correctamente.");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            cbtipodesiniestro.SelectedIndex = 0;
            cbolocalidad.SelectedIndex = 0;
            cbprovincia.SelectedIndex = 0;
            cbpais.SelectedIndex = 0;
            tbcalle.Text = "";
            tbAltura.Text = "";
            tbinterseccion.Text = "";
            tb_barrio.Text = "";
            tbcodpost.Text = "";
            tbDeclaracion.Text = "";
            tbDanios.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
