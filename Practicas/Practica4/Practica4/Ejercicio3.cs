using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                int suma = 0;
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 2 == 0)
                        suma += i;
                }
                Console.WriteLine("Suma de numeros pares entre " + n1 + " y " + n2 + ": " + suma);
            }
            else
                Console.WriteLine("El primer numero debe ser menor al segundo.");
            Console.ReadLine();
        }
    }
}
