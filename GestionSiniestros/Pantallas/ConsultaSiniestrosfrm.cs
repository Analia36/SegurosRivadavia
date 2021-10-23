using System;
using System.Windows.Forms;
using CapaNegocio;

namespace GestionSiniestros.Pantallas
{
    public partial class ConsultaSiniestrosfrm : Form
    {
        SiniestroMetodosNegocio siniestros = new SiniestroMetodosNegocio();
        TurnoMetodosNegocio adturno = new TurnoMetodosNegocio();
        NotificationTask notification = new NotificationTask();
        public ConsultaSiniestrosfrm()
        {
            InitializeComponent();
            notification.invokeExecutionNotificationWithoutSolve();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int valor;                      
            bool esNumero = int.TryParse(tbDni.Text, out valor);

            if (tbDni.Text == "")
            {
                MessageBox.Show("Debe ingresar Dni para poder realizar la consulta.");
                return;
            }

            if (!esNumero)
            {
               MessageBox.Show("El valor ingresado debe ser un número.");
               return;
            }
            
            dgvSiniestro.DataSource = siniestros.ConsultarSiniestrosPorAsociado(Int32.Parse(tbDni.Text));
            dgvSiniestro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnIngresarTurno_Click(object sender, EventArgs e)
        {
            String numeroSiniestro = dgvSiniestro.SelectedCells[3].Value.ToString();
            ingresoTurnoFrm frmTurno = new ingresoTurnoFrm(numeroSiniestro);
            //this.Hide();

            DateTime fechaInicio = DateTime.Parse(dgvSiniestro.SelectedCells[8].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvSiniestro.SelectedCells[9].Value.ToString());

            if (validarVigenia(fechaInicio, fechaFin))
            {
                frmTurno.StartPosition = FormStartPosition.CenterScreen;
                frmTurno.Show();
            }         

                   
        }

     
        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            String numeroSiniestro = dgvSiniestro.SelectedCells[3].Value.ToString();
            ampliacionDenunciafrm frmAmpliacion = new ampliacionDenunciafrm(numeroSiniestro);
            //this.Hide();

            DateTime fechaInicio = DateTime.Parse(dgvSiniestro.SelectedCells[8].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvSiniestro.SelectedCells[9].Value.ToString());

            if (validarVigenia(fechaInicio, fechaFin))
            {
                frmAmpliacion.StartPosition = FormStartPosition.CenterScreen;
                frmAmpliacion.Show();
            }

           


        }

        private void btnConsultarTurno_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Parse(dgvSiniestro.SelectedCells[8].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvSiniestro.SelectedCells[9].Value.ToString());

            if (validarVigenia(fechaInicio, fechaFin))
            {
                String numeroSiniestro = dgvSiniestro.SelectedCells[3].Value.ToString(); /*poner el que tenga siniestro 11*/
                
                dgvConsultarTurno.DataSource = adturno.ConsultarTurno(Int32.Parse(numeroSiniestro));
                //dgvConsultarTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                /*frmAmpliacion.StartPosition = FormStartPosition.CenterScreen;*/
                int AltoDelGrid = 0;

                // Sumo el alto de la fila que representa el encabezado de las Columnas     
                AltoDelGrid = AltoDelGrid + dgvConsultarTurno.ColumnHeadersHeight;

                // Ahora recorro el DataGridView y sumo el alto de cada fila                             
                for (var i = 0; i < dgvConsultarTurno.Rows.Count; i++)
                {
                    AltoDelGrid = AltoDelGrid + dgvConsultarTurno.Rows[i].Height;
                }

                dgvConsultarTurno.Height = AltoDelGrid;
            }

            
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            DateTime fechaInicio = DateTime.Parse(dgvSiniestro.SelectedCells[8].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvSiniestro.SelectedCells[9].Value.ToString());

            if (validarVigenia(fechaInicio, fechaFin))
            {
                DialogResult res = MessageBox.Show("Esta seguro que desea dar de baja el turno", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    String numSiniestro = dgvConsultarTurno.SelectedCells[0].Value.ToString(); /*poner el que tenga siniestro 11*/
                    

                    adturno.bajaTurno(Int32.Parse(numSiniestro));
                    dgvConsultarTurno.DataSource = adturno.ConsultarTurno(Int32.Parse(numSiniestro));
                    //dgvConsultarTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    /*frmAmpliacion.StartPosition = FormStartPosition.CenterScreen;*/
                    int AltoDelGrid = 0;

                    // Sumo el alto de la fila que representa el encabezado de las Columnas     
                    AltoDelGrid = AltoDelGrid + dgvConsultarTurno.ColumnHeadersHeight;

                    // Ahora recorro el DataGridView y sumo el alto de cada fila                             
                    for (var i = 0; i < dgvConsultarTurno.Rows.Count; i++)
                    {
                        AltoDelGrid = AltoDelGrid + dgvConsultarTurno.Rows[i].Height;
                    }

                    dgvConsultarTurno.Height = AltoDelGrid;
                    MessageBox.Show("El turno fue dado de baja correctamente.");
                }
            }

        }

        private void btnResolucion_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Parse(dgvSiniestro.SelectedCells[8].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvSiniestro.SelectedCells[9].Value.ToString());

            if (validarVigenia(fechaInicio, fechaFin))
            {
                String numSiniestro = dgvSiniestro.SelectedCells[3].Value.ToString();
                String estado = dgvSiniestro.SelectedCells[10].Value.ToString();

                if (estado != "Proceso")
                {

                    MessageBox.Show("Solo se pueden resolver siniestros en estado en Proceso");
                    return;

                }

                resolucionFrm frm = new resolucionFrm(numSiniestro);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }

        }


        private bool validarVigenia(DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime fechaHoy = DateTime.Now;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la de fin");
                return false;
            } else if (fechaHoy > fechaFin || fechaHoy < fechaInicio)
            {
                MessageBox.Show("La Poliza no se encuentra vigente");
                return false;
            }


            return true;

        }

    }
}
