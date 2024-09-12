using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02_divisionCero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que haga la division de dos numero

            ****************************************
            - pedir el dividendo
            - pedir el divisor
            - preguntamos si el divisor es  distinto de cero
            - si es verdadero calculamos y mostramos resultado
            - si es falso mostramos mensaje no se puede dividir por cero

            ****************************************             

             */

            // declaro las variables
            double dividendo;
            double divisor;
            double resultado;

            // pido el dividendo
            Console.Write("Ingrese el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            // pido el divisor
            Console.Write("Ingrese el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            // pregunto
            if (divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine($"{dividendo} / {divisor} = {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }

        }
    }
}
