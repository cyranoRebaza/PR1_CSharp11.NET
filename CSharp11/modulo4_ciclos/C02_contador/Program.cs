using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // contador
            int contador = 0;

            for (int i = 1; i <= 10; i++)
            {
                contador++;
                Console.WriteLine($"vueltas del ciclo numero: {contador}");
            }

            Console.WriteLine($"El numero de vueltas que dio el ciclo es: {contador}");

            Console.WriteLine("-----------------------------------------");

            int contador2 = 0;
            for (int i = 2; i <= 20; i+=2)
            {
                contador2++;
                Console.WriteLine($"vuelta del ciclo numero {contador2}, el numero es {i}");
            }

            Console.WriteLine($"El numero de vueltas que dio el ciclo es: {contador2}");
        }

    }
}
