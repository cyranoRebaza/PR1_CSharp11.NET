using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_operadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             OPERADORES LOGICOS BOOLEANOS
            - negacion logica (!)
            - AND logico (&)
            - OR logico (|)
            - OR exclusivo logico (^)

            - AND logico condicional (&&)
            - OR logico condicional (||)

             */

            Console.WriteLine("**** negacion logica ****");
            // negacion logica
            bool bateria;

            Console.Write("¿hay bateria? (escriba true / false): ");
            bateria = Convert.ToBoolean(Console.ReadLine());

            // pregunto: si bateria no es igual a true - si no hay bateria carge el celular
            if (!(bateria == true))  // true == true --> verdadero --> !verdadero --> falso
            {
                Console.WriteLine("conecta el celular");
            }
            else
            {
                Console.WriteLine("No es necesario conectar el celular");
            }

            Console.WriteLine("\n**** AND logica condicional ****\n");
            // AND CONDICIONAL LOGICO (si y solo si ambos son verdaderos es verdadera el resto es falso)

            int edad;
            bool licencia;

            Console.Write("¿que edad tienes?: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Tienes licencia para conducir?: (escribe true o false) ");
            licencia = Convert.ToBoolean(Console.ReadLine());

            if ((edad >= 18) && licencia == true)
            {
                Console.WriteLine("puedes conducir");
            }
            else
            {
                Console.WriteLine("Lo siento, no puedes conducir");
            }


            Console.WriteLine("\n**** OR logica condicional ****\n");
            // OR CONDICIONAL LOGICO (si y solo si ambos son FALSOS es FALSO el resto es VERDADERO)

            float calificacionSecundario;
            float calificacionExamen;

            Console.Write("¿con que promedio concluiste tu secundario?: ");
            calificacionSecundario = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresa la calificacion que obtuviste en el examen de ingreso: ");
            calificacionExamen = Convert.ToSingle(Console.ReadLine());

            // condicion
            if ((calificacionSecundario >= 7) || (calificacionExamen >= 6.5))
            {
                Console.WriteLine("¡Felicidades, tienes una beca!");
            }
            else
            {
                Console.WriteLine("Lo siento, la beca no fue proporcionada");
            }

        }
    }
}
