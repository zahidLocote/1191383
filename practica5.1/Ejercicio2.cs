using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5._1
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nom = Console.ReadLine();
            Console.WriteLine("La longitud de su nombre es: " + nom.Length);

            Console.Write("Indique el caracter a buscar: ");
            string car = Console.ReadLine();


            if (nom.IndexOf(car) != -1)
            {
                Console.WriteLine("El caracter se encuentra en la posicion: " + nom.IndexOf(car) + "\n");
            }
            else
                Console.WriteLine("El caracter NO se encuentra.");

            Console.WriteLine("Minusculas: " + nom.ToLower());
            Console.WriteLine("Mayusculas: " + nom.ToUpper() + "\n");

            Console.Write("Ingrese un caracter para borrar de la cadena: ");
            string car2 = Console.ReadLine();
            Console.WriteLine("Nombre sin caracter especificado: " + nom.Replace(car2,""));

            Console.WriteLine("Un pedazo de la cadena: " + nom.Substring(2,5) + "\n");

            Console.WriteLine("Izquierda a derecha: " + nom.Substring(0,4));
            Console.WriteLine("Derecha a izquierda: " + nom.Substring(nom.Length - 5,5));


            Console.ReadLine();
        }
    }
}
