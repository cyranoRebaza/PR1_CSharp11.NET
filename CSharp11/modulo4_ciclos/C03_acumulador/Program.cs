using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_acumulador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             hacer un programa que que diga cual es precio final de 5 productos vendidos
             */

            // declaro las variables
            float acumulador = 0;
            float precio;

            const int CANTIDAD_PRODUCTOS = 5;

            for (int i = 0; i < CANTIDAD_PRODUCTOS; i++)
            {
                // pido el precio del producto
                Console.Write("Ingrese el precio del producto: ");
                precio = Convert.ToSingle(Console.ReadLine());

                // acumulo el precio 
                acumulador = acumulador + precio; // acumulador += precio 

            }

            // muestro el precio final
            Console.WriteLine($"El precio final es: {acumulador}");
        }
    }
}
