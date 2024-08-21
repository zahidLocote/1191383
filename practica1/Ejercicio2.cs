using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Responde los datos correspondientes.");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su profesion: ");
            string prof = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            string edad = Console.ReadLine();
            Console.WriteLine("Ingrese su genero:");
            string gen = Console.ReadLine();

            Console.WriteLine("Nombre: " + nombre + ".  Profesion: " + prof + ".  Edad: " + edad + ".  Genero: " + gen);
            Console.ReadLine();
        }



    }
}
