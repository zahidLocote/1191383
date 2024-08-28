using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio1_2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su sexo: ");
            string sexo = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (sexo.Equals("Masculino") && edad >= 18 && edad <= 30)
            {
                Console.WriteLine("Valido.");
            }
            else
                Console.WriteLine("Invalido.");
            Console.ReadLine();

        }
            
    }
}
