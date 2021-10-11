using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;


namespace GestionSiniestros.Pantallas
{
    
    public partial class ampliacionDenunciafrm : Form
    {
        AmpliacionMetodosNegocio ampliacionMetodos = new AmpliacionMetodosNegocio();
        AmpliacionEntidad oampliacion = new AmpliacionEntidad();
        public ampliacionDenunciafrm(String numSiniestro)
        {
            InitializeComponent();
            this.txtNumSiniestro.Text = numSiniestro;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {

                int valor;
                bool esNumero = int.TryParse(txtNumSiniestro.Text, out valor);

                if (txtNumSiniestro.Text == "")
                {
                    MessageBox.Show("Debe ingresar numero ");
                    return;
                }

                if (!esNumero)
                {
                    MessageBox.Show("El valor ingresado debe ser un número.");
                    return;
                }

                if (tbAmp.Text == "")
                {
                    MessageBox.Show("Debe ingresar ampliacion");
                    return;
                }


                //AmpliacionMetodos  Adampliacion = new AmpliacionMetodos();
                //Ampliacion  oampliacion = new Ampliacion ();
                oampliacion.Num_siniestro = int.Parse(txtNumSiniestro.Text);
                oampliacion.AmpliacionSin = tbAmp.Text;
                oampliacion.Fecha = DateTime.Parse(fechaAmp.Value.ToShortDateString());


                ampliacionMetodos.insertarAmpliacion(oampliacion);


                MessageBox.Show("La ampliación fue registrada correctamente.");
            }
        }

      

        private void Historial_Click_1(object sender, EventArgs e)
        {
            int valor;
            bool esNumero = int.TryParse(txtNumSiniestro.Text, out valor);

            if (txtNumSiniestro.Text == "")
            {
                MessageBox.Show("Debe ingresar Dni para poder realizar la consulta.");
                return;
            }

            if (!esNumero)
            {
                MessageBox.Show("El valor ingresado debe ser un número.");
                return;
            }

            //AmpliacionMetodos historial = new AmpliacionMetodos();
            dgvHistorial.DataSource = ampliacionMetodos.consultarhistorial(Int32.Parse(txtNumSiniestro.Text));

            int AltoDelGrid = 0;

            // Sumo el alto de la fila que representa el encabezado de las Columnas     
            AltoDelGrid = AltoDelGrid + dgvHistorial.ColumnHeadersHeight;

            // Ahora recorro el DataGridView y sumo el alto de cada fila                             
            for (var i = 0; i < dgvHistorial.Rows.Count; i++)
            {
                AltoDelGrid = AltoDelGrid + dgvHistorial.Rows[i].Height;
            }

            dgvHistorial.Height = AltoDelGrid;
        }

        private void ampliacionDenunciafrm_Load(object sender, EventArgs e)
        {
            fechaAmp.Value = System.DateTime.Now;
            fechaAmp.MaxDate = DateTime.Now;
            fechaAmp.MinDate = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumSiniestro.Text = "";
            tbAmp.Text = "";            

        }

      
    }
}


    