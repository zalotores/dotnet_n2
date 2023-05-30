using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia2
{
    internal class AutoDeportivo : Auto
    {

        public override int cantidadUsuarios()
        {
            //return base.cantidadUsuarios();
            return 2;
        }
    }
}
