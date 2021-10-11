using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace GestionSiniestros.Pantallas
{
    public partial class InformePericiaFrm : Form
    {
        InformePericiaNegocio infoPericia = new InformePericiaNegocio();

        public InformePericiaFrm(String numeroSiniestro)
        {
            InitializeComponent();
            txtNumeroSiniestro.Text = numeroSiniestro;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Todos los archivos (*.*)|*.*";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar Archivo ";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                
                axAcroPDF1.src = ofdSeleccionar.FileName;
            }

        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Encoding ascii = Encoding.ASCII;            
            FileStream fs = File.OpenRead(ofdSeleccionar.FileName);
            MemoryStream ms = new MemoryStream();
            axAcroPDF1.src = ascii.GetString(ms.ToArray());
            fs.CopyTo(ms);

            infoPericia.InsertarArchivo(txtNumeroSiniestro.Text, ofdSeleccionar.FileName, ms.ToArray());            

            MessageBox.Show("Archivo insertado correctamente");



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Encoding ascii = Encoding.ASCII;
            //ADInformePericia adInforme = new ADInformePericia();
            byte[] pdf = infoPericia.getDocument(int.Parse(txtNumeroSiniestro.Text));

            if (pdf != null && pdf.Any())
            {
                MemoryStream ms = new MemoryStream(pdf);
                ms.Position = 0;
                String Path = AppDomain.CurrentDomain.BaseDirectory;
                File.WriteAllBytes(@"..\\..\\Informes\\auxiliar.pdf", ms.ToArray());
                axAcroPDF1.LoadFile(@"..\\..\\Informes\\auxiliar.pdf");
                axAcroPDF1.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe informe cargado para el siniestro seleccionado");
            }

                    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
