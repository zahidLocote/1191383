using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Punto 1.");
            Console.WriteLine("Introduce dos numeros reales o flotantes.");

            Console.WriteLine("Numero 1:");
            string n1 = Console.ReadLine();
            float N1 = float.Parse(n1);

            Console.WriteLine("Numero 2:");
            string n2 = Console.ReadLine();
            float N2 = float.Parse(n2);
            Console.WriteLine("Resultado: " + (N1+N2));
        }
    }
}
