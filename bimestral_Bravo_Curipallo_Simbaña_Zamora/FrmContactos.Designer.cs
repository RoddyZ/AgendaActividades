namespace bimestral_Bravo_Curipallo_Simbaña_Zamora
{
    partial class FrmContactos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNuevoContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstInvitados = new System.Windows.Forms.ListBox();
            this.btnInvitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cstContactos = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoContacto,
            this.mnuCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuNuevoContacto
            // 
            this.mnuNuevoContacto.Image = ((System.Drawing.Image)(resources.GetObject("mnuNuevoContacto.Image")));
            this.mnuNuevoContacto.Name = "mnuNuevoContacto";
            this.mnuNuevoContacto.Size = new System.Drawing.Size(169, 24);
            this.mnuNuevoContacto.Text = "NUEVO CONTACTO";
            this.mnuNuevoContacto.Click += new System.EventHandler(this.mnuNuevoContacto_Click);
            // 
            // mnuCancelar
            // 
            this.mnuCancelar.Image = ((System.Drawing.Image)(resources.GetObject("mnuCancelar.Image")));
            this.mnuCancelar.Name = "mnuCancelar";
            this.mnuCancelar.Size = new System.Drawing.Size(114, 24);
            this.mnuCancelar.Text = "CANCELAR";
            this.mnuCancelar.Click += new System.EventHandler(this.mnuCancelar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstInvitados
            // 
            this.lstInvitados.FormattingEnabled = true;
            this.lstInvitados.HorizontalScrollbar = true;
            this.lstInvitados.ItemHeight = 16;
            this.lstInvitados.Location = new System.Drawing.Point(404, 97);
            this.lstInvitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstInvitados.Name = "lstInvitados";
            this.lstInvitados.Size = new System.Drawing.Size(295, 276);
            this.lstInvitados.TabIndex = 3;
            // 
            // btnInvitar
            // 
            this.btnInvitar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvitar.Image = ((System.Drawing.Image)(resources.GetObject("btnInvitar.Image")));
            this.btnInvitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvitar.Location = new System.Drawing.Point(109, 389);
            this.btnInvitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvitar.Name = "btnInvitar";
            this.btnInvitar.Size = new System.Drawing.Size(172, 37);
            this.btnInvitar.TabIndex = 4;
            this.btnInvitar.Text = "            INVITAR";
            this.btnInvitar.UseVisualStyleBackColor = true;
            this.btnInvitar.Click += new System.EventHandler(this.btnInvitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTACTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "INVITADOS";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(463, 389);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(184, 37);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "       FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cstContactos
            // 
            this.cstContactos.CheckOnClick = true;
            this.cstContactos.FormattingEnabled = true;
            this.cstContactos.HorizontalScrollbar = true;
            this.cstContactos.Location = new System.Drawing.Point(59, 92);
            this.cstContactos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cstContactos.Name = "cstContactos";
            this.cstContactos.Size = new System.Drawing.Size(268, 259);
            this.cstContactos.TabIndex = 8;
            // 
            // FrmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.cstContactos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvitar);
            this.Controls.Add(this.lstInvitados);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmContactos";
            this.Text = "FrmContactos";
            this.Load += new System.EventHandler(this.FrmContactos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoContacto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lstInvitados;
        private System.Windows.Forms.Button btnInvitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckedListBox cstContactos;
    }
}