using Dominio;
using Negocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace VistaPrincipal
{
    public partial class frmAddUpdate : Form
    {
        //creo atributos privados null
        private Articulo articulo = null;

        //constructor para crear articulo nuevo
        public frmAddUpdate()
        {
            InitializeComponent();
        }
        //constructor para modificar articulo
        public frmAddUpdate(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        //carga de ventana Agregar/Atualizar articulo
        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            //cargo los desplegables de marca y categoria
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cboAddMarca.DataSource = marcaNegocio.listar();
            cboAddMarca.ValueMember = "Id";
            cboAddMarca.DisplayMember = "Descripcion";
          
            cboAddCategoria.DataSource = categoriaNegocio.listar();
            cboAddCategoria.ValueMember = "Id";
            cboAddCategoria.DisplayMember = "Descripcion";

            //cargo datos en caso de modificar articulo
            if ((articulo != null))
            {
                txtAddCodigo.Text = articulo.CodigoArticulo;
                txtAddNombre.Text = articulo.Nombre;
                txtAddDescripcion.Text = articulo.Descripcion;
                cboAddMarca.SelectedValue = articulo.Marca.Id;
                cboAddCategoria.SelectedValue = articulo.Categoria.Id;
                txtAddPrecio.Text = articulo.Precio.ToString();
                txtAddImagen.Text = articulo.Imagen;
                cargarImagen(txtAddImagen.Text);
            }
            else
            {
                //dejo los campos en blanco para el caso de agregar articulo
                cboAddMarca.ResetText();
                cboAddCategoria.ResetText();
            }
        }
        //cierra la ventana sin guardar nada
        private void btnAddCancelar_Click(object sender, EventArgs e)
        {
            
            Close();
        }
        //logica para agregar articulo nuevo
        private void btnAddAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if(articulo is null)
            {
                //saco el null del articulo,es el caso de agregar un articulo nuevo
                articulo = new Articulo();
                try
                {
                    //controlo que todos los campos esten cargados, no hace falta controlar
                    //marca, categoria, precio ni precio
                    if ((txtAddCodigo.Text.Length < 1) | (txtAddNombre.Text.Length < 1) | 
                        (txtAddDescripcion.Text.Length < 1))
                    {
                        throw new Exception();
                    }
                    articulo.CodigoArticulo = txtAddCodigo.Text.ToUpper();
                    articulo.Nombre = txtAddNombre.Text;
                    articulo.Descripcion = txtAddDescripcion.Text;
                    articulo.Marca = (Marca)cboAddMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cboAddCategoria.SelectedItem;
                    //genero un error si el precio tiene punto en lugar de coma
                    if(txtAddPrecio.Text.Contains('.'))
                        throw new FormatException();
                    articulo.Precio = decimal.Parse(txtAddPrecio.Text);
                    articulo.Imagen = txtAddImagen.Text;

                    //agrego el articulo a la DDBB
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado");
                    Close();

                }
                catch (System.FormatException)
                {
                    //capturo cuando el no puede parsear el campo precio
                    MessageBox.Show("Formato de Precio incorrecto.");
                }
                catch
                {
                    //capturo campos vacios
                    MessageBox.Show("Debe completar todos los campos");

                }
            }
            else
            {
                //en este caso estoy en modificar articulo, por lo que tengo que cambiar
                //la query
                try
                {
                    articulo.CodigoArticulo = txtAddCodigo.Text.ToUpper();
                    articulo.Nombre = txtAddNombre.Text;
                    articulo.Descripcion = txtAddDescripcion.Text;
                    articulo.Marca = (Marca) cboAddMarca.SelectedItem;
                    articulo.Categoria = (Categoria) cboAddCategoria.SelectedItem;
                    //genero un error si el precio tiene punto en lugar de coma
                    if (txtAddPrecio.Text.Contains('.'))
                        throw new FormatException();
                    articulo.Precio = decimal.Parse(txtAddPrecio.Text);
                    articulo.Imagen = txtAddImagen.Text;

                    //actualizo el articulo a la DDBB
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado");
                    Close();
                }
                catch (System.FormatException)
                {
                    //capturo cuando el no puede parsear el campo precio
                    MessageBox.Show("Formato de Precio incorrecto.");
                }
                catch
                {
                    //capturo campos vacios
                    MessageBox.Show("Debe completar todos los campos");

                }

            }
        }

        
        //cargar imagen al cambiar el campo
        private void txtAddImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtAddImagen.Text);
        }

        //cargar imagen en ventana
        private void cargarImagen(string imagen)
        {
            try
            {
                picboxAddImagen.Load(imagen);
            }
            catch
            {
                //imagen por defecto en caso de no encontrar url de la imagen
                picboxAddImagen.Load("https://demofree.sirv.com/nope-not-here.jpg");
            }
        }
        //dialogo para cargar imagen desde archivo
        private void btnAddArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.Filter = "jpg|*.jpg | png|*png | bmp|*bmp | jpeg|*jpeg";
            if(arquivo.ShowDialog() == DialogResult.OK)
            {
                txtAddImagen.Text = arquivo.FileName;
                cargarImagen(txtAddImagen.Text);
            }
        }
    }
}
