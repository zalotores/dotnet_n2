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

namespace VistaPrincipal
{
    public partial class frmDetalle : Form
    {
        Articulo articulo = new Articulo();
        public frmDetalle(Articulo articuloSeleccionado)
        {
            this.articulo = articuloSeleccionado;
            InitializeComponent();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            //cargo los datos en los labels de articulo
            lblDetalleResCodigo.Text = articulo.CodigoArticulo.ToString();
            lblDetalleResCategoria.Text = articulo.Categoria.ToString();
            lblDetalleResMarca.Text = articulo.Marca.ToString();
            lblDetalleResNombre.Text = articulo.Nombre.ToString();
            txtboxDetalleResDescripcion.Text = articulo.Descripcion.ToString();
            lblDetalleResPrecio.Text = articulo.Precio.ToString("$ 0.00");

            //cargo imagen de articulo
            cargarImagen(articulo.Imagen.ToString());
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbDetalle.Load(imagen);
            }
            catch
            {
                //imagen por defecto en caso de no encontrar url de la imagen
                pcbDetalle.Load("https://demofree.sirv.com/nope-not-here.jpg");
            }
        }
    }
}
