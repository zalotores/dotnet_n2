using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana abierta!");
                    return;
                }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            //ventana.ShowDialog();
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {

            perfilPersonaToolStripMenuItem_Click(sender, e);

        }

        private void practico4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormPractico))
                {
                    MessageBox.Show("Ya existe una ventana abierta!");
                    return;
                }
            }

            FormPractico ventanaPractico = new FormPractico();
            ventanaPractico.MdiParent = this;
            ventanaPractico.Show();

        }

        private void tsbPractico_Click(object sender, EventArgs e)
        {
            practico4ToolStripMenuItem_Click(sender, e);
        }
    }
}
