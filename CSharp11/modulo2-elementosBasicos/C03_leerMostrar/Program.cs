using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_leerMostrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaramos una variable de tipo string
            string nombre;

            // ingrese su nombre
            Console.Write("cual es tu nombre: ");
            nombre = Console.ReadLine();

            // saludamos al usuario
            Console.WriteLine($"hola {nombre}, es un placer");

            Console.WriteLine("*************************************");
            Console.WriteLine("*** convertir una cadena en tipo numerico***");

            string entrada;
            int numero1 = 5;
            int numero2;
            int resultado;

            //preguntamos al usuario el numero
            Console.Write("Ingrese un numero: ");

            // se asigna a la variable de tipo string
            entrada = Console.ReadLine();

            // convertimos la cadena a tipo int
            numero2 = Convert.ToInt32(entrada);  // devuelve un valor de cero en caso de que haya un error (aqui cambia el metodo)
            numero2 = Int32.Parse(entrada);  // genera una excepcion deteniendo la ejecucion (aqui cambia la estructura)


            // calculo la suma
            resultado = numero1 + numero2;

            // mostramos el resultado
            Console.WriteLine($"El resultado de la suma es: {resultado}");






        }
    }
}
