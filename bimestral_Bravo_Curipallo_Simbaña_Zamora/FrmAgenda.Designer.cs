namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    partial class FrmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.dataGridCalendar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cbxAnios = new System.Windows.Forms.ComboBox();
            this.cbxMeses = new System.Windows.Forms.ComboBox();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblViernes = new System.Windows.Forms.Label();
            this.lblJueves = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.lstActividades = new System.Windows.Forms.ListBox();
            this.btnNuevoActividad = new System.Windows.Forms.Button();
            this.btnVerActividad = new System.Windows.Forms.Button();
            this.btnEliminarActividad = new System.Windows.Forms.Button();
            this.btnEditarActividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCalendar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCalendar
            // 
            this.dataGridCalendar.AllowUserToAddRows = false;
            this.dataGridCalendar.AllowUserToResizeColumns = false;
            this.dataGridCalendar.AllowUserToResizeRows = false;
            this.dataGridCalendar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCalendar.ColumnHeadersVisible = false;
            this.dataGridCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCalendar.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridCalendar.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridCalendar.Location = new System.Drawing.Point(7, 214);
            this.dataGridCalendar.MultiSelect = false;
            this.dataGridCalendar.Name = "dataGridCalendar";
            this.dataGridCalendar.RowHeadersVisible = false;
            this.dataGridCalendar.RowHeadersWidth = 10;
            this.dataGridCalendar.RowTemplate.Height = 50;
            this.dataGridCalendar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridCalendar.Size = new System.Drawing.Size(736, 308);
            this.dataGridCalendar.TabIndex = 2;
            this.dataGridCalendar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCalendar_CellEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbxAnios);
            this.panel1.Controls.Add(this.cbxMeses);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 32);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblFin);
            this.panel2.Controls.Add(this.lblSiguiente);
            this.panel2.Controls.Add(this.lblTexto);
            this.panel2.Controls.Add(this.lblAnterior);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 21);
            this.panel2.TabIndex = 3;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(224, 4);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(17, 13);
            this.lblFin.TabIndex = 7;
            this.lblFin.Text = ">|";
            this.lblFin.Click += new System.EventHandler(this.lblFin_Click);
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiguiente.Location = new System.Drawing.Point(199, 4);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(13, 14);
            this.lblSiguiente.TabIndex = 11;
            this.lblSiguiente.Text = ">";
            this.lblSiguiente.Click += new System.EventHandler(this.lblSiguiente_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(58, 3);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 17);
            this.lblTexto.TabIndex = 10;
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnterior.Location = new System.Drawing.Point(27, 4);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(14, 13);
            this.lblAnterior.TabIndex = 9;
            this.lblAnterior.Text = "<";
            this.lblAnterior.Click += new System.EventHandler(this.lblAnterior_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(1, 4);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(17, 13);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "|<";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // cbxAnios
            // 
            this.cbxAnios.FormattingEnabled = true;
            this.cbxAnios.Location = new System.Drawing.Point(454, 4);
            this.cbxAnios.Name = "cbxAnios";
            this.cbxAnios.Size = new System.Drawing.Size(121, 21);
            this.cbxAnios.TabIndex = 1;
            this.cbxAnios.SelectedIndexChanged += new System.EventHandler(this.cbxAnios_SelectedIndexChanged);
            // 
            // cbxMeses
            // 
            this.cbxMeses.FormattingEnabled = true;
            this.cbxMeses.Location = new System.Drawing.Point(328, 5);
            this.cbxMeses.Name = "cbxMeses";
            this.cbxMeses.Size = new System.Drawing.Size(121, 21);
            this.cbxMeses.TabIndex = 0;
            this.cbxMeses.SelectedIndexChanged += new System.EventHandler(this.cbxMeses_SelectedIndexChanged);
            // 
            // lblDomingo
            // 
            this.lblDomingo.AutoSize = true;
            this.lblDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomingo.Location = new System.Drawing.Point(655, 195);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(59, 16);
            this.lblDomingo.TabIndex = 15;
            this.lblDomingo.Text = "label11";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabado.Location = new System.Drawing.Point(553, 195);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(59, 16);
            this.lblSabado.TabIndex = 14;
            this.lblSabado.Text = "label10";
            // 
            // lblViernes
            // 
            this.lblViernes.AutoSize = true;
            this.lblViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViernes.Location = new System.Drawing.Point(457, 195);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(51, 16);
            this.lblViernes.TabIndex = 13;
            this.lblViernes.Text = "label9";
            // 
            // lblJueves
            // 
            this.lblJueves.AutoSize = true;
            this.lblJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJueves.Location = new System.Drawing.Point(355, 195);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(51, 16);
            this.lblJueves.TabIndex = 12;
            this.lblJueves.Text = "label8";
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.AutoSize = true;
            this.lblMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiercoles.Location = new System.Drawing.Point(257, 195);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(51, 16);
            this.lblMiercoles.TabIndex = 11;
            this.lblMiercoles.Text = "label7";
            // 
            // lblMartes
            // 
            this.lblMartes.AutoSize = true;
            this.lblMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMartes.Location = new System.Drawing.Point(157, 195);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(51, 16);
            this.lblMartes.TabIndex = 10;
            this.lblMartes.Text = "label6";
            // 
            // lblLunes
            // 
            this.lblLunes.AutoSize = true;
            this.lblLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunes.Location = new System.Drawing.Point(53, 195);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(51, 16);
            this.lblLunes.TabIndex = 9;
            this.lblLunes.Text = "label3";
            // 
            // lstActividades
            // 
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(20, 61);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(2);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(296, 95);
            this.lstActividades.TabIndex = 16;
            this.lstActividades.SelectedIndexChanged += new System.EventHandler(this.lstActividades_SelectedIndexChanged_1);
            // 
            // btnNuevoActividad
            // 
            this.btnNuevoActividad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoActividad.Image")));
            this.btnNuevoActividad.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNuevoActividad.Location = new System.Drawing.Point(358, 67);
            this.btnNuevoActividad.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoActividad.Name = "btnNuevoActividad";
            this.btnNuevoActividad.Size = new System.Drawing.Size(127, 33);
            this.btnNuevoActividad.TabIndex = 17;
            this.btnNuevoActividad.Text = "       Nuevo";
            this.btnNuevoActividad.UseVisualStyleBackColor = true;
            this.btnNuevoActividad.Click += new System.EventHandler(this.btnNuevoActividad_Click);
            // 
            // btnVerActividad
            // 
            this.btnVerActividad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnVerActividad.Image")));
            this.btnVerActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerActividad.Location = new System.Drawing.Point(358, 124);
            this.btnVerActividad.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerActividad.Name = "btnVerActividad";
            this.btnVerActividad.Size = new System.Drawing.Size(127, 35);
            this.btnVerActividad.TabIndex = 18;
            this.btnVerActividad.Text = "              Detalles";
            this.btnVerActividad.UseVisualStyleBackColor = true;
            this.btnVerActividad.Click += new System.EventHandler(this.btnVerActividad_Click);
            // 
            // btnEliminarActividad
            // 
            this.btnEliminarActividad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarActividad.Image")));
            this.btnEliminarActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarActividad.Location = new System.Drawing.Point(556, 127);
            this.btnEliminarActividad.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarActividad.Name = "btnEliminarActividad";
            this.btnEliminarActividad.Size = new System.Drawing.Size(127, 29);
            this.btnEliminarActividad.TabIndex = 19;
            this.btnEliminarActividad.Text = "       Eliminar";
            this.btnEliminarActividad.UseVisualStyleBackColor = true;
            this.btnEliminarActividad.Click += new System.EventHandler(this.btnEliminarActividad_Click);
            // 
            // btnEditarActividad
            // 
            this.btnEditarActividad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarActividad.Image")));
            this.btnEditarActividad.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditarActividad.Location = new System.Drawing.Point(556, 67);
            this.btnEditarActividad.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarActividad.Name = "btnEditarActividad";
            this.btnEditarActividad.Size = new System.Drawing.Size(127, 33);
            this.btnEditarActividad.TabIndex = 20;
            this.btnEditarActividad.Text = "      Editar";
            this.btnEditarActividad.UseVisualStyleBackColor = true;
            this.btnEditarActividad.Click += new System.EventHandler(this.btnEditarActividad_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 535);
            this.Controls.Add(this.btnEditarActividad);
            this.Controls.Add(this.btnEliminarActividad);
            this.Controls.Add(this.btnVerActividad);
            this.Controls.Add(this.btnNuevoActividad);
            this.Controls.Add(this.lstActividades);
            this.Controls.Add(this.lblDomingo);
            this.Controls.Add(this.lblSabado);
            this.Controls.Add(this.lblViernes);
            this.Controls.Add(this.lblJueves);
            this.Controls.Add(this.lblMiercoles);
            this.Controls.Add(this.lblMartes);
            this.Controls.Add(this.lblLunes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgenda";
            this.Text = "FrmAgenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCalendar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.ComboBox cbxAnios;
        private System.Windows.Forms.ComboBox cbxMeses;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ListBox lstActividades;
        private System.Windows.Forms.Button btnNuevoActividad;
        private System.Windows.Forms.Button btnVerActividad;
        private System.Windows.Forms.Button btnEliminarActividad;
        private System.Windows.Forms.Button btnEditarActividad;
    }
}