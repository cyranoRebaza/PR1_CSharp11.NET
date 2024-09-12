using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03_celsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Hacer un programa que transforme de grados centigrados a grados fahrenheit

           ******************************
               - pedir el numero de grados celsius

               - convertimos el numero en  grados fahrenheit

               _ mostrar los °F

           ******************************

            */

            // declaro las variables
            float gradosCelsius;
            float gradosFahrenheit;

            // pedimos los grados celsius
            Console.Write("Ingrese los grados celsius: ");
            gradosCelsius = Convert.ToSingle(Console.ReadLine());

            // convertimos los celsius a fahrenheit
            gradosFahrenheit = (gradosCelsius * 1.8f) + 32;

            // mostramos grados fahrenheit
            Console.WriteLine($"Los {gradosCelsius} °C = {gradosFahrenheit} °F");



        }
    }
}
