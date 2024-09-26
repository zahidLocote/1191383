using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5._1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            String texto = "El doctor le dice al paciente: respire profundo que lo voy a auscultar. El paciente le responde: doctor, ¿de quién me va a ocultar si no le debo a nadie?";
            Console.WriteLine(texto + "\n");

            Console.WriteLine( texto.Replace(" ","") + "\n");

            char[] alr = texto.ToCharArray();
            for (int x=alr.Length-1;x >= 0 ;x--)
            {
                Console.Write(alr[x]);
            }
            Console.ReadLine();
        }
    }
}
