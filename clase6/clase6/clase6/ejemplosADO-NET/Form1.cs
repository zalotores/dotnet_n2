﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listar();
            dgvPokemons.DataSource = listaPokemons;
            dgvPokemons.Columns["UrlImagen"].Visible = false;   

            cargarImagen(listaPokemons[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon) dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                picbxPokemon.Load(imagen);
            }
            catch (Exception e)
            {
                //imagen por defecto en caso de no tener en la base

                picbxPokemon.Load("https://www.vhv.rs/dpng/d/591-5916931_question-questionmark-missingno-nodata-placeholder-pokemon-question-mark.png");

            }
        }
    }
}
