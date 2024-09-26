using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            string opc;
            double saldo = 0;
            do
            {
                Console.WriteLine("\tBANCO");
                Console.WriteLine("Saldo: " + saldo);
                Console.Write("A) Deposito\nB) Retiro\nC)Salir\n: ");
                opc = Console.ReadLine();
                opc = opc.ToUpper();

                switch (opc)
                {
                    case "A":
                        Console.Write("Cantidad a ingresar: ");
                        double ingreso = double.Parse(Console.ReadLine());
                        saldo += ingreso;
                        break;
                    case "B":
                        Console.Write("Cantidad a retirar: ");
                        double retiro = double.Parse(Console.ReadLine());
                        saldo -= retiro;
                        break;
                    case "C":
                        Console.WriteLine("Adiosito!");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida mi loco...");
                        break;
                }
            } while (opc != "C");    
        }
    }
}
