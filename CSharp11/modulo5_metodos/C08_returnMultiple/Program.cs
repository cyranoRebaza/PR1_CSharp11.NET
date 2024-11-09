using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_returnMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int opcion;
            decimal resultado; // almacena el valor devuelto de Restar();

            decimal num1Ar, num2Ar; // argumentos para enciar una copia de su valor a los metodos

            // declaramos una tupla
            (decimal num1, decimal num2, decimal result) numeros;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. division");

                // pedimos una opcion
                Console.Write("Elige una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            // hacer la operacion segun la opcion escogida
            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;

                case 2:
                    numeros = Restar(); // asignamos a la tupla "numeros" los 3 valor devuelto por "return"

                    Console.WriteLine($"El resultado de la resta: {numeros.num1} - {numeros.num2} = {numeros.result}"); // mostramos el resultado
                    break;

                case 3:
                    // pedimos el valor de ambos numeros
                    num1Ar = IngresarNumero("Ingrese el primer numero: ");
                    num2Ar = IngresarNumero("Ingrese el segundo numero: ");

                    Multiplicar(num1Ar, num2Ar);
                    break;

                case 4:
                    // pedimos el valor de ambos numeros
                    Console.Write("Ingrese el primer numero: ");
                    num1Ar = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    num2Ar = Convert.ToDecimal(Console.ReadLine());

                    resultado = Dividir(num1Ar, num2Ar);

                    Console.WriteLine($"El resultado de la resta es: {resultado}"); // mostramos el resultado
                    break;

            }

            Console.ReadKey();
        }

        // metodo1. sin parametros ni tipo
        static void Sumar()
        {
            // variables del metodo Sumar()
            decimal num1, num2, suma;

            // pedimos el valor de ambos numeros
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //operacion
            suma = num1 + num2;

            // mostrar el resultado
            Console.WriteLine($"{num1} + {num2} = {suma}");

        }

        // metodo2. sin parametros que devuelven un tipo
        static (decimal, decimal, decimal) Restar()
        {
            // variables del metodo Restar()
            decimal num1, num2, resta;

            // pedimos el valor de ambos numeros
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // proceso
            resta = num1 - num2;

            // devolvemos multiples tipos al programa principal
            return (num1, num2, resta);

        }

        // metodo3. con parametros sin tipo
        static void Multiplicar(decimal num1Pa, decimal num2Pa)
        {
            // variables
            decimal resultado;

            // multiplicacion con los valores que mandaron los argumentos
            resultado = num1Pa * num2Pa;

            // mostrar el resultado
            Console.WriteLine($"{num1Pa} * {num2Pa} = {resultado}");
        }

        // metodo4. con parametros que devuelven un tipo
        static decimal Dividir(decimal num1Pa, decimal num2Pa)
        {
            // variables
            decimal resultado = 0;

            if (num2Pa != 0)
            {
                // dividimos con los valores que mandaron los argumentos
                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine("No es posible dividir por cero");
            }


            // devolvemos 
            return resultado;
        }

        // metodo5. con parametro string que devuelven un tipo --> uso case 3:
        static decimal IngresarNumero(string peticion)
        {
            // variable local al metodo
            decimal numero;

            // pedimos el valor segun corresponda
            Console.Write(peticion);

            // convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            return numero;
        }
    }
}
