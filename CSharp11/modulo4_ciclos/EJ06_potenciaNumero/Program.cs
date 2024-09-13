using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ06_potenciaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente

            potencia es la base elevado al exponente
             
             */

            // declaro las variables
            int numero;
            int exponente;

            double resultado = 1;
            double resultadoNegativo;

            // pedimos la base
            Console.Write("Ingrese la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // pedimos el exponente
            Console.Write("Ingrese el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            // validamos el signo del exponente
            if (exponente < 0)
            {
                // convertimos el exponente a positivo
                exponente = exponente * (-1);

                for (int i = 1; i <= exponente; i++)
                {
                    resultado = resultado * numero;
                }

                // asignamos a resultado negativo
                resultadoNegativo = (1 / resultado);

                // mostramos el resultado
                Console.WriteLine($"{numero} ^ {-exponente} = {resultadoNegativo}");

            }
            else
            {
                for (int i = 1; i <= exponente; i++)
                {
                    resultado = resultado * numero;
                }

                
                // mostramos el resultado
                Console.WriteLine($"{numero} ^ {exponente} = {resultado}");

            }
        }
    }
}
