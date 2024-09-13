using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             hacer
             do
            {
                codigo: el codigo se va ejecutar al menos una vez, sin importar que luego la condicion sea verdarea o falsa

            }
            while(condicion); // si el condicion se cumple --> ejecuta de nuevo si no sale del bucle
             
             */

            // declaramos una variable que se imprimira 10 veces
            int numero = 1;

            do
            {
                Console.WriteLine(numero);
                numero++;
            }
            while (numero <=10);
        }
    }
}
