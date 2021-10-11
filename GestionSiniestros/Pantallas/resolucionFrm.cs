using System;
using System.Windows.Forms;
using CapaNegocio;


namespace GestionSiniestros.Pantallas
{
    public partial class resolucionFrm : Form
    {
        SiniestroMetodosNegocio siniestro = new SiniestroMetodosNegocio();
        public resolucionFrm(String numeroSiniestro)
        {
            InitializeComponent();
            txtNumeroSiniestro.Text = numeroSiniestro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto_capital, desc ;


            if (txtCapital.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el capital.");
                return;
            }

            if (txtMontop.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato en el campo monto.");
                return;
            }


            bool esNumero = validarNumerico(txtCapital.Text);

            if (!esNumero && txtCapital.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo capital debe ser un número.");
                return;
            }

            esNumero = validarNumerico(txtMontop.Text);

            if (!esNumero && txtMontop.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo monto debe ser un número.");
                return;
            }



            monto_capital = Convert.ToDouble(txtCapital.Text);

            desc = monto_capital * 0.8;

       

            if (desc <= Convert.ToDouble(txtMontop.Text))            
                MessageBox.Show("Corresponde pagarle , sus daños son mas del 80 %");
            else MessageBox.Show("No corresponde cobertura TOTAL");

            
            
            siniestro.updateFinalizarSiniestro(Int32.Parse(txtNumeroSiniestro.Text));
            MessageBox.Show("El siniestro ha sido resuelto y pasado a estado finalizado");
                        


        }

        private void resolucionFrm_Load(object sender, EventArgs e)
        {
            txtCapital.Text = "0";
            txtMontop.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool validarNumerico(String ingreso)
        {
            int valor;
            bool esNumero = int.TryParse(ingreso, out valor);
            return esNumero;

        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            bool esNumero = validarNumerico(txtCapital.Text);

            if (!esNumero && txtCapital.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo capital debe ser un número.");
                return;
            }
        }

        private void txtMontop_TextChanged(object sender, EventArgs e)
        {

            bool esNumero = validarNumerico(txtMontop.Text);

            if (!esNumero && txtMontop.Text.Length > 0)
            {
                MessageBox.Show("El valor del campo monto debe ser un número.");
                return;
            }

        }
    }
}
