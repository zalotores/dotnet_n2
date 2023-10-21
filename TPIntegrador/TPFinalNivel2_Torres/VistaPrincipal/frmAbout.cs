using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaPrincipal
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        //imagen de perfil
        private void frmAbout_Load(object sender, EventArgs e)
        {
            pictureBoxAbout.Load("https://avatars.githubusercontent.com/u/110064757?s=400&u=98776b5c3710288c78f79b40551089bf15d972d4&v=4");
        }

        private void linkLabelTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/zalotores");
            }
            catch
            {
                MessageBox.Show("twitter.com/zalotores");
            }
        }

        private void linkLabelMaxiPrograma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://campusmaxiprograma.com");
            }
            catch
            {
                MessageBox.Show("campusmaxiprograma.com");
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/zalotores/TPFinalNetN2");
            }
            catch
            {
                MessageBox.Show("github.com/zalotores/TPFinalNetN2");
            }
        }
    }
}
