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
    public partial class FormPractico : Form
    {
        public FormPractico()
        {
            InitializeComponent();
        }

        private void FormPractico_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Practico 4 - Todos los ejercicios estan aplicados en esta ventana");
        }

        private void FormPractico_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau adios...");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("Se disparo el evento Click", "Atención");
            if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.LightGray;
            } else
            {
                this.BackColor = Color.Blue;
            }*/

            if (txt1.Text == "")
                txt1.BackColor = Color.Red;
            else
                txt1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void FormPractico_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presiono el botón Izquierdo", "Información");
            } 
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presiono el botón Derecho", "Información");
            }
            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presiono el botón del Medio", "Información");
            }
        }

        private void lbl1_MouseMove(object sender, MouseEventArgs e)
        {
            lbl1.BackColor = Color.Cyan;
            lbl1.Cursor = Cursors.Hand;
        }

        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.BackColor = System.Drawing.SystemColors.Control;
            lbl1.Cursor = Cursors.Arrow;
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txt2.Text.Length + " Caracteres");
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Practica5))
                {
                    MessageBox.Show("Ya existe una ventana abierta!");
                    return;
                }
            }

            Practica5 ventanaPractico = new Practica5();
            ventanaPractico.Show();
        }

    }
}
