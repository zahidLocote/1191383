using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicioSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cali;
            Console.WriteLine("Registro de calificaciones.");
            do
            {
                Console.Write("Ingresa la calificacion del alumno: ");
                string c = Console.ReadLine();
                cali = int.Parse(c);

                switch (cali)
                {
                    case 10:
                        Console.WriteLine("Excelente.");
                        break;
                    case 9:
                        Console.WriteLine("Muy bien.");
                        break;
                    case 8:
                        Console.WriteLine("Bien.");
                        break;
                    case 7:
                        Console.WriteLine("Regular.");
                        break;
                    case 6:
                        Console.WriteLine("Suficiente.");
                        break;

                }
                if (cali <= 5 && cali >=0)
                {
                    Console.WriteLine("Insuficiente.");
                }
                Console.WriteLine("\n");

            } while (cali != -1);

        }
    }
}
