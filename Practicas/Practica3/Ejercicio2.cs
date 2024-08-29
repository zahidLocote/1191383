using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Calculadora.");
            do
            {
                Console.Write("Ingrese el primer numero: ");
                float num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                float num2 = int.Parse(Console.ReadLine());
                Console.Write("Seleccione una de las opciones: \n1)Suma\n2)Resta\n3)Multiplicacion\n4)Division\n5)Salir\n: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("La suma del primer numero con el segundo numero es: " + (num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("La resta del primer numero con el segundo numero es: " + (num1-num2));
                        break;
                    case 3:
                        Console.WriteLine("La multiplicacion del primer numero con el segundo numero es: " + (num1*num2));
                        break;
                    case 4:
                        Console.WriteLine("La division del primer numero entre el segundo numero es: " + (num1/num2));
                        break;
                    default:
                        Console.WriteLine("Opcion invalida...");
                        break;
                }

            } while (opc != 5);
        }
    }
}
