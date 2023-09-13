using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ejemplosADO_NET
{
    public partial class frmAgregarPokemon : Form
    {
        public frmAgregarPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelarPokemon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarPokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;

                negocio.agregar(pokemon);
                MessageBox.Show("Agregado exitosamente!");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
