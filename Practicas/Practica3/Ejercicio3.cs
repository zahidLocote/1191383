using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case int num when num < 50:
                    Console.WriteLine("El numero es menor a 50.");
                    break;
                case int num when num > 50:
                    Console.WriteLine("El numero es mayor a 50.");
                    break;
                case 50:
                    Console.WriteLine("El numero es 50.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
