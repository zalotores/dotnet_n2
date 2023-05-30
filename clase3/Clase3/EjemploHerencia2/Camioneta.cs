using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia2
{
    internal class Camioneta : Vehiculo, Cargable
    {
        public string capacidadCarga()
        {
            return "carga en caja y en carro";
        }
    }
}
