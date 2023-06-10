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
    public partial class Practica5 : Form
    {
        public Practica5()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                return;
            }
            else if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                return;
            }
            else if ((txtEdad.Text == "") || (txtEdad.Text.Contains(";")) || (txtEdad.Text.Contains(":")))
            {
                txtEdad.BackColor = Color.Red;
                return;
            }
            else if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                return;
            }

            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + ", " + txtNombre.Text +
                "\r\nEdad: " + txtEdad.Text +
                "\r\nDirección: " + txtDireccion.Text;

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";

        }

        private void txtApellido_MouseMove(object sender, MouseEventArgs e)
        {
            txtApellido.BackColor = Color.White;
        }

        private void txtNombre_MouseMove(object sender, MouseEventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtEdad_MouseMove(object sender, MouseEventArgs e)
        {
            txtEdad.BackColor = Color.White;
        }

        private void txtDireccion_MouseMove(object sender, MouseEventArgs e)
        {
            txtDireccion.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
