namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    partial class FrmActividad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuGuardarActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelarActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvitar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdjuntar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.openFileSeleccionarArchivos = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGuardarActividad,
            this.mnuCancelarActividad,
            this.mnuInvitar,
            this.mnuAdjuntar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(567, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuGuardarActividad
            // 
            this.mnuGuardarActividad.Image = ((System.Drawing.Image)(resources.GetObject("mnuGuardarActividad.Image")));
            this.mnuGuardarActividad.Name = "mnuGuardarActividad";
            this.mnuGuardarActividad.Size = new System.Drawing.Size(110, 24);
            this.mnuGuardarActividad.Text = "GUARDAR";
            this.mnuGuardarActividad.Click += new System.EventHandler(this.MnuGuardarActividad_Click);
            // 
            // mnuCancelarActividad
            // 
            this.mnuCancelarActividad.Image = ((System.Drawing.Image)(resources.GetObject("mnuCancelarActividad.Image")));
            this.mnuCancelarActividad.Name = "mnuCancelarActividad";
            this.mnuCancelarActividad.Size = new System.Drawing.Size(114, 24);
            this.mnuCancelarActividad.Text = "CANCELAR";
            this.mnuCancelarActividad.Click += new System.EventHandler(this.MnuCancelarActividad_Click);
            // 
            // mnuInvitar
            // 
            this.mnuInvitar.Image = ((System.Drawing.Image)(resources.GetObject("mnuInvitar.Image")));
            this.mnuInvitar.Name = "mnuInvitar";
            this.mnuInvitar.Size = new System.Drawing.Size(95, 24);
            this.mnuInvitar.Text = "INVITAR";
            this.mnuInvitar.Click += new System.EventHandler(this.MnuInvitar_Click);
            // 
            // mnuAdjuntar
            // 
            this.mnuAdjuntar.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdjuntar.Image")));
            this.mnuAdjuntar.Name = "mnuAdjuntar";
            this.mnuAdjuntar.Size = new System.Drawing.Size(114, 24);
            this.mnuAdjuntar.Text = "ADJUNTAR";
            this.mnuAdjuntar.Click += new System.EventHandler(this.mnuAdjuntar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lugar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripción:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(131, 41);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(255, 29);
            this.txtTitulo.TabIndex = 20;
            this.txtTitulo.Enter += new System.EventHandler(this.TxtTitulo_Enter);
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(131, 82);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(255, 29);
            this.txtLugar.TabIndex = 21;
            this.txtLugar.Enter += new System.EventHandler(this.TxtLugar_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescripcion.Location = new System.Drawing.Point(43, 361);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(367, 121);
            this.rtxtDescripcion.TabIndex = 22;
            this.rtxtDescripcion.Text = "";
            this.rtxtDescripcion.Enter += new System.EventHandler(this.RtxtDescripcion_Enter);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(43, 156);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(275, 217);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(111, 29);
            this.dtpHoraFin.TabIndex = 13;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "";
            this.dtpHoraInicio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(275, 156);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(111, 29);
            this.dtpHoraInicio.TabIndex = 14;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(43, 217);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxTipo);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpHoraInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpHoraFin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rtxtDescripcion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.txtLugar);
            this.panel1.Location = new System.Drawing.Point(37, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 507);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(131, 274);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(255, 29);
            this.cbxTipo.TabIndex = 23;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // openFileSeleccionarArchivos
            // 
            this.openFileSeleccionarArchivos.FileName = "openFileDialog1";
            this.openFileSeleccionarArchivos.Multiselect = true;
            // 
            // FrmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmActividad";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.FrmActividad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardarActividad;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelarActividad;
        private System.Windows.Forms.ToolStripMenuItem mnuAdjuntar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuInvitar;
        private System.Windows.Forms.OpenFileDialog openFileSeleccionarArchivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}

