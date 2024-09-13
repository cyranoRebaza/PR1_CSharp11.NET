using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace C05_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             calcular el promedio de notas de tres alumnos

            **************************************
            - pido la nota 1
            - pido la nota 2
            - pido la nota 3
            - calculo el promedio
            - muestro el promedio

            **************************************
            
                         

            // declaro las variables
            double nota1;
            double nota2;
            double nota3;
            double promedio;

            // pido nota 1
            Console.Write("Ingrese la nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            // pido nota 2
            Console.Write("Ingrese la nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            // pido nota 3
            Console.Write("Ingrese la nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            //calculo el promedio
            promedio = (nota1 + nota2 + nota3) / 3;

            // muestro el promedio
            Console.WriteLine($"El promedio de notas es: {promedio}");

            ****************************************
            for(variable control, condicion, iterador)
            {
            
            }
            
            variable control: se declara e inicializa generalmente en cero, se ejecuta una sola vez 
            condicion: miestras se verdadera se ejecutara el codigo dentro del for
            iterador: incrementa o decrementa (puede ser de a dos en dos) en uno la condicion hasta que este de falso, termina el ciclo


            */

            // declaro la variable
            float nota;
            float promedio;

            float acumuladorNotas = 0;
            int contadorNotas = 0;

            int numeroAlumnos;

            // pido la cantidad de alumnos
            Console.Write("Ingrese el numero de alumnos: ");
            numeroAlumnos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numeroAlumnos; i++)
            {
                // pido nota
                Console.Write("Ingrese nota: ");
                nota = Convert.ToSingle(Console.ReadLine());

                //acumulo las notas
                acumuladorNotas = acumuladorNotas + nota;  // acumuladorNotas += nota

                // contamos la cantidad de notas
                contadorNotas = contadorNotas +1; // contadorNotas++
                
            }

            //calculamos el promedio
            promedio = acumuladorNotas / contadorNotas;

            //mostramos el promedio
            Console.WriteLine($"el promedio es: {promedio}");

        }
    }
}
