using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular salario.");
            Console.WriteLine("Ingrese las horas trabajadas:");
            string sal = Console.ReadLine();
            int SAL = int.Parse(sal);

            if(SAL <= 40)
            {
                SAL = SAL * 50;
            }else 
            {
                int extra = SAL - 40;
                SAL = (extra * 100) + (40 * 50);
            }

            Console.WriteLine("Salario semanal: " + SAL);
            Console.ReadLine();
        }
    }
}
