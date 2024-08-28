using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero de 3 cifras.");
            string num = Console.ReadLine();
            char[] val = num.ToCharArray();
            
            if (val.Length == 3 && int.TryParse(num, out int n))
            {
                Console.WriteLine("Numero introducido: " + num);
                Console.Write("Numero al reves: ");
                for (int i = val.Length - 1; i >= 0; i--)
                {
                    Console.Write(val[i]);
                }
            }else
            {
                Console.WriteLine("Numero invalido...");
            }
            Console.ReadLine();
        }
    }
}
