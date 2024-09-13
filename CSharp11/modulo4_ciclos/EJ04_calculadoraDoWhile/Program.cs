using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04_calculadoraDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             hacer un programa que realize la operaciones basicas con las siguientes opciones
            1. suma
            2. resta
            3. multiplicion
            4. division
            muestre el resultado

            *******************************************
            - mostrar el menu
            - hacer que el usuario escoja una opcion 
            - si la opcion no esta dentro de las mostradas, volver a enseñar el menu hasta que el usuario escoja una opcion correcta
            - pedir 2 numeros con los cuales realizar las operaciones
            - sumar, restar, multiplicar o dividir segun sea el caso
            - mostrar el resultado

            *******************************************

             */

            // declaro las variables
            decimal numero1;
            decimal numero2;
            decimal resultado = 0.0m;
            int opcion;

            do
            {
                // mostramos el menu
                Console.WriteLine("1. suma");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. multiplicacion");
                Console.WriteLine("4. division");

                //pedimos una opcion
                Console.Write("Elija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

            }
            while ((opcion < 1) || (opcion > 4) );

            // pedimos los dos numeros
            Console.Write("Ingrese el primer numero: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            // hacemos la operacion segun la opcion escogida
            switch (opcion) 
            { 
                case 1:
                    resultado = numero1 + numero2;
                    break;

                case 2:
                    resultado = numero1 - numero2;
                    break;

                case 3:
                    resultado = numero1 * numero2;
                    break;

                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }
                    break;
            }

            // mostramos el resultado
            Console.WriteLine($"El resultado de la operacion es: {resultado}");


        }
    }
}
