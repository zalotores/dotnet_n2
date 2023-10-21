using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace VistaPrincipal
{
    public partial class frmPrincipal : Form
    {
        //lista donde se van a mostrar los articulos en pantalla
        private List<Articulo> listaArticulos;
        //flag para saber si esta aplicado un filtro
        bool filtrado = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //inicio filtros, seteo valor a vacio, y cargo listado de articulos
            iniciarFiltros();
        }

        //carga de tabla
        private void cargar()
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(!filtrado)   //solamente entra cuando no esta aplicado filtro
                {
                    listaArticulos = negocio.listar();
                }
                dgvArticulos.DataSource = listaArticulos;
                fomatearColumnas();
            }
            catch 
            {
                MessageBox.Show("Error al conectar a la Base de Datos");
            }
        }

        //formato de data grid
        private void fomatearColumnas()
        {
            //oculta columnas que trae de DDBB pero no quiero visualizar
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;

            //cambio el formato de precio para que muestre dos decimales
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";

        }
        //entrada a ventana detalle
        private void dgvArticulos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(dgvArticulos.CurrentRow is null))
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalle detalle = new frmDetalle(seleccionado);
                detalle.Show();
            }
            else
            {
                //si la lista esta vacia informa al usuario
                MessageBox.Show("Ningun artículo listado!");
            }
        }

        //entrada a ventana agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddUpdate agregar = new frmAddUpdate();
            //creo instancia unica
            agregar.ShowDialog();
            cargar();
        }
        //entrada para modificar articulo
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(dgvArticulos.CurrentRow is null))
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAddUpdate modificar = new frmAddUpdate(seleccionado);
                //creo instancia unica
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                //si la lista esta vacia informa al usuario
                MessageBox.Show("Ningun artículo listado!");
            }
        }
        //entrada para eliminar articulo
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                //pido confirmacion
                DialogResult respuesta = MessageBox.Show("Eliminar el artículo " + 
                    seleccionado.Nombre + "?", "Eliminando...", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    //envio el id para eliminar al negocio
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar articulo.");
            }
        }
        //borrar filtros y resetear lista de articulos
        private void btnFiltroReset_Click(object sender, EventArgs e)
        {
            filtrado = false;
            resetFiltros();
        }
        //logica para filtrar datos
        private void btnFiltroAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            //genero variables para enviar el filtro
            Marca marcaFiltro = new Marca();
            Categoria catFiltro = new Categoria();
            string codigoFiltro = "";
            string nombreFiltro = "";
            string descripcionFiltro = "";
            string campoFiltro = "";
            decimal precioMinFiltro = 0;
            decimal precioMaxFiltro = decimal.MaxValue;

            //filtro valores incorrectos precio
            try
            {
                if(txtFiltroRangoMin.Text.Length > 0)   //reviso que no este vacio
                    precioMinFiltro = decimal.Parse(txtFiltroRangoMin.Text);
                if (txtFiltroRangoMin.Text.Contains("."))   //reviso que tenga ',' en lugar de '.'
                    throw new FormatException();
                if (txtFiltroRangoMax.Text.Length > 0)
                    precioMaxFiltro = decimal.Parse(txtFiltroRangoMax.Text);
                if(txtFiltroRangoMax.Text.Contains("."))
                    throw new FormatException();
                if (precioMinFiltro < 0)
                    throw new Exception("El precio mínimo debe ser mayor o igual a cero.");
                if (precioMaxFiltro < precioMinFiltro)
                    throw new Exception("Precio máximo no puede ser menor al precio mínimo.");
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese correctamente el parametro Precio.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                // cargo marca y categoria
                marcaFiltro = (Marca)cboFiltroMarca.SelectedItem;
                catFiltro = (Categoria)cboFiltroCategoria.SelectedItem;

                //cargo parametro de filtrado adicional
                string txtFiltrado = cboFiltroParam.SelectedItem.ToString();
                campoFiltro = txtFiltroParam.Text.Trim();
                if (campoFiltro.Length > 0)  //si no esta vacio el campo cargo donde corresponda
                {
                    if (txtFiltrado == "Código")
                        codigoFiltro = campoFiltro;
                    else if (txtFiltrado == "Nombre")
                        nombreFiltro = campoFiltro;
                    else if (txtFiltrado == "Descripción")
                        descripcionFiltro = campoFiltro;
                }

                //ya seteados los parametros, envio query

                listaArticulos = negocio.filtrar(marcaFiltro, catFiltro, codigoFiltro, nombreFiltro,
                    descripcionFiltro, precioMinFiltro, precioMaxFiltro);
                filtrado = true;
                cargar();
            }
            catch
            {

            }
            
        }

        //funcion reset filtros
        private void resetFiltros()
        {
            //borrar todos los filtros
            cboFiltroCategoria.SelectedIndex = 0;
            cboFiltroMarca.SelectedIndex = 0;
            cboFiltroParam.ResetText();
            txtFiltroParam.Text = "";
            txtFiltroRangoMin.Text = "";
            txtFiltroRangoMax.Text = "";

            //volver a cargar lista
            cargar();
        }

        //funcion para inicializar combo box de filtros
        private void iniciarFiltros()
        {            
            //filtro para seccion marca / categoria
            List<Marca> listaMarcas = new List<Marca>();
            MarcaNegocio marcaNeg = new MarcaNegocio();
            listaMarcas = marcaNeg.listar();
            Marca ceroM = new Marca();  //cargo el primer item vacio con id = 0
            ceroM.Descripcion = "";
            cboFiltroMarca.Items.Add(ceroM);
            foreach (Marca i in listaMarcas)
            {
                cboFiltroMarca.Items.Add(i);
            }

            cboFiltroMarca.ValueMember = "Id";
            cboFiltroMarca.DisplayMember = "Descripcion";

            List<Categoria> listaCategoria = new List<Categoria>();
            CategoriaNegocio catNeg = new CategoriaNegocio();
            listaCategoria = catNeg.listar();
            Categoria ceroC = new Categoria();
            ceroC.Descripcion = "";
            cboFiltroCategoria.Items.Add(ceroC);
            foreach(Categoria i in listaCategoria)
            {
                cboFiltroCategoria.Items.Add(i);
            }
            cboFiltroCategoria.ValueMember = "Id";
            cboFiltroCategoria.DisplayMember = "Descripcion";

            //filtros para seccion parametros
            cboFiltroParam.Items.Add("");
            cboFiltroParam.Items.Add("Código");
            cboFiltroParam.Items.Add("Nombre");
            cboFiltroParam.Items.Add("Descripción");

            resetFiltros();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
