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

        private void btn1_Click(object sender, EventArgs e)
        {
            int a, b, res;

            try
            {

                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                res = a / b;

                lblResultado.Text = "= " + res;

            }
            catch (FormatException ex)
            {

                MessageBox.Show("Solo admite numeros enteros!");
            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("No se puede dividir por 0!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!");
            }
            finally
            {
                //esto sirve para operaciones sensibles, por ejemplo cerrar conexion db
            }

        }
    }
}
