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
    public partial class ingresoTurnoFrm : Form
    {
        private TurnoMetodos adturno = new TurnoMetodos();

        public ingresoTurnoFrm(string numeroSiniestro)
        {            
            InitializeComponent();
            this.txtNumSiniestro.Text = numeroSiniestro;            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_telefonoSocio.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo teléfono de socio.");
                return;
            }

            if (txt_telefonoPerito.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo teléfono de perito.");
                return;
            }

            if (txtLocalidad.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo localidad.");
                return;
            }

            if (txt_calle.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo calle.");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo altura.");
                return;
            }

            if (txtBarrio.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo barrio.");
                return;
            }

            if (txtcodpost.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo Código Postal.");
                return;
            }

            if (cbprovincia.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de provincia.");
                return;
            }

            if (cbpais.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de pais.");
                return;
            }


            bool esNumero = validarNumerico(txt_telefonoSocio.Text);

            if (!esNumero && txt_telefonoSocio.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo teléfono de socio debe ser un número.");
                return;
            }

            esNumero = validarNumerico(txt_telefonoPerito.Text);

            if (!esNumero && txt_telefonoPerito.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo teléfono de perito debe ser un número.");
                return;
            }

            esNumero = validarNumerico(txt_numero.Text);

            if (!esNumero && txt_numero.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo altura de calle debe ser un número.");
                return;
            }



            TurnoInspeccion turno = new TurnoInspeccion();
            Domicilio domicilio = new Domicilio();            

            turno.fecha = DateTime.Parse(dtpFecha_turno.Value.ToShortDateString());
            turno.hora = DateTime.Parse(dtpHora_turno.Value.ToLongTimeString());
            turno.idDomicilioInspeccion = 0;
            turno.idPerito = Int32.Parse(cbo_perito.SelectedValue.ToString()); // probar mañana
            // corregir el tema del id de domicilio generado
            turno.telefono_socio = int.Parse(txt_telefonoSocio.Text.ToString());
            turno.telefono_perito = int.Parse(txt_telefonoPerito.Text.ToString());

            domicilio.localidad = txtLocalidad.Text;
            domicilio.calle = txt_calle.Text.ToString();
            domicilio.numero = int.Parse(txt_numero.Text.ToString());
            domicilio.barrio = txtBarrio.Text.ToString();
            domicilio.provincia = cbprovincia.SelectedItem.ToString();
            domicilio.codPostal = int.Parse(txtcodpost.Text.ToString());
            domicilio.pais = cbpais.SelectedItem.ToString();
            domicilio.interseccion = tbAltura.Text.ToString();

            turno.domicilio = domicilio;

            //TurnoMetodos adturno = new TurnoMetodos();

            int idturno = adturno.InsertarTurno(turno);

            // paso el estado para poner en proceso

            SiniestroMetodos adsiniestro = new SiniestroMetodos();
            adsiniestro.updateEstado(Int32.Parse(txtNumSiniestro.Text),2,idturno);

            

            MessageBox.Show("El turno fue registrado correctamente.");

        }

        private void ingresoTurnoFrm_Load(object sender, EventArgs e)
        {
            
            cbo_perito.DataSource = adturno.llenarBoxPeritos();
            cbo_perito.DisplayMember = "zona";
            cbo_perito.ValueMember = "codigo";
            cbprovincia.SelectedIndex = 0;
            cbpais.SelectedIndex = 0;
            dtpFecha_turno.MinDate = DateTime.Today;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool validarNumerico(String ingreso)
        {
            int valor;
            bool esNumero = int.TryParse(ingreso, out valor);
            return esNumero;

        }

        private void txt_telefonoSocio_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(txt_telefonoSocio.Text);

            if (!esNumero && txt_telefonoSocio.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo teléfono de socio debe ser un número.");
                return;
            }
        }

        private void txt_telefonoPerito_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(txt_telefonoPerito.Text);

            if (!esNumero && txt_telefonoPerito.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo teléfono de perito debe ser un número.");
                return;
            }
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

            bool esNumero = validarNumerico(txt_numero.Text);

            if (!esNumero && txt_numero.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo altura de calle debe ser un número.");
                return;
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            dtpFecha_turno.Value = DateTime.Today;
            dtpHora_turno.Value = DateTime.Now;
            
            txtNumSiniestro.Text = "";
            cbo_perito.DataSource = adturno.llenarBoxPeritos();
            cbo_perito.DisplayMember = "zona";
            cbo_perito.ValueMember = "codigo";
            cbprovincia.SelectedIndex = 0;
            cbpais.SelectedIndex = 0;
            txt_telefonoSocio.Text = "";
            txt_telefonoPerito.Text = "";
            txtLocalidad.Text = "";
            txt_calle.Text = "";
            txtBarrio.Text = "";
            txt_numero.Text = "";
            txtcodpost.Text = "";
            txt_numero.Text = "";
            tbAltura.Text = "";


        }
    }
}
