using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03_claveCorrecta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que le pida al usuario su contraseña y posteriormente le pedira que lo corrobore,
            si las contraseñas coinciden mandara un mensaje diciendo que ha sido correcto,en caso contrario las 
            contraseñas no coinciden


             */

            // declarar las variables
            string clave1;
            string clave2 ="";

            // pido la clave 1
            Console.Write("Ingrese su clave: ");
            clave1 = Console.ReadLine();

            // mientras las claves sean distintas --> pedira que que confirme la clave
            while (clave1 != clave2)
            {
                Console.Write("confirme su clave: ");
                clave2 = Console.ReadLine();
            }

            // mostramos mensaje la clave es correcta
            Console.WriteLine("La clave es correcta");


        }
    }
}
