using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"suma: {5 + 3}");
            Console.WriteLine($"resta: {5 - 3}");
            Console.WriteLine($"multiplicacion: {5 * 3}");

            Console.WriteLine($"division enteros: {5 / 2}");
            Console.WriteLine($"division flotante: {5.0 / 2}");
            Console.WriteLine($"division float: {16.8f / 4.1f}");
            Console.WriteLine($"division double: {16.8 / 4.1}");
            Console.WriteLine($"division decimal: {16.8m / 4.1m}");

            Console.WriteLine($"resto: {5 % 2}");

        }
    }
}
