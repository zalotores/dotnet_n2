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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola mundo!");
            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola " + nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido!");
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Negro");
            cboColor.Items.Add("Amarillo");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Gracias por usar la aplicacion!");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtElementoNombre.Text;
            lvElementos.Items.Add(elemento);
            txtElementoNombre.Text = "";
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtElementoNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtSquibs.Checked)
                tipo = "Squibs";
            else tipo = "Wizard";

            string colorFavorito = cboColor.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            MessageBox.Show("Nombre: " + nombre + "\nFecha: " + fecha.ToShortDateString() + "\n" + chocolate + "\nEs " + tipo + "\nColor: " + colorFavorito + "\nNumero favorito: " + numeroFavorito);
        }
    }
}
