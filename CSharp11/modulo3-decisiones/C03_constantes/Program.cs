using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             CONSTANTES:
                - al declararlas deben ser inicializas con un valor
                - su valor no puede ser modificado
                - se puede leer su valor para realizar operaciones
             */

            // [const] [tipo] [identificador de nombre] = [valor]
            const float iva = 21.0f;

            Console.WriteLine(5 + iva);
        }
    }
}
