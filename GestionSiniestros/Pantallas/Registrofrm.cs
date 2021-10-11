using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace GestionSiniestros.Pantallas
{
    public partial class Registrofrm : Form
    {
        SiniestroMetodosNegocio adSiniestro = new SiniestroMetodosNegocio();
        SiniestroEntidad siniestro = new SiniestroEntidad();

        public Registrofrm(int poliza)
        {
          
            InitializeComponent();
            txtPoliza.Text = poliza.ToString();
        }

        private void tbobservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            bool esNumero = validarNumerico(tbAltura.Text);

            if (!esNumero && tbAltura.Text.Length > 0 )
            {
                MessageBox.Show("El valor del campo altura debe ser un número.");
                return;
            }

           
            if (cbtipodesiniestro.SelectedIndex == 0 )
            {
                MessageBox.Show("Debe ingresar un dato en el combo de siniestro.");
                return;
            }

            if (txtLocalidad.Text == "")
              {
                  MessageBox.Show("Debe ingresar un dato en la localidad.");
                  return;
              }

            /*if (cbprovincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de provincia.");
                return;
            }*/

            if (cbpais.SelectedIndex == 0)
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

            
            if (cbpais.SelectedIndex > 1 && txtProvincia.Text == "") {

                MessageBox.Show("Debe ingresar un dato en el campo provincia.");
                return;
            }

            if (tbDeclaracion.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo declaración.");
                return;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo nombre del conductor.");
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo apellido del conductor.");
                return;
            }

            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo dni del conductor.");
                return;
            }

            if (cboClase.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de clase de carnet del conductor.");
                return;
            }

            if (cboSubClase.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un dato en el combo de subclase de carnet del conductor.");
                return;
            }

            esNumero = validarNumerico(txtNombre.Text);

            if (esNumero && txtNombre.Text.Length > 0)
            {
                MessageBox.Show("El valor ingresado en nombre de conductor no debe contener números");
                return;
            }

            esNumero = validarNumerico(txtApellido.Text);

            if (esNumero && txtApellido.Text.Length > 0)
            {
                MessageBox.Show("El valor ingresado en apellido de conductor no debe contener números");
                return;
            }

            esNumero = validarNumerico(txtDni.Text);

            if (!esNumero && txtDni.Text.Length > 0)
            {
                MessageBox.Show("El valor ingresado en dni de conductor debe ser númerico.");
                return;
            }


            // 
                      

            siniestro.hora = DateTime.Parse(dateTimeHora.Value.ToLongTimeString());
            siniestro.fecha = DateTime.Parse(datetime_siniestro.Value.ToShortDateString());
            siniestro.declaracion = tbDeclaracion.Text;
            siniestro.lugar = "Localidad: " + txtLocalidad.Text + "- Calle: " + tbcalle.Text + "- Altura: " + tbAltura.Text + "- Interseccion: " + tbinterseccion.Text
                              + "- Barrio: " + txtBarrio.Text + "- Provincia: " + cbprovincia.SelectedItem.ToString() + "- Cod Postal: " + tbcodpost.Text + "- Pais: " + cbpais.SelectedItem.ToString();

            siniestro.idPoliza = Int32.Parse(txtPoliza.Text);
            siniestro.idEstado = 1; // estado inicial
            siniestro.tipoSiniestro = cbtipodesiniestro.SelectedItem.ToString();
            siniestro.DetalleDanios = tbDanios.Text;

            ConductorEntidad conductor = new ConductorEntidad();
            conductor.nombre = txtNombre.Text;
            conductor.apellido = txtApellido.Text;
            conductor.dni = Int32.Parse(txtDni.Text);
            conductor.idClase = Int32.Parse(cboClase.SelectedValue.ToString());
            conductor.idSubclase = Int32.Parse(cboSubClase.SelectedValue.ToString());
            conductor.vtoLicencia = DateTime.Parse(dtpVtoLicencia.Value.ToShortDateString());
            siniestro.conductor = conductor;

            adSiniestro.InsertarSiniestro(siniestro);

            MessageBox.Show("El Siniestro fue registrado correctamente.");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            cbtipodesiniestro.SelectedIndex = 0;
            txtLocalidad.Text = "";
            cbprovincia.SelectedIndex = 0;
            cbpais.SelectedIndex = 0;
            tbcalle.Text = "";
            tbAltura.Text = "";
            tbinterseccion.Text = "";
            txtBarrio.Text = "";
            tbcodpost.Text = "";
            tbDeclaracion.Text = "";
            tbDanios.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtProvincia.Text = "";
            datetime_siniestro.Value = DateTime.Today;
            dateTimeHora.Value = DateTime.Now;            
            cboClase.DataSource = adSiniestro.llenarBoxClaseCarnet();

        }


        private void Registrofrm_Load(object sender, EventArgs e)
        {
            datetime_siniestro.MaxDate = DateTime.Now;
            //SiniestroMetodos adSiniestro = new SiniestroMetodos();
            cboClase.DataSource = adSiniestro.llenarBoxClaseCarnet();
            cboClase.DisplayMember = "tipo";
            cboClase.ValueMember = "id";
            cbpais.SelectedIndex = 0;
            cbprovincia.SelectedIndex = 0;
            cbtipodesiniestro.SelectedIndex = 0;

        }

        private void cboClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int valor;
            bool isNumeric = int.TryParse(cboClase.SelectedValue.ToString(), out valor);

            if (isNumeric)
            {
                cboSubClase.DataSource = adSiniestro.llenarBoxSubClaseCarnet(valor);
                cboSubClase.DisplayMember = "subclase";
                cboSubClase.ValueMember = "id";
            }
        }

        private void cbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbpais.SelectedIndex == 1)
            {
                cbprovincia.Enabled = true;
                txtProvincia.Enabled = false;
                
            }
            else
            {
                cbprovincia.Enabled = false;
                txtProvincia.Enabled = true;
            }

        }

        private void tbAltura_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(tbAltura.Text);

            if (!esNumero)
            {
                MessageBox.Show("El valor ingresado debe ser un número.");                
                return;
            }
        }

        private bool validarNumerico( String ingreso)
        {
            int valor;
            bool esNumero = int.TryParse(ingreso, out valor);
            return esNumero;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(txtNombre.Text);

            if (esNumero && txtNombre.Text.Length > 0)
            {
                MessageBox.Show("El valor ingresado en nombre de conductor no debe contener números");
                return;
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(txtApellido.Text);

            if (esNumero && txtApellido.Text.Length > 0)
            {
                MessageBox.Show("El valor ingresado en apellido de conductor no debe contener números");
                return;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(txtDni.Text);

            if (!esNumero && txtDni.Text.Length > 0)
            {
                MessageBox.Show("El valor ingresado en dni de conductor debe ser númerico.");
                return;
            }

        }
    }
}
