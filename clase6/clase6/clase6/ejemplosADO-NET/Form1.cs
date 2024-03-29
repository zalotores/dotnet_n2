﻿using System;
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
    public partial class frmPokemons : Form
    {
        private List<Pokemon> listaPokemons;
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                listaPokemons = negocio.listar();
                dgvPokemons.DataSource = listaPokemons;
                ocultarColumnas();
                cargarImagen(listaPokemons[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas ()
        {
            dgvPokemons.Columns["Id"].Visible = false;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                picbxPokemon.Load(imagen);
            }
            catch
            {
                //imagen por defecto en caso de no tener en la base

                picbxPokemon.Load("https://www.vhv.rs/dpng/d/591-5916931_question-questionmark-missingno-nodata-placeholder-pokemon-question-mark.png");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormElementos))
                {
                    MessageBox.Show("Ya existe una ventana abierta!");
                    return;
                }
            }
            FormElementos ventanaElementos = new FormElementos();
            ventanaElementos.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarPokemon alta = new frmAgregarPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon) dgvPokemons.CurrentRow.DataBoundItem;
            frmAgregarPokemon modificar = new frmAgregarPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true); 
        }

        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar este pokemon?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    if(logico)
                    
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione campo!");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione criterio!");
                return true;
            }
            if ((cboCampo.SelectedItem.ToString() == "Número") && !(soloNumeros(txtFiltroAvanzado.Text)))
            {
                MessageBox.Show("Sólo admite números.");
                return true;
            }
                

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char c in cadena.ToCharArray())
            { if (!(char.IsNumber(c))) return false;}
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;

            string filtro = txtFiltro.Text.Trim().ToLower();

            if (filtro.Length > 2)
            {
                listaFiltrada = listaPokemons.FindAll(p => p.Nombre.Trim().ToLower().Contains(filtro));

            }
            else
            {
                listaFiltrada = listaPokemons;
            }

            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Número")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Mayor a");
            } else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
            }
        }
    }
}
