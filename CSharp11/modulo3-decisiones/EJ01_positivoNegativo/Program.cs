using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01_positivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 pedir un numero al usuario y determinar si este es positivo o negativo


                ****************************************
                - pedir el numero
                - determinar si el numero es positivo
                - mostramos el mensaje si es el caso
                - determinar si el numero es negativo
                - mostrar el mensaje si es el caso
             
             */

            // declaro las variables
            double numero;

            // pedimos el numero
            Console.Write("Ingrese numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            // usamos un condicional if para saber si el numero es mayor a cero
            if (numero > 0 )
            {
                // se ejecuta en caso de que la expresion se  evalue como true
                Console.WriteLine("El numero es positivo");
            }

            // usamos un condicional if para saber si el numero es menor a cero
            if (numero < 0) 
            {
                // se ejecuta en caso de que la expresion se evalue como true
                Console.WriteLine("El numero es negativo");
            }




        }
    }
}
