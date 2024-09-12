using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resetaCocina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Console: 
                - es una clase que pertenece al espacio de nombre system

            WhiteLine:
                - metodo que pertenece a la clase console

            **************************
            ERROR LOGICOS:
                - dificil de corregir- compila pero el resultado es el no esperado

            ERRORES SINTAXIS:
                _ instruccion mal escrita que no va compilar
                - https:/docs.microsoft.com/es-es/dotnet/csharp/misc/cs1010
             */

            // mostrar mensajes en pantalla

            Console.Write("no da salto de linea"); 
            
            Console.WriteLine("1. precalentar el horno");
            Console.WriteLine("2. Mesclar harina y manteca");
            Console.WriteLine("3. Agregar azucar y huevo");
            Console.WriteLine("4. Amazar la mezcla");
            Console.WriteLine("5. Darles forma y colocar en molde");
            Console.WriteLine("6. Hornear durante 10 minutos");

        }
    }
}
