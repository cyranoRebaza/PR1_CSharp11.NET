using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_tipoDato_tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // guardar los datos de una persona
            string nombre = "Luis";
            int edad = 50;
            long numero = 55834899;
            int dirPostal = 214455;

            // TUPLA: (tipo) Identificador = (valor);
            (string, int, long, int) persona1 = ("Luis", 50, 55834899, 214455);

            // si usamos var --> el compilador infiere el tipo de dato
            var persona2 = ("Juan", 50, 55834899, 214455); // campos o item

            Console.WriteLine(persona2);
            Console.WriteLine(persona2.Item1);

            // podemos dar un nombre a cada campo para poder identificarlos
            var persona3 = (nombre: "Pablo", edad: 30, numero: 55834899, dirPostal: 214455);

            Console.WriteLine(persona3.nombre);

            // persona4 es una variable de tipo tupla que contiene 4 campos
            (string nombre, int edad, long numero, int dirPostal) persona4 = ( "Lucho",  30, 55834899, 214455);

            Console.WriteLine(persona4.nombre);


        }
    }
}
