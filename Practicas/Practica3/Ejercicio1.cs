using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Ingrese un numero entre 1 y 8: ");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Resultado: " + Math.Pow(num,2));
                        break;
                    default:
                        Console.WriteLine("Numero invalido...");
                        break;

                }
            } while (num != -1);
        }
    }
}
