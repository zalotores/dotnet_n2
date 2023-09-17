using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace ejemplosADO_NET
{
    public partial class frmAgregarPokemon : Form
    {
        private Pokemon pokemon = null;
        OpenFileDialog archivo = null;
        public frmAgregarPokemon()
        {
            InitializeComponent();
        }

        public frmAgregarPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnCancelarPokemon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarPokemon_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if (pokemon == null) 
                    pokemon = new Pokemon();
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento) cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento) cboDebilidad.SelectedItem;

                //guardo imagen si la levanto localmente
                if ((archivo != null) && !(txtUrlImagen.Text.ToLower().Contains("http")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpetaImagenes"] + archivo.SafeFileName);
                }


                if (pokemon.Id !=  0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente!");
                }

                
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.id;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch
            {
                //imagen por defecto en caso de no tener en la base

                pbxPokemon.Load("https://www.vhv.rs/dpng/d/591-5916931_question-questionmark-missingno-nodata-placeholder-pokemon-question-mark.png");

            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg | png|*png";
            if (archivo.ShowDialog()  == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardar la imagen using Sistem.IO
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpetaImagenes"] + archivo.SafeFileName);

            }
        }
    }
}
