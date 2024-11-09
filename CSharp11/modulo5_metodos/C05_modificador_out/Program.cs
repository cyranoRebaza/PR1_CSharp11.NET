using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_modificador_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            - como modificador de parametros:
                - pasar un argumento a un metodo mediante una referencia
            - en declaraciones de parametros de tipo generico:
                - para interfas y delegados, que especifica que un parametro de tipo 
                es covariante
            *****************************
            DIFERENCIA CON PASE POR REFERENCIA:
                - No es necesario darle un valor inicial al argumento par enviarlo
                - usa para devolver multiples valores sin usar return
               
             
             */

            // variable local a Main(argumento)
            int numAr;
            string saludoAr;
            int numPrimoAr;

            // asignamos un valor
            //numAr = 10; --> eliminamos y en ref cambio por out


            // Invocamos al metodo y mandamos los argumentos
            Prueba(out numAr, out saludoAr, out numPrimoAr);

            // Despues de que el metodo cambio el valor, volvemos y mostramos los argumentos
            Console.WriteLine($" despues: {numAr}");
            Console.WriteLine($" despues: {saludoAr}");
            Console.WriteLine($" despues: {numPrimoAr}");
        }

        // el parametro numPa resive la ubicaicion del argumento numAr
        static void Prueba(out int numPa, out string saludoPa, out int numPrimoPa)
        {

            // modificamos el valor de los parametros
            numPa = 20;
            saludoPa = "hola a todos";
            numPrimoPa = 7;
        }
    }
}

