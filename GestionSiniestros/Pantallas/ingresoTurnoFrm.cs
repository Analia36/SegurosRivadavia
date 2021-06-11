using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSiniestros.Pantallas
{
    public partial class ingresoTurnoFrm : Form
    {
        private int dni;

        public ingresoTurnoFrm(int dni)
        {
            this.dni = dni;
            InitializeComponent();
        }

        public ingresoTurnoFrm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turno_inspeccion turno = new Turno_inspeccion();
            Domicilio domicilio = new Domicilio();

            turno.fecha = DateTime.Parse(dtpFecha_turno.Value.ToShortDateString());
            turno.hora = DateTime.Parse(dtpHora_turno.Value.ToShortDateString());
            turno.idDomicilioInspeccion = 0;
            turno.idPerito = int.Parse(cbo_perito.SelectedItem.ToString());
            turno.telefono_socio = int.Parse(txt_telefonoSocio.ToString());
            turno.telefono_perito = int.Parse(txt_telefonoPerito.ToString());

            domicilio.localidad = cbo_localidad.SelectedItem.ToString();
            domicilio.calle = txt_calle.ToString();
            domicilio.numero = int.Parse(txt_numero.ToString());
            domicilio.barrio = tb_barrio.ToString();
            domicilio.provincia = cbprovincia.SelectedItem.ToString();
            domicilio.codPostal = int.Parse(tbcodpost.ToString());
            domicilio.pais = cbpais.SelectedItem.ToString();
            domicilio.interseccion = tbAltura.ToString();


            turno.domicilio = domicilio;





        }
    }
}
