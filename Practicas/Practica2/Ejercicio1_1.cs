using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio1_1
    {
        static void Main(string[] args)
        {
            string[] c = new string[5];
            int[] calis = new int[5];
            int prom = 0;
            Console.WriteLine("Calcular calificaciones.");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("Calificacion " + (i + 1) + ": ");
                c[i] = Console.ReadLine();
                calis[i] = int.Parse(c[i]);
                prom = prom + calis[i];
            }
            prom = prom / 5;
            if (prom >= 60)
            {
                Console.WriteLine("Aprobado.");
            }
            else
                Console.WriteLine("NO aprobado.");

            Console.WriteLine("Promedio: " + prom);
            Console.ReadLine();
        }
    }
}
