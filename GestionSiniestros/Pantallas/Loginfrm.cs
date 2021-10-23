using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionSiniestros.Pantallas;
using System.Runtime.InteropServices;
using CapaNegocio;


namespace GestionSiniestros.Pantallas
{
    public partial class Loginfrm : Form
    {
        AsociadosMetodosNegocio asociado = new AsociadosMetodosNegocio();
        NotificationTask notification = new NotificationTask();
        public Loginfrm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (tbusuario.Text == "")
            {
                MessageBox.Show("Ingrese usuario.");
                return;
            }

            if (tbpassword.Text == "")
            {
                MessageBox.Show("Ingrese password.");
                return;
            }

            this.Hide();
            formularioBienvenida Bienvenido = new formularioBienvenida();
            Bienvenido.ShowDialog();
                                    
            DataTable resultado = asociado.Login(tbusuario.Text, tbpassword.Text);

            if (resultado.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Menúfrm form = new Menúfrm();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                notification.invokeExecutionNotificationWithoutTurn();

            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }


        }

        private void tbusuario_Enter(object sender, EventArgs e)
        {
            if (tbusuario.Text == "USUARIO")
            {
                tbusuario.Text = "";
                tbusuario.ForeColor = Color.LightGray;
            }
        }
        
        private void tbusuario_Leave(object sender, EventArgs e)
        {
            if (tbusuario.Text == "")
            {
                tbusuario.Text = "USUARIO";
                tbusuario.ForeColor = Color.DimGray;
            }
        }

        private void tbpassword_Enter(object sender, EventArgs e)
        {
            if(tbpassword.Text=="CONTRASEÑA")
            {
                tbpassword.Text = "";
                tbpassword.ForeColor = Color.LightGray;
                tbpassword.UseSystemPasswordChar = true;
            }
        }

        private void tbpassword_Leave(object sender, EventArgs e)
        {
            if (tbpassword.Text == "")
            {
                tbpassword.Text = "CONTRASEÑA";
                tbpassword.ForeColor = Color.DimGray;
                tbpassword.UseSystemPasswordChar = false;
            }
        }

        private void Loginfrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
              
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
