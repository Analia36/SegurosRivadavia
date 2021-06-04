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
            new Datos_Asociadosfrm().Show();
        }

        private void consultarSiniestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaSiniestrosfrm().Show();
        }

        private void registroDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
