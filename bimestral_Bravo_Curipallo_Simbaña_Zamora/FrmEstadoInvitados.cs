using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    public partial class FrmEstadoInvitados : Form
    {
        Actividad actividadEstado;
        
        public FrmEstadoInvitados(Actividad aux)
        {
            InitializeComponent();
            actividadEstado = aux;
            CargarListaInvitados(actividadEstado);

        }
        public void CargarListaInvitados(Actividad actividad)
        {
            dataGridViewInvitados.Rows.Clear();
            try
            {
                int n;
                String titulo = "[Subject]='"+actividad.Titulo+"'";
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.AppointmentItem appt = (Outlook.AppointmentItem)outlookApp.Session.
               GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar).
           Items.Find(titulo)//("[Subject]='ReunionTest3'")
           as Outlook.AppointmentItem;
                if (appt != null)
                {
                    foreach (Outlook.Recipient recip in appt.Recipients)
                    {
                        n = dataGridViewInvitados.Rows.Add();
                        switch (recip.MeetingResponseStatus)
                        {
                            case Outlook.OlResponseStatus.olResponseAccepted:
                                dataGridViewInvitados.Rows[n].Cells[0].Value = recip.Name;
                                dataGridViewInvitados.Rows[n].Cells[1].Value = "Aceptada";
                                break;
                            case Outlook.OlResponseStatus.olResponseTentative:
                                dataGridViewInvitados.Rows[n].Cells[0].Value = recip.Name;
                                dataGridViewInvitados.Rows[n].Cells[1].Value = "Tentativa";
                                break;
                            case Outlook.OlResponseStatus.olResponseDeclined:
                                dataGridViewInvitados.Rows[n].Cells[0].Value = recip.Name;
                                dataGridViewInvitados.Rows[n].Cells[1].Value = "Rechazada";
                                break;
    
                            case Outlook.OlResponseStatus.olResponseNone:
                                dataGridViewInvitados.Rows[n].Cells[0].Value = recip.Name;
                                dataGridViewInvitados.Rows[n].Cells[1].Value = "En espera";
                                break;
                            case Outlook.OlResponseStatus.olResponseNotResponded:
                                dataGridViewInvitados.Rows[n].Cells[0].Value = recip.Name;
                                dataGridViewInvitados.Rows[n].Cells[1].Value = "No responde";
                              break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MnuActualizar_Click(object sender, EventArgs e)
        {
          CargarListaInvitados(actividadEstado);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
