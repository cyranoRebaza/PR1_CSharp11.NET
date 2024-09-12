using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ06_propulsores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             eres el encargado de una base control aereo donde se encuentran aviones Jets,nuestra funcion consiste en permitir despegar o no
            a los pilotos dependiendo del estado en el que se encuentres los propulsores de los Jets

            _ funcionan por medio de dos propulsores un izquierdo y uno derecho y un tanque de gasolina

            -riquisitos de despegue
                - si los  dos propulsores funcionan y el tanque de combustible tiene al menos el 75 por ciento de su capacidad 
                - si uno de los propulsores funcionan y el tanque de combustible tiene el 100 por ciento de su capacidad

            - mostrar un mensaje si puede o no despegar


            *******************************************
            - pedir el nivel de energia
            - pedir el estado del propulsor derecho
            - pedir el estado del propulsor izquierdo

            - pregunto estado del propulsor derecho e izquierdo, si esta en buen estatado y la energia mayor igual 75 puede despegar o solo
            un propulsor esta en buen estado la energia tiene que estar al 100% para despegar
             
             */

            // declaro las variables
            float energia;
            bool propulsorIzquierdo;
            bool propulsorDerecho;

            // pido la energia
            Console.Write("Ingrese el nivel de energia: ");
            energia = Convert.ToSingle(Console.ReadLine());

            //pregunto por el estado propulsor derecho
            Console.Write("¿El propulsor derecho esta en buen estado? (true/false): ");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine());

            //pregunto por el estado propulsor izquierdo
            Console.Write("¿El propulsor izquierdo esta en buen estado? (true/false): ");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());

            // condicional
            if (((propulsorDerecho&&propulsorIzquierdo) && energia >= 75 )  || ((propulsorDerecho || propulsorIzquierdo) && energia == 100))
            {
                Console.WriteLine("Puede despegar");
            }
            else
            {
                Console.WriteLine("Lo siento, no es seguro despegar");
            }
        }
    }
}
