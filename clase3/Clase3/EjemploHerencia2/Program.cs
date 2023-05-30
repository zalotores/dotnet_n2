﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "Amarillo";
            c2.Color = "Roja";
            c3.Color = "Blanca";

            List<Camioneta> listaCamionetas = new List<Camioneta>(); 

            listaCamionetas.Add(c1);
            listaCamionetas.Add (c2);
            listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            //listaCamionetas[1].Color = "Verde";

            //Console.WriteLine("EL color de la camioneta 2 es " + listaCamionetas[1].Color);

            //listaCamionetas.Remove(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            foreach (Camioneta item in listaCamionetas)
            {

                Console.WriteLine("Color : " + item.Color);
                
            }

            Console.ReadKey();

        }
    }
}
