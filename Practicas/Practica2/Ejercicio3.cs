using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int opc;
            do
            {
                Console.WriteLine("CALCULAR AREAS");

                Console.WriteLine("1) Rectangulo\n2) Circulo\n3) Triangulo");
                Console.Write("¿Que desea calcular?: ");
                string linea = Console.ReadLine();
                opc = int.Parse(linea);

                if (linea == "1")
                {
                    Console.WriteLine("Rectangulo.");
                    Console.Write("Ingrese la base: ");
                    string b = Console.ReadLine();
                    int B = int.Parse(b);
                    Console.Write("Ingrese la altura: ");
                    string a = Console.ReadLine();
                    int A = int.Parse(a);
                    Console.WriteLine("Resultado: " + (A*B));
                }
                else if (linea == "2")
                {
                    Console.WriteLine("Circulo.");
                    Console.Write("Ingrese el radio: ");
                    string r = Console.ReadLine();
                    int R = int.Parse(r);
                    Console.WriteLine("Resultado: " + (3.1416 * (R * R)));
                }
                else if (linea == "3")
                {
                    Console.WriteLine("Triangulo.");
                    Console.Write("Ingrese la base: ");
                    string b = Console.ReadLine();
                    int B = int.Parse(b);
                    Console.Write("Ingrese la altura");
                    string a = Console.ReadLine();
                    int A = int.Parse(a);
                    Console.WriteLine("Resultado: " + ((B * A) / 2)); 
                }
                else
                {
                    Console.WriteLine("Opcion invalida...");
                }
            } while (opc != -1);
        }
    }
}
