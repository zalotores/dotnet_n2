namespace VistaPrincipal
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblanho = new System.Windows.Forms.Label();
            this.lblExplicacion = new System.Windows.Forms.Label();
            this.linkLabelMaxiPrograma = new System.Windows.Forms.LinkLabel();
            this.linkLabelTwitter = new System.Windows.Forms.LinkLabel();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.lblContactoAbout = new System.Windows.Forms.Label();
            this.lblMailAbout = new System.Windows.Forms.Label();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblanho
            // 
            this.lblanho.AutoSize = true;
            this.lblanho.Location = new System.Drawing.Point(175, 219);
            this.lblanho.Name = "lblanho";
            this.lblanho.Size = new System.Drawing.Size(87, 13);
            this.lblanho.TabIndex = 0;
            this.lblanho.Text = "Septiembre 2023";
            // 
            // lblExplicacion
            // 
            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Location = new System.Drawing.Point(12, 9);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(395, 13);
            this.lblExplicacion.TabIndex = 1;
            this.lblExplicacion.Text = "App WinForms desarrollada como TP Integrador para el nivel 2 de .Net Framework";
            // 
            // linkLabelMaxiPrograma
            // 
            this.linkLabelMaxiPrograma.AutoSize = true;
            this.linkLabelMaxiPrograma.Location = new System.Drawing.Point(12, 98);
            this.linkLabelMaxiPrograma.Name = "linkLabelMaxiPrograma";
            this.linkLabelMaxiPrograma.Size = new System.Drawing.Size(115, 13);
            this.linkLabelMaxiPrograma.TabIndex = 2;
            this.linkLabelMaxiPrograma.TabStop = true;
            this.linkLabelMaxiPrograma.Text = "Campus MaxiPrograma";
            this.linkLabelMaxiPrograma.UseMnemonic = false;
            this.linkLabelMaxiPrograma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMaxiPrograma_LinkClicked);
            // 
            // linkLabelTwitter
            // 
            this.linkLabelTwitter.AutoSize = true;
            this.linkLabelTwitter.Location = new System.Drawing.Point(12, 125);
            this.linkLabelTwitter.Name = "linkLabelTwitter";
            this.linkLabelTwitter.Size = new System.Drawing.Size(39, 13);
            this.linkLabelTwitter.TabIndex = 3;
            this.linkLabelTwitter.TabStop = true;
            this.linkLabelTwitter.Text = "Twitter";
            this.linkLabelTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTwitter_LinkClicked);
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 156);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkLabelGitHub.TabIndex = 4;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // lblContactoAbout
            // 
            this.lblContactoAbout.AutoSize = true;
            this.lblContactoAbout.Location = new System.Drawing.Point(12, 43);
            this.lblContactoAbout.Name = "lblContactoAbout";
            this.lblContactoAbout.Size = new System.Drawing.Size(53, 13);
            this.lblContactoAbout.TabIndex = 5;
            this.lblContactoAbout.Text = "Contacto:";
            // 
            // lblMailAbout
            // 
            this.lblMailAbout.AutoSize = true;
            this.lblMailAbout.Location = new System.Drawing.Point(12, 72);
            this.lblMailAbout.Name = "lblMailAbout";
            this.lblMailAbout.Size = new System.Drawing.Size(107, 13);
            this.lblMailAbout.TabIndex = 6;
            this.lblMailAbout.Text = "zalotores@gmail.com";
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Location = new System.Drawing.Point(178, 43);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(163, 164);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbout.TabIndex = 7;
            this.pictureBoxAbout.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 241);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.lblMailAbout);
            this.Controls.Add(this.lblContactoAbout);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.linkLabelTwitter);
            this.Controls.Add(this.linkLabelMaxiPrograma);
            this.Controls.Add(this.lblExplicacion);
            this.Controls.Add(this.lblanho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 280);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblanho;
        private System.Windows.Forms.Label lblExplicacion;
        private System.Windows.Forms.LinkLabel linkLabelMaxiPrograma;
        private System.Windows.Forms.LinkLabel linkLabelTwitter;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label lblContactoAbout;
        private System.Windows.Forms.Label lblMailAbout;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
    }
}