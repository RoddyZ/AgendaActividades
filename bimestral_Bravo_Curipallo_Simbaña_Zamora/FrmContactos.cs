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
    public partial class FrmContactos : Form
    {
        List<Contacto> contactos = new List<Contacto>();
        List<Contacto> invitados = new List<Contacto>();
        FrmActividad frmActividad;
        public FrmContactos(FrmActividad frmActividad1)
        {
            InitializeComponent();
            frmActividad = frmActividad1;
        }

        private void mnuNuevoContacto_Click(object sender, EventArgs e)
        {
            FrmNuevoContacto frmNuevoContacto = new FrmNuevoContacto();

            frmNuevoContacto.NuevoContacto += new FrmNuevoContacto.AgregarContacto(AgregarListaLocal);//kevin
            frmNuevoContacto.NuevoContacto += new FrmNuevoContacto.AgregarContacto(AgregarOutlook);
            frmNuevoContacto.ShowDialog();
            ActualizarContactos();
        }

        private void AgregarOutlook(Contacto contacto)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                
                Outlook.ContactItem contact = (Outlook.ContactItem)outlookApp.CreateItem(Outlook.OlItemType.olContactItem);
                contact.FullName = contacto.NombreContacto;
                contact.Email1Address = contacto.Correo;
                contact.Email1AddressType = "SMTP";
                contact.HomeAddress = contacto.Direccion;
                contact.MobileTelephoneNumber = contacto.Telefono;
                contact.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Outlook",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void AgregarListaLocal(Contacto contacto)
        {
            contactos.Add(contacto);
        }
        private void mnuCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarContactos()
        {
            cstContactos.Items.Clear();

            foreach(var i in contactos)
            {
                cstContactos.Items.Add(i);
            }
        }

        public void ActualizarInvitados()
        {
            lstInvitados.Items.Clear();

            foreach(var i in invitados)
            {
                lstInvitados.Items.Add(i);
            }
        }

        private void btnInvitar_Click(object sender, EventArgs e)
        {
            foreach (Contacto i in cstContactos.CheckedItems)
            {
                invitados.Add(i);
            }
            ActualizarInvitados();
        }

        private void FrmContactos_Load(object sender, EventArgs e)
        {
            /*contactos.Add(new Contacto(1, "Joseph", "Joseph.bravo@epn.edu.ec", "Quito", "0987452134"));
            contactos.Add(new Contacto(2, "Maria", "maria@epn.edu.ec", "Quito", "0987452134"));
            contactos.Add(new Contacto(3, "JOse", "Jose@epn.edu.ec", "Quito", "0987452134"));
            ActualizarContactos();*/
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            frmActividad.Temp.Invitados = invitados;
            this.Close();
        }
    }
}
