using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {

        /*  *   -Codigo articulo(3 digitos no correlativos)
            *   -Precio
            *   -Codigo de marca (1 a 10)
        */

        //private int codigoArticulo;
        public int codigoArticulo { get; set; }

        //private float precio;
        public float precio { get; set; }

        private int codigoMarca;

        public int CodigoMarca
        {
            get { return  codigoMarca; }
            set 
            {
                if ((value > 0) && (value < 11))
                {
                    codigoMarca = value;
                } else
                {
                    codigoMarca = -1;
                }
                
            }
        }
    }
}
