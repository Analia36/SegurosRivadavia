using System;
using System.Windows.Forms;

namespace GestionSiniestros.Pantallas
{
    public partial class Menúfrm : Form
    {
        public Menúfrm()
        {
            InitializeComponent();
        }

        private void Menúfrm_Load(object sender, EventArgs e)
        {

        }

        private void registroDeSiniestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosAsociadosfrm form = new DatosAsociadosfrm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void consultarSiniestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaSiniestrosfrm form =  new ConsultaSiniestrosfrm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void registroDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // resolucionFrm form = new resolucionFrm();
           // form.StartPosition = FormStartPosition.CenterScreen;
           // form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void consultarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConsultaSiniestrosfrm form = new ConsultaSiniestrosfrm();
            //form.StartPosition = FormStartPosition.CenterScreen;
            //form.Show();
        }

        private void ampliacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ampliacionDenunciafrm form = new ampliacionDenunciafrm("");
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void consultarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // InformePericiaFrm form = new InformePericiaFrm();
            ConsultarSiniestroInforme form = new ConsultarSiniestroInforme();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

        }

        private void denunciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DenunciaViewerMetrica form = new DenunciaViewerMetrica();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void ampliacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AmpliacionViewer form = new AmpliacionViewer();
            //form.StartPosition = FormStartPosition.CenterScreen;
            //form.Show();
        }
    }
}
