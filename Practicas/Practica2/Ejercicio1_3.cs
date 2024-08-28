using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio1_3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Es par.");
            else
                Console.WriteLine("Es impar.");

            Console.ReadLine();
        }
    }
}
