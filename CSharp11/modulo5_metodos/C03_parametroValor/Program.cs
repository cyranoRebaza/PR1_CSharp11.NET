using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_parametroValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable local a Main(argumento)
            int numAr;

            // asignamos un valor
            numAr = 10;

            // mostramos su valor en la consola
            Console.WriteLine($" antes: {numAr}");

            // Invocamos al metodo y mandamos al argumento
            Prueba(numAr);

            // Despues de que el metodo cambio el valor, volvemos a mostrar al argumento
            Console.WriteLine($" despues: {numAr}");
        }

        // el parametro numPa resive una copia del argumento numAr
        static void Prueba(int numPa)
        {

            // modificamos el valor del parametro
            numPa = 20;
        }

    }
}
