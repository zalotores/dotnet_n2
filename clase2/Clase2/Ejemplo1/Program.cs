using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona();

            p1.setEdad(20);

            Console.WriteLine("La edad de la persona es " + p1.getEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int algo = b1.Capacidad;

            Perro perro = new Perro();

            Console.Write("Como se llama el choco? ");
            perro.Nombre = Console.ReadLine();
            Console.Write("\nDe que color es? ");
            perro.Color = Console.ReadLine();
            Console.Write("\nY de que raza? ");
            perro.Origen = Console.ReadLine();

            Console.WriteLine("\nEntonces, el perro se llama " + perro.Nombre + " y es " +
                "un " + perro.Origen + " de color " + perro.Color);

            Console.ReadKey();

        }
    }
}
