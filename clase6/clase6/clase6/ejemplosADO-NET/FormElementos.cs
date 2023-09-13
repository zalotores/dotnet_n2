using negocio;
using System;
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
    public partial class FormElementos : Form
    {
        public FormElementos()
        {
            InitializeComponent();
        }

        private void FormElementos_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();
            dgvElementos.DataSource = negocio.listar();
            
        }
    }
}
