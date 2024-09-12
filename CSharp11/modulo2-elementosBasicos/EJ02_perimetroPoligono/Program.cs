using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02_perimetroPoligono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que calcule el perimetro de cualquier poligono regular

            ******************************
                - pedir el numero de lados
                - pedir la medida de alguno de los lados

                - calcular el perimetro multiplicando la medida por el lado

                _ mostrar el perimetro

            ******************************

             */

            // declaro las variables
            int numeroLados;
            double medidaLado;
            double perimetro;

            // pedimos el numero de lados
            Console.Write("Ingrese el numero de lados: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());

            // pedimos la medida de uno de los lados
            Console.Write("Ingrese la medida de alguno de los lados: ");
            medidaLado = Convert.ToInt32(Console.ReadLine());

            // calculamos el perimetro
            perimetro = numeroLados * medidaLado;

            // mostramos el resultado
            Console.WriteLine($"El perimetro del poligono regular es: {perimetro} ");

        }
    }
}
