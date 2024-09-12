using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ09_numeroMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que le pida al usuario un numero del 1 al 12 y muestre el nombre del mes que corresponde a ese
            en el calendario

            ***********************************
            - pedimos el numero de mes (1 al 12)
            - comparamos cada caso y mostramos el nombre del mes
             
             */

            // declaracion de variable
            int mes;

            // pido el numero
            Console.Write("Ingrese el numero del que quiere conocer el mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;

                case 2:
                    Console.WriteLine("Febrero");
                    break;

                case 3:
                    Console.WriteLine("Marzo");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Mayo");
                    break;

                case 6:
                    Console.WriteLine("Junio");
                    break;

                case 7:
                    Console.WriteLine("Julio");
                    break;

                case 8:
                    Console.WriteLine("Agosto");
                    break;

                case 9:
                    Console.WriteLine("Septiembre");
                    break;

                case 10:
                    Console.WriteLine("Octubre");
                    break;

                case 11:
                    Console.WriteLine("Noviembre");
                    break;

                case 12:
                    Console.WriteLine("Diciembre");
                    break;

                default:
                    Console.WriteLine("El numero ingresado no corresponde a un mes del calendario");
                    break;
            }
        }
    }
}
