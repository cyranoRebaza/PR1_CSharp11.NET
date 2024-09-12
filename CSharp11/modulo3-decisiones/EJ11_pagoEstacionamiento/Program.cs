using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ11_pagoEstacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento
            de un centro comercial. 
            - los primeros 60 minutos pagara 800
            - las primeras dos horas pagara 1200
            - de dos horas en adelante pagara 1500

            **************************************
            - pido los minutos que permanece en el estacionamiento
            - pregunto si estuvo 120 minutos o mas --> paga 1500
            - si estuvo  mas de 60 minutos --> paga 1200
            _ si estubo menos de 60 minutos --> paga 800

            ***************************************
            

             */

            // declaro la variable
            float minutos;

            // pido el tiempo que estuvo en el estacionamiento
            Console.Write("Ingrese el tiempo que estuvo en el estacionamiento (en minutos): ");
            minutos = Convert.ToSingle(Console.ReadLine());

            // pregunto
            if (minutos >= 120)
            {
                Console.WriteLine("paga 1500");
            }
            else if (minutos > 60)
            {
                Console.WriteLine("paga 1200");
            }
            else
            {
                Console.WriteLine("paga 800");
            }
        }
    }
}
