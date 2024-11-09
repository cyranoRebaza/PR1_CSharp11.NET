using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_asignaImplicita_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             variable local con asignacion implicita de tipos: 
            
            - el compilador le asigna un tipo de acuerdo a su contenido
            - solo se puede cuando la variable se declara e inicializa al mismo tiempo
            - la declaracion e inicializacion de la variables se realiza en linias distintas
            - var: 
                - usar en variables locales con ambito de metodo
                - en inicializacion en un for y foreach
                - 

            */

            var nombre = "Pepe";     // string
            var calle = "av. maipu"; // string
            var numero = 10;         // entero
            var calificaion = 8.5;   // double
            var letra = 'A';         // char

            Console.WriteLine($"nombre: {nombre} y es tipo {nombre.GetType().Name}");
            Console.WriteLine($"calle: {calle} y es tipo {calle.GetType().Name}");
            Console.WriteLine($"numero: {numero} y es tipo {numero.GetType().Name}");
            Console.WriteLine($"calificacion: {calificaion} y es tipo {calificaion.GetType().Name}");
            Console.WriteLine($"letra: {letra} y es tipo {letra.GetType().Name}");
        }
    }
}
