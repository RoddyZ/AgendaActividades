using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    public partial class FrmNuevoContacto : Form
    {
        public delegate void AgregarContacto(Contacto contacto); //relacionado con eventhandler
      
        public event AgregarContacto NuevoContacto;
        
        public FrmNuevoContacto()
        {
            InitializeComponent();
        }

        private void mnuCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuGuardarContacto_Click(object sender, EventArgs e)
        {
            Contacto contacNew = new Contacto();
            contacNew.IdContacto = 1;
            contacNew.NombreContacto = txtNombre.Text;
            contacNew.Telefono = txtTelefono.Text;
            contacNew.Correo = txtCorreo.Text;
            contacNew.Direccion = txtDireccion.Text;

            NuevoContacto(contacNew);
            this.Close();
        }
    }
}
