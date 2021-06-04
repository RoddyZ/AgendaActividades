using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    public partial class FrmDetallesActividad : Form
    {
        Actividad actividad;
        public FrmDetallesActividad(Actividad temp)
        {
            InitializeComponent();
            actividad = temp;
        }

        private void FrmDetallesActividad_Load(object sender, EventArgs e)
        {
            txtTitulo.Text=actividad.Titulo;
            txtLugar.Text=actividad.Lugar;
            dtpFechaInicio.Value = actividad.FechaInicio;
            dtpHoraFin.Value = actividad.FechaFin;
            dtpHoraInicio.Value = actividad.HoraInicio;
            dtpHoraFin.Value = actividad.HoraFin;
            rtxtDescripcion.Text=actividad.Descripcion;
            cbxTipo.Text = actividad.Tipo;
            if (cbxTipo.Text=="Trabajo")
            {
                vERARCHIVOSToolStripMenuItem.Enabled = true;
            }
            else
            {
                vERARCHIVOSToolStripMenuItem.Enabled = false;
            }
        }

        private void mnuVerInvitados_Click(object sender, EventArgs e)
        {
            FrmEstadoInvitados frmEstadoInvitados = new FrmEstadoInvitados(actividad);
            frmEstadoInvitados.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vERARCHIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "C:\\Users\\Public\\Documents\\" + actividad.Titulo + actividad.IdActividad);
        }
    }
}
