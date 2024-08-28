using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio1_5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double  num = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(num));
            Console.WriteLine("Potencia: " + Math.Pow(num, 2));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));
            Console.WriteLine("Seno: " + Math.Sin(num));
            Console.WriteLine("Coseno: " + Math.Cos(num));
            Console.WriteLine("Redondeo: " + Math.Round(num));
            Console.WriteLine("Trunco: " + Math.Truncate(num));
            Console.ReadLine();
        }
    }
}
