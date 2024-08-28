using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {

            int E;
            do {
                Console.Write("Ingrese su edad: ");
                string edad = Console.ReadLine();
                E = int.Parse(edad);

                if (E >= 18)
                {
                    Console.WriteLine("Es mayor de edad.");
                }else if(E < 18 && E > 0){
                    Console.WriteLine("Es menor de edad");
                }
                else
                {
                    Console.WriteLine("Edad no valida...");
                }
                
            } while (E != -1);
            Console.ReadLine();
        }
    }
}
