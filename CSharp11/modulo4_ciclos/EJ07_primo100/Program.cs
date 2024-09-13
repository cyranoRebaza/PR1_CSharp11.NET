using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ07_primo100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que calcule los numeros primos que existen entre el 1 y el 100
             */

            
            // declaro la variables          
            int numeroDivisores = 0;

            // ciclo externo, se encarga de recorrer los numeros del 2 al 100
            for (int i = 2; i <= 100; i++)
            {

                // ciclo interno, se encarga de verificar en numero de divisores
                for (int j = 1; j <= i; j++) 
                {
                    if (i % j == 0)
                    {
                        numeroDivisores = numeroDivisores + 1; // numeroDivisiores++
                    }
                }

                // verificamos si el numero de divisores sea igual a 2
                if (numeroDivisores <= 2)
                {
                    Console.WriteLine(i);
                }

                // reiniciamos el conteo del numero de divisores
                numeroDivisores = 0;


            }

            Console.ReadKey();
        }
    }
}
