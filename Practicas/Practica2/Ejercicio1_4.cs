using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio1_4
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int mayor, menor;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Ingrese el numero " + (i+1) + ": ");
                num[i] = int.Parse(Console.ReadLine());
            }
            mayor = num[0];
            menor = num[0];

            for (int i = 0; i < num.Length; i++) 
            {
                if (num[i] > mayor)
                {
                    mayor = num[i];
                }
                if (num[i] < menor) 
                {
                    menor = num[i];
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
            Console.ReadLine();
            
        }
    }
}
