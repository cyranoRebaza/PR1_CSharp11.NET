using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_cicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simulando un for (int numero =1, numero <= 10, numero++)
            
            int numero = 1;

            // mientras numero sea menor a 10 --> se ejecuta las intrucciones
            while (numero <= 10)
            {
                Console.WriteLine($"vuelta n°: {numero}");

                numero++; // modifica el valor de numero para evitar el bucle infinito
            }
        }
    }
}
