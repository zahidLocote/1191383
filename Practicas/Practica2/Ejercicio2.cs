using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int AN;
            do
            {
                Console.Write("Ingrese un año:");
                string an = Console.ReadLine();
                AN = int.Parse(an);

                if (AN % 4 == 0 && AN % 100 != 0)
                {
                    Console.WriteLine("El año " + AN +" ES bisiesto.");
                }else if (AN % 100 == 0 && AN % 400 == 0)
                {
                    Console.WriteLine("El año " + AN + " ES bisiesto.");
                }
                else
                {
                    Console.WriteLine("El año " + AN + " NO ES bisiesto.");
                }
            }while (AN != -1);
           
        }
    }
}
