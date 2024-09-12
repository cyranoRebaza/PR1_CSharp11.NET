using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_introducion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // operadores de igualdad (==)

            int a = 30;
            int b = 20;
            Console.WriteLine(5 == 5); // true
            Console.WriteLine(a == b); // false

            // operador de desigualdad (!=)
            Console.WriteLine(6 != 5); // true
            Console.WriteLine(5 != 5); // false

            // operador de comparacion 
            Console.WriteLine(8.0 < 3.5); // false
            Console.WriteLine(-30.0 < 3.5); // true

            Console.WriteLine(50 > 20); // true
            Console.WriteLine(50 > 60); // false

            Console.WriteLine(8.0 <= 8.0); // true

            Console.WriteLine(8.0 >= 6.0); // true

        }
    }
}
