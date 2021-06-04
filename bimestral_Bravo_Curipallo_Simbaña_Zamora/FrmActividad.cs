using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    public partial class FrmActividad : Form
    {
        private Actividad temp = new Actividad();
        Boolean crearEditar = false;
        String[] origen;
        public Actividad Temp { get => temp; set => temp = value; }

        public FrmActividad(DateTime fechaInicio, int contador)//poner fecha a la actividad desde el otro formulario
        {
            InitializeComponent();
            dtpFechaInicio.Value = fechaInicio;
            dtpHoraFin.Value = fechaInicio;
            crearEditar = false;
            temp.IdActividad = contador;
        }
        public FrmActividad()//poner fecha a la actividad desde el otro formulario
        {
            InitializeComponent();
        }
        public FrmActividad(Actividad actividad)//poner fecha a la actividad desde el otro formulario
        {
            InitializeComponent();
            temp = actividad;
            crearEditar = true;
           
        }

        private void FrmActividad_Load(object sender, EventArgs e)
        {
            cbxTipo.Items.Add("Trabajo");
            cbxTipo.Items.Add("Reunion");
            cbxTipo.Items.Add("Social");
            EditarAgregar();
            mnuAdjuntar.Enabled = false;
            if (crearEditar)
            {
                mnuInvitar.Enabled = false;
            }
        }
        private void MnuInvitar_Click(object sender, EventArgs e)
        {
            FrmContactos frmContactos = new FrmContactos(this);
            frmContactos.ShowDialog();
        }

        private void MnuCancelarActividad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTitulo_Enter(object sender, EventArgs e)
        {
            txtTitulo.Clear();
        }

        private void TxtLugar_Enter(object sender, EventArgs e)
        {
            txtLugar.Clear();
        }

        private void RtxtDescripcion_Enter(object sender, EventArgs e)
        {
            rtxtDescripcion.Clear();
        }

        private void MnuGuardarActividad_Click(object sender, EventArgs e)
        {
            //Guardar los datos de la forma
            Temp.Titulo = txtTitulo.Text;
            Temp.Lugar = txtLugar.Text;
            Temp.FechaInicio = new DateTime(dtpFechaInicio.Value.Year,
                dtpFechaInicio.Value.Month,dtpFechaInicio.Value.Day, dtpHoraInicio.Value.Hour,
                dtpHoraInicio.Value.Minute, dtpHoraInicio.Value.Second);

            Temp.FechaFin = new DateTime(dtpFechaFin.Value.Year,
                dtpFechaFin.Value.Month, dtpFechaFin.Value.Day, dtpHoraFin.Value.Hour,
                dtpHoraFin.Value.Minute, dtpHoraFin.Value.Second);
            Temp.Descripcion = rtxtDescripcion.Text;
            Temp.HoraInicio = dtpHoraInicio.Value;
            Temp.HoraFin = dtpHoraFin.Value;
            Temp.Tipo = cbxTipo.Text;

            //Envia los correos
            if (temp.Invitados!=null)
            {
                EnviarCorreos();
            }
            if (Temp.Tipo == "Trabajo")
            {
                AdjuntarArchivo();

            }
            this.Close();

        }

        private void mnuAdjuntar_Click(object sender, EventArgs e)
        {
            if (openFileSeleccionarArchivos.ShowDialog() == DialogResult.OK) //Se abre el dialogo y se acepta la seleccion
            {
                origen = openFileSeleccionarArchivos.FileNames; //Se guarda los Path absolutos de los archivos
            }
        }

        public void AdjuntarArchivo()
        {
            if (origen != null)
            {
                string destino = "C:\\Users\\Public\\Documents\\" + Temp.Titulo + Temp.IdActividad;
                if (!Directory.Exists(destino))
                {

                    //MessageBox.Show("Carperta creada");


                    Directory.CreateDirectory(destino);

                    foreach (string file in origen) //Recorre los Paths
                    {
                        FileInfo mFile = new FileInfo(file);//Creamos un archivo auxiliar con el Path almacenado
                        if (new FileInfo(destino + "\\" + mFile.Name).Exists == false)
                            mFile.CopyTo(destino + "\\" + mFile.Name);//Se copia el archivo en la nueva Ruta
                    }


                }
                else
                {
                    //MessageBox.Show("El directorio ya existe");
                }
            }
            
        }
        public void EnviarCorreos()
        {
            try {
                Outlook.Application outlookApp = new Outlook.Application();
                //Next, create an instance of AppointmentItem object and set the properties: 
                Outlook.AppointmentItem appt = (Outlook.AppointmentItem)outlookApp.CreateItem(Outlook.OlItemType.olAppointmentItem);
                appt.Subject =temp.Titulo ;
                appt.MeetingStatus = Outlook.OlMeetingStatus.olMeeting;  //Rastear la respuesta de la invitacion
                appt.Location =temp.Lugar;
                appt.Start =temp.FechaInicio;
                appt.End =temp.FechaInicio;
                appt.Body =temp.Descripcion;

                foreach ( Contacto iter in temp.Invitados)
                {
                    Outlook.Recipient recipOptional = appt.Recipients.Add(iter.NombreContacto);
                    recipOptional.Type = (int)Outlook.OlMeetingRecipientType.olOptional;
                }
                /*Outlook.Recipient recipRequired = appt.Recipients.Add("Ryan Gregg");
                recipRequired.Type = (int)Outlook.OlMeetingRecipientType.olRequired;*/
                /*Outlook.Recipient recipConf = appt.Recipients.Add("Conf Room 36/2021 (14) AV");
                recipConf.Type =(int)Outlook.OlMeetingRecipientType.olResource;*/
                appt.Recipients.ResolveAll();
                ((Outlook._AppointmentItem)appt).Send();
                MessageBox.Show("Las invitaciones han sido enviadas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EditarAgregar()
        {
            
            if (crearEditar == false) 
            {
                txtTitulo.Text = "Agregar un título al evento";
                txtLugar.Text = "Agregar una ubicación";
                rtxtDescripcion.Text = "Agregar una Descripción";
                cbxTipo.Text = "Eliga un tipo";
            }
            else
            {
                txtTitulo.Text = temp.Titulo;
                txtLugar.Text = temp.Lugar;
                rtxtDescripcion.Text = temp.Descripcion;
                cbxTipo.Text = temp.Tipo; ;
                dtpFechaInicio.Value = temp.FechaInicio;
                dtpHoraInicio.Value = temp.HoraInicio;
                dtpFechaFin.Value = temp.FechaFin;
                dtpHoraFin.Value = temp.HoraFin;
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "Trabajo")
            {
                mnuAdjuntar.Enabled = true;
            }
            else
            {
                mnuAdjuntar.Enabled = false;
            }
        }
    }
}
