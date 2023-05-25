using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Primer lote con 10 registros de productos, cada producto tiene:
             *   -Codigo articulo (3 digitos no correlativos)
             *   -Precio
             *   -Codigo de marca (1 a 10)
             * Segundo lote con las ventas de la semana. Cada venta tiene:
             *  -Codigo articulo
             *  -Cantidad
             *  -Codigo cliente (1 a 100)
             * Este lote corta con codigo de cliente = 0.
             * 
            */

            Console.WriteLine("\n--------------");
            Console.WriteLine("    ARTICULOS");

            Articulo[] articulos = new Articulo[10];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("\nIngrese los datos del producto " + (i+1));
                Console.Write("Codigo de Articulo: ");
                articulos[i].codigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Precio Unitario: ");
                articulos[i].precio = float.Parse(Console.ReadLine());
                Console.Write("Marca (1 a 10): ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());

            }

            //cargados articulos

            Console.WriteLine("\n--------------");
            Console.WriteLine("    VENTAS");

            Venta venta = new Venta();

            Console.WriteLine("\nIngrese la venta, o '0' para terminar");
            Console.Write("Codigo de Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {

                Console.Write("Articulo: ");
                venta.Articulo = int.Parse(Console.ReadLine());
                Console.Write("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //TODO lo que haya que hacer y despues pide proxima venta

                Console.WriteLine("\nIngrese la venta, o '0' para terminar");
                Console.Write("Codigo de Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }

        }
    }
}
