using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;
using Tulpep.NotificationWindow;



namespace CapaNegocio
{
    public class NotificationTask
    {
        
        private DataAccessNotification dataAccessNotification = new DataAccessNotification();        
        PopupNotifier notifier = new PopupNotifier();

        public NotificationTask()
        {
            
        }


        public void invokeExecutionNotificationWithoutTurn()
        {

            // mando la cantidad de das para notificar
            DataSet ds = dataAccessNotification.getSiniestrosANotificar(7);
            String title = "Notificación Sobre asignación de turnos";
            String description = "";

            
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

               description += "El siniestro número: " + dr["Num_siniestro"].ToString() + " Creado en la fecha: " + dr["Fecha"].ToString().Substring(0,10) + " no tiene hasta el momento " +
                    " un turno asignado. " + System.Environment.NewLine;
             }

            notify(title, description);            
        }

        public void invokeExecutionNotificationWithoutSolve()
        {

            // mando la cantidad de das para notificar
            DataSet ds = dataAccessNotification.getSiniestrosSinFinalizarANotificar(15);
            String title = "Notificación Sobre siniestros sin resolver";
            String description = "";



            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                description += "El sinietro número: " + dr["Num_siniestro"].ToString() + " Creado en la fecha: " + dr["fechaSiniestro"].ToString().Substring(0, 10) + " Con fecha de turno en: " + dr["fechaTurno"].ToString().Substring(0, 10) + " no ha sido resuelto hasta el momento " +
                                System.Environment.NewLine;
            }

            notify(title, description);
        }


        private void notify(String title,String description)
        {

            notifier.Image = Properties.Resources.IconInformation;
            notifier.TitleText = title;
            notifier.ContentText = description;
            notifier.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            notifier.Size = new Size(500, 200);            
            notifier.ShowGrip = true;
            notifier.HeaderHeight = 20;
            notifier.TitlePadding = new Padding(3);            
            notifier.ContentPadding = new System.Windows.Forms.Padding(3);
            notifier.ImagePadding = new System.Windows.Forms.Padding(8);
            notifier.AnimationDuration = 1000;
            notifier.AnimationInterval = 1;
            notifier.HeaderColor = Color.FromArgb(252, 164, 2);
            notifier.Scroll = true;
            notifier.ShowCloseButton = true;            
            notifier.Popup();

        }
    }
}
