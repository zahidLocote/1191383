using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); //Aqui se crea un arreglo de enteros en forma de lista
            numeros.Add(10); 
            numeros.Add(20);
            numeros.Add(30); // En las lineas de Add se agregan elementos al arreglo

            Console.WriteLine("Elementos en la posicion 3: " + numeros[2]); // Se imprime el elemento en la posicion 3 pero se corrige el numero 3 a 2
                                                                            // ya que en programacion se empieza a contar desde el 0

            for (int i = 0; i < numeros.Count; i++) // Se crea un ciclo for que recorre todos los elementos de la lista
            {
                if (numeros[i] > 15) // Se crea una condicion que entra si los numeros de la lista son mayores a 15
                {
                    Console.WriteLine("Numero mayor a 15: " + numeros[i]); // Se imprime los numeros corresponientes de la lista
                }
            }
            string listaComoTexto = string.Join(", ", numeros); //Se utiliza el metodo join para convertir la lista en un String separado por comas
            Console.WriteLine("Lista como texto: " + listaComoTexto); //Se imprime el la lista de numeros en forma de string
            Console.ReadLine();
        }
    }
}
