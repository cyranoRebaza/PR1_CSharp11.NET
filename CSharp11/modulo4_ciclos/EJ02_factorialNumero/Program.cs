using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02_factorialNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Calcular el factorial de un numero cualquiera

            *********************************
            - factorial: es el producto de todos los numeros que anteceden a n --> 3! = 3*2*1 --> 3!= 6
             
             */

            // declaro las variables
            int numero;
            int factorial = 1;

            // pido el numero 
            Console.Write("Ingrese el numero para calcular su factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i >= 1; i--)
            {
                factorial = factorial * i; // factorial *= i
            }

            // mostramos el factorial
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}
