using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Program
    {

        /*
         * 
    Te voy a dejar una serie de instrucciones para que vayas siguiendo y construyendo con el fin de poner en práctica y ver funcionando lo visto hasta aquí.

    Crear un proyecto de consola .Net Framework.
    Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
    Agregale los siguientes atributos:
        Modelo string.
        Marca string.
        NumeroTelefonico string.
        CodigoOperador int (1, 2 o 3).
    Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
        Modelo: solo lectura. Es decir, solo get.
        Marca: solo lectura.
        NumeroTelefonico: lectura y escritura.
        CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
    Agregar Constructor que reciba Modelo y Marca.
    Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
    Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
    Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
    Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
        *
        */

        static void Main(string[] args)
        {

            Console.WriteLine("Creacion de nuevo telefono.");

            
            Console.Write("Ingrese la marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del telefono: ");
            string modelo = Console.ReadLine();

            Telefono telefono = new Telefono (modelo, marca);

            Console.Write("Ingrese el numero del telefono: ");
            telefono.NumeroTelefonico = Console.ReadLine();
            Console.Write("Ahora, ingrese el operador (1, 2 o 3): ");
            telefono.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Telefono creado con los siguientes parametros:");
            Console.WriteLine("Modelo: " + telefono.Modelo);
            Console.WriteLine("Marca: " + telefono.Marca);
            Console.WriteLine("Operador: " + telefono .CodigoOperador);
            Console.WriteLine("Numero: " + telefono.NumeroTelefonico);

            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Prueba de llamada.");
            Console.WriteLine(telefono.Llamar());
            Console.WriteLine("\nPrueba de llamada a contacto.");
            Console.Write("Ingrese el nombre del contacto: ");
            string contacto = Console.ReadLine();
            Console.WriteLine(telefono.Llamar(contacto));

            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Pruebas completadas. Programa terminado.");
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();

        }
    }
}
