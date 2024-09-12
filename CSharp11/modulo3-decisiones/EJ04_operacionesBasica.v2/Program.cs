using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EJ04_operacionesBasica.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            se necesita un programa que realice las 4 operaciones basicas:
            sumar, restar, multiplicar y dividir. a partir de dos numeros,
            la operacion deseada sera elegida por el usuario

             ****************************************
            - mostrar un menu con la operaciones
            - preguntar la operacion que desea realizar
            - pedir los dos numeros para hacer la operacion
            - realizar la operacion correspondiente (if anidados)
            - mostrar el resultado

            ****************************************         
             
             
             */


            // declaro las variables
            decimal numero1;
            decimal numero2;
            decimal resultado = 0.0M; ;
            int opcion;

            // mostramos el menu
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            // pedimos al usuario que escoja una opcion
            Console.Write("Elija una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            // pedimos el primer numero
            Console.Write("Ingrese el primer numero: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            // pedimos el segundo numero
            Console.Write("Ingrese el segundo numero: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            // suma
            if (opcion == 1)
            {
                resultado = numero1 + numero2;
            }
            else
            {
                // resta
                if (opcion == 2)
                {
                    resultado = numero1 - numero2;
                }
                else
                {
                    //multiplicacion
                    if (opcion == 3)
                    {
                        resultado = numero1 * numero2;
                    }
                    else
                    {
                        //division
                        if (opcion == 4)
                        {
                            if (numero2 != 0)
                            {
                                resultado = numero1 / numero2;
                            }
                            else
                            {
                                Console.WriteLine("No es posible dividir por cero");
                            }
                        }
                    }
                }
            }

            // mostramos el resultado
            Console.WriteLine($"El resultado es: {resultado} ");

        }

        

    }
}
