using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Telefono
    {

        public string Modelo { get;}
        public string Marca { get;}
        public string NumeroTelefonico { get; set;}

        private int codigoOperador;
        public int CodigoOperador
        {
            get { return codigoOperador; }

            set
            {
                if ((value > 0) && (value < 4))
                {
                    codigoOperador = value;

                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        public Telefono( string modelo, string marca )
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar( string contacto )
        {
            return "Llamando a " + contacto;
        }

    }
}
