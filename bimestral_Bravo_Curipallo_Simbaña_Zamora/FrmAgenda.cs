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
    public partial class FrmAgenda : Form
    {

        List<Actividad> listaActividades = new List<Actividad>();
        DateTime fechaActividadEscogida;
        int contador = 0;//Sirve para el id autonumerado de actividad
        
        //Variables que sirven para el datagrid del calendario
        DataTable dt = new DataTable();
        object[,] listaMeses;
        int pos = 0;//sirve para mover el calendario
        string[] listaDias;
        int dia;
        int mes;
        int anio;

        public FrmAgenda()
        {
            InitializeComponent();
            dia = DateTime.Today.Day;
            mes = DateTime.Today.Month;
            anio = DateTime.Today.Year;
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("fecha", typeof(DateTime));
            dt.Columns.Add("evento", typeof(string));
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            btnEditarActividad.Enabled = false;
            btnEliminarActividad.Enabled = false;
            btnVerActividad.Enabled =false;
            listaDias = new string[7] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            listaMeses = new object[12, 2] { { 1, "Enero" }, { 2, "Febrero" }, { 3, "Marzo" }, { 4, "Abril" }, { 5, "Mayo" }, { 6, "Junio" }, { 7, "Julio" }, { 8, "Agosto" }, { 9, "Septiembre" }, { 10, "Octubre" }, { 11, "Noviembre" }, { 12, "Diciembre" } };

            lblLunes.Text = listaDias[0];
            lblMartes.Text = listaDias[1];
            lblMiercoles.Text = listaDias[2];
            lblJueves.Text = listaDias[3];
            lblViernes.Text = listaDias[4];
            lblSabado.Text = listaDias[5];
            lblDomingo.Text = listaDias[6];

            for (int i = 0; i < listaMeses.Length / 2; i++) cbxMeses.Items.Add(listaMeses[i, 1]);
            for (int i = 0; i < 5; i++)cbxAnios.Items.Add(DateTime.Today.Year + i - 2);

            if (DateTime.Today.Month > 1)pos = DateTime.Today.Month - 1;
            else pos = 0;

            for (int i = 0; i < 12; i++)
            {
                if ((int)listaMeses[i, 0] == DateTime.Today.Month)
                {
                    cbxMeses.SelectedText = (string)listaMeses[i, 1];
                }
            }

            cbxAnios.SelectedText = DateTime.Today.Year.ToString();
            Visualizar(cbxMeses.Text, cbxAnios.Text);

            if (pos == 0)
            {
                lblInicio.Visible = false;
                lblAnterior.Visible = false;
            }
            if (pos == 11)
            {
                lblSiguiente.Visible = false;
                lblFin.Visible = false;
            }

            this.CargarActividades();

            for (int i = 0; i < 12; i++)
            {
                if ((int)listaMeses[i, 0] == DateTime.Today.Month)
                {
                    Calendario((int)listaMeses[i, 0], int.Parse(cbxAnios.Text));
                }
            }
        }
        /*********************************
             FUNCIONES DEL CALENDARIO
        **********************************/
        public void Visualizar(int m, int a)
            {
                for (int i = 0; i < 12; i++)
                {
                    if ((int)listaMeses[i, 0] == m)
                    {
                        lblTexto.Text = listaMeses[i, 1].ToString() + " " + a.ToString();
                        Calendario(m, a);
                    }
                }
            }
        public void Visualizar(string m, string a)
        {
            lblTexto.Text = m + " " + a.ToString();
        }
        public void CargarActividades()
        {
            dt.Clear();
            foreach (var item in listaActividades)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = item.IdActividad;
                dr["fecha"] = item.FechaInicio;
                dr["evento"] = item.Titulo;
                dt.Rows.Add(dr);
            }
             
        }

        public void Calendario(int m, int a)
        {
            int numeroDias = DateTime.DaysInMonth(a, m);
            DateTime primerDia = DateTime.Parse(1 + "/" + m.ToString() + "/" + a.ToString());

            int index = 0;
            int nSemanas = 0;
            bool diaUno = false;
            string[,] agenda = new string[6, 8];

            while (index < numeroDias)
            {

                agenda[nSemanas, 0] = (nSemanas + 1).ToString();


                for (int i = 1; i < 8; i++)
                {

                    if (primerDia.ToString("dddd").ToLower() == listaDias[i - 1].ToLower() && diaUno == false)
                    {
                        index++;
                        agenda[nSemanas, i] = index.ToString() + RecuperarEvento(DateTime.Parse(index + "/" + m.ToString() + "/" + a.ToString()));
                        diaUno = true;
                        continue;
                    }
                    else if (diaUno == false)
                    {
                        agenda[nSemanas, i] = "";
                        continue;
                    }


                    if (index < numeroDias)
                    {
                        index++;
                        agenda[nSemanas, i] = index.ToString() + RecuperarEvento(DateTime.Parse(index + "/" + m.ToString() + "/" + a.ToString()));
                    }
                    else
                        agenda[nSemanas, i] = "";

                }
                nSemanas++;
            }

            cargarDataGrid(agenda, nSemanas);
        }

        private string RecuperarEvento(DateTime fecha)
        {
            string str = "";
            bool first = true;
            this.CargarActividades();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (String.Format("{0:d}", fecha) == String.Format("{0:d}", (DateTime)dt.Rows[i][1]))
                {
                    if (first)
                    {
                        first = false;
                        str += "        " + String.Format("{0:t}", (DateTime)dt.Rows[i][1]) + ((char)13) + dt.Rows[i][2] + "\r\n";
                    }
                    else
                        str += ((char)13) + "-----------------------" + "\r\n" + "          " + String.Format("{0:t}", (DateTime)dt.Rows[i][1]) + "\r\n" + dt.Rows[i][2] + "\r\n";

                }

            }
            return str;
        }
        private void cargarDataGrid(string[,] agenda, int nbLigne)
        {
            dataGridCalendar.Rows.Clear();
            for (int i = 0; i < nbLigne; i++)
            {
                dataGridCalendar.Rows.Add(agenda[i, 0], agenda[i, 1], agenda[i, 2], agenda[i, 3], agenda[i, 4], agenda[i, 5], agenda[i, 6], agenda[i, 7]);
            }

            dataGridCalendar.Rows[0].Cells[0].Selected = false;

            for (int i = 0; i < dataGridCalendar.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridCalendar.Columns.Count; j++)
                {
                    string[] t = agenda[i, j].Split(' ');
                    DateTime date = new DateTime();

                    if (t[0] != "")
                    {
                        for (int m = 0; m < 12; m++)
                        {

                            if (cbxMeses.Text.Equals(listaMeses[m, 1]))
                            {
                                date = DateTime.Parse(t[0].Trim() + "/" + listaMeses[m, 0] + "/" + cbxAnios.Text);
                                continue;
                            }
                        }

                    }

                    if (DateTime.Compare(date, new DateTime(anio, mes, dia)) == 0)
                        dataGridCalendar.Rows[i].Cells[j].Selected = true;

                    if (!agenda[i, j].Equals(""))
                        dataGridCalendar.Rows[i].Cells[j].Style.BackColor = Color.AliceBlue;

                    if (agenda[i, j].Length > 2)
                        dataGridCalendar.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.TopLeft;

                }
            }
        }

        /*********************************
               CRUD DEL CALENDARIO 
        **********************************/
        private void PrimerMes()
        {
            lblInicio.Visible = false;
            lblAnterior.Visible = false;
            lblSiguiente.Visible = true;
            lblFin.Visible = true;
        }
        private void EntreMes()
        {
            lblInicio.Visible = true;
            lblAnterior.Visible = true;
            lblSiguiente.Visible = true;
            lblFin.Visible = true;
        }
        private void UltimoMes()
        {
            lblInicio.Visible = true;
            lblAnterior.Visible = true;
            lblSiguiente.Visible = false;
            lblFin.Visible = false;
        }
        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < 11)
            {
                Visualizar(listaMeses[pos, 1].ToString(), cbxAnios.Text);
                cbxMeses.Text = listaMeses[pos, 1].ToString();
                EntreMes();
            }
            else
            {
                pos = 11;
                Visualizar(listaMeses[pos, 1].ToString(), cbxAnios.Text);
                cbxMeses.Text = listaMeses[pos, 1].ToString();
                UltimoMes();
            }
        }
        private void lblFin_Click(object sender, EventArgs e)
        {
            pos = 11;
            cbxMeses.Text = listaMeses[pos, 1].ToString();
            UltimoMes();
        }
        private void lblAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos > 0)
            {
                Visualizar(listaMeses[pos, 1].ToString(), cbxAnios.Text);
                cbxMeses.Text = listaMeses[pos, 1].ToString();
                EntreMes();
            }
            else
            {
                pos = 0;
                Visualizar(listaMeses[pos, 1].ToString(), cbxAnios.Text);
                cbxMeses.Text = listaMeses[pos, 1].ToString();
                PrimerMes();
            }
        }
        private void lblInicio_Click(object sender, EventArgs e)
        {
            pos = 0;
            cbxMeses.Text = listaMeses[pos, 1].ToString();
            PrimerMes();
        }
        /*********************************
                  EVENTOS
       **********************************/
        private void cbxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Visualizar(cbxMeses.SelectedItem.ToString(), cbxAnios.Text);
            for (int i = 0; i < 12; i++)
            {
                if (listaMeses[i, 1] == cbxMeses.SelectedItem)
                {
                    this.Calendario((int)listaMeses[i, 0], int.Parse(cbxAnios.Text));
                    pos = i;
                    mes = (int)listaMeses[i, 0];
                    if (pos == 0) PrimerMes();
                    if (pos == 11) UltimoMes();
                }
            }
        }
        private void cbxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            anio = int.Parse(cbxAnios.SelectedItem.ToString());
            Calendario(mes, anio);
            Visualizar(cbxMeses.Text, cbxAnios.Text);
        }
        private void lstActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarBotones();
        }
        private void lstActividades_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstActividades.SelectedItem == null)
            {
                DesactivarBotones();
            }
            else
            {
                ActivarBotones();
            }
        }
        private void dataGridCalendar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string[] value = dataGridCalendar.CurrentCell.Value.ToString().Split();
            try
            {
                dia = int.Parse(value[0]);
                ActualizarLstActividades(new DateTime(anio, mes, dia));
                fechaActividadEscogida = new DateTime(anio, mes, dia);
            }
            catch
            {
                MessageBox.Show("Día no valido", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DesactivarBotones();

        }
        /*********************************
                   BOTONES
         **********************************/
        private void btnNuevoActividad_Click(object sender, EventArgs e)
        {
            FrmActividad frmActividad = new FrmActividad(fechaActividadEscogida,contador);
            contador++;
            frmActividad.ShowDialog();
            ActualizarCalendarioYActividades(frmActividad.Temp);//Me ubica la actividad en el calendario

            DesactivarBotones();
        }
        
        private void btnVerActividad_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad temp = (Actividad)lstActividades.SelectedItem;
                FrmDetallesActividad frmDetallesActividad = new FrmDetallesActividad(temp);
                frmDetallesActividad.Show();
            }
            catch
            {
                MessageBox.Show("Actividad no valida", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DesactivarBotones();
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            try
            {
                listaActividades.Remove((Actividad)lstActividades.SelectedItem);
                string[] value = dataGridCalendar.CurrentCell.Value.ToString().Split();
                dia = int.Parse(value[0]);
                ActualizarLstActividades(new DateTime(anio, mes, dia));
                Calendario(mes, anio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Actividad no valida", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DesactivarBotones();
        }

        private void btnEditarActividad_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad temp = (Actividad)lstActividades.SelectedItem;
                int indice = listaActividades.IndexOf((Actividad)lstActividades.SelectedItem);
                listaActividades.Remove((Actividad)lstActividades.SelectedItem);

                FrmActividad frmActividad = new FrmActividad(temp);

                frmActividad.ShowDialog();

                listaActividades.Insert(indice, frmActividad.Temp);

                string[] value = dataGridCalendar.CurrentCell.Value.ToString().Split();
                dia = int.Parse(value[0]);
                ActualizarLstActividades(new DateTime(anio, mes, dia));
                Calendario(mes, anio);

            }
            catch
            {
                MessageBox.Show("Actividad no valida", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                DesactivarBotones();
        }
        /*********************************
                  FUNCIONES 
       **********************************/
        public void DesactivarBotones()
        {
            btnEditarActividad.Enabled = false;
            btnEliminarActividad.Enabled = false;
            btnVerActividad.Enabled = false;
        }
        public void ActivarBotones()
        {
            btnEditarActividad.Enabled = true;
            btnEliminarActividad.Enabled = true;
            btnVerActividad.Enabled = true;
        }
        public void ActualizarCalendarioYActividades(Actividad t)
        {
            listaActividades.Add(t);//Agrega a la lista la actividad lo que viene del otro formulario
            //Se actualizar el comboBox de meses
            cbxMeses.SelectedIndex = Convert.ToInt32(t.FechaInicio.Month) - 1;
            //Se actualiza el combo box de los años
            for (int i = 0; i < cbxAnios.Items.Count; i++)
            {
                if (cbxAnios.Items[i].ToString() == t.FechaInicio.ToString("yyyy"))
                {
                    cbxAnios.SelectedIndex = i;
                }
            }
            Visualizar(Convert.ToInt16(t.FechaInicio.Month), Convert.ToInt16(t.FechaInicio.Year));
        }
        public void ActualizarLstActividades(DateTime fechaActividad)
        {
            lstActividades.Items.Clear();
            foreach (Actividad iter in listaActividades)
            {
                if (fechaActividad.ToString("MM/dd/yy") == iter.FechaInicio.ToString("MM/dd/yy"))
                {
                    lstActividades.Items.Add(iter);
                }
            }
        }
    }
}
