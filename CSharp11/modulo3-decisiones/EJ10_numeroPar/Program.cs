using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10_numeroPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que le pida al usuario un numero y decirle si es par o impar

            *************************************
            - pido un numero
            _ pregunto si el numero es divisible por 2 --> resto igual a cero
            _ si es verdadero, muestro es par
            - si es falso, muestro es impar

            *************************************
             
             */

            // declaro las variables
            int numero;

            // pido el numero
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // condicional
            if (numero % 2 == 0)
            {
                Console.WriteLine($" el numero {numero} es PAR");
            }
            else
            {
                Console.WriteLine($" el numero {numero} es IMPAR");
            }
        }
    }
}
