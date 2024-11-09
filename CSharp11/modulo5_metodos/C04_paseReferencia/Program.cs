using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_paseReferencia
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
            Prueba(ref numAr);

            // Despues de que el metodo cambio el valor, volvemos a mostrar al argumento
            Console.WriteLine($" despues: {numAr}");
        }

        // el parametro numPa resive la ubicaicion del argumento numAr
        static void Prueba(ref int numPa)
        {

            // modificamos el valor del parametro
            numPa = 20;
        }
    }
}
