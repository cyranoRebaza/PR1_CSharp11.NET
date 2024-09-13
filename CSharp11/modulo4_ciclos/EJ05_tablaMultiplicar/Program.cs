using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05_tablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             TABLA DE MULTIPLICAR DEL 10
             */
            
            // declaro las variables
            int resultado;

            // ciclo externo
            for (int i = 1; i <=12; i++)
            {
                Console.WriteLine($"Tabla de multiplicar del {i}");

                for (int j = 1; j <= 12; j++)
                {
                    resultado = i * j;

                    Console.WriteLine($"{i} x {j} = {resultado}");
                }
            }

            Console.ReadKey();
        }
    }
}
