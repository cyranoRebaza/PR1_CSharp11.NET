using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ07_eleccionColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Un usuario desea saber cual es el codigo RGB de uno de los colores primarios que elija

            **********************************
            - pregunto al usuario de cual de los colores RGB le daremos el codigo
            - determinar que color escogio el usuario
            - mostrar el codigo correspondiente

            **********************************
             
             */

            // declarar las variables
            string color;

            // pido el color
            Console.Write("Ingresa el color primario del cual deseas su codigo: ");
            color = Console.ReadLine();

            //comparar
            switch (color)
            {
                case "rojo":
                case "ROJO":
                    Console.WriteLine($"El codigo RGB del {color} es: 255, 0, 0 ");
                    break;

                case "verde":
                    Console.WriteLine($"El codigo RGB del {color} es: 0, 255, 0 ");
                    break;

                case "azul":
                    Console.WriteLine($"El codigo RGB del {color} es: 0, 0, 255 ");
                    break;
                default:
                    Console.WriteLine("Ingrese un color primario");
                    break;
            }

        }
    }
}
