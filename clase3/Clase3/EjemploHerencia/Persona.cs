using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    abstract class Persona
        // sealed me impide que pueda heredar a clases hijas
        //static no permite instanciar pero esta todo el tiempo disponible, mismo los metodos
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }

    }
}
