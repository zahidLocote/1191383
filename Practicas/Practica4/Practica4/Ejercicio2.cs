using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros primos");
            Console.Write("Ingrese el numero donde empezara el rango: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero para delimitar el rango: ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            { 
                if (i % 2 != 0)
                    Console.WriteLine(i + " ");  
            }
            Console.ReadLine();
        }
    }
}
