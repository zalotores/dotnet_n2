using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia2
{
    internal class Auto : Vehiculo
    {

        public Auto() { 
            Chasis = new Chasis();
        }

        public string Anho { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }

       


        //override functions
        public virtual int cantidadUsuarios()
        {
            return 5;
        }

        //asociacion
        //Composicion
        public Chasis Chasis { get; }

        //Agregacion
        public Motor Motor { get; set; }
    }
}
