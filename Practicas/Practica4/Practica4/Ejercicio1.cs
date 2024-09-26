using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            List<int> edades = new List<int>();
            int edad = 0;

            while (edad != -1)
            {
                Console.Write("Ingrese una edad (Utilice el -1 para dejar de ingresar): ");
                edad = int.Parse(Console.ReadLine());
                if (edad > -1)
                {
                    edades.Add(edad);
                }
            }
            Console.WriteLine("Edad mayor: " + edades.Max());
            Console.WriteLine("Edad menor: " + edades.Min());
            Console.ReadKey();
        }
    }
}
