using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C04_incrementoDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INCREMENTO COMO SUFIJO
            Console.WriteLine("**** INCREMENTO COMO SUFIJO ****");

            int i = 10;

            Console.WriteLine($"valor inicial de de i: {i}"); // mostrar i = 10

            // mostramos luego incrementa
            Console.WriteLine($"valor con incremento i++: {i++}"); // mostrar i = 10

            // no incrementa solo imprime
            Console.WriteLine($"valor  de i: {i}"); // mostrar i = 11

            // INCREMENTO COMO PREFIJO
            Console.WriteLine("**** INCREMENTO COMO PREFIJO ****");

            int j = 20;

            Console.WriteLine($"valor inicial de de i: {j}"); // mostrar j = 20

            // incrementa luego muestra 
            Console.WriteLine($"valor con incremento ++i: {++j}"); // mostrar j = 21

            // no incrementa solo imprime
            Console.WriteLine($"valor  de i: {j}"); // mostrar j = 21

            Console.WriteLine("**** DECREMENTO COMO PREFIJO ****");

            int n = 30;

            Console.WriteLine($"valor inicial de de n: {n}"); // mostrar n = 30

            // mostramos luego decrementa
            Console.WriteLine($"valor con decremento n--: {n--}"); // mostrar n = 30

            // no decrementa solo imprime
            Console.WriteLine($"valor  de n: {n}"); // mostrar n = 29

            // INCREMENTO COMO PREFIJO
            Console.WriteLine("**** INCREMENTO COMO PREFIJO ****");

            int m = 40;

            Console.WriteLine($"valor inicial de de m: {m}"); // mostrar m = 40

            // decrementa luego muestra 
            Console.WriteLine($"valor con incremento --i: {--m}"); // mostrar m = 39

            // no decrementa solo imprime
            Console.WriteLine($"valor  de i: {m}"); // mostrar m = 39
        }
    }
}
