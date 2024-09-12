using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01_areaPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Hacer un programa que haga el calculo del area y perimetro de un rectangulo

                ******************************
                - pedir la altura del rectangulo
                - pedir el ancho del rectangulo

                - calcular area multiplicando alto por ancho
                - calcular el perimetro sumando los cuatro lados

                - mostrar el area
                - mostrar el perimetro

                ******************************
             */


            // declaro las variables
            double altura;
            double ancho;
            double area;
            double perimetro;

            // pido la altura y convertimos a tipo double
            Console.Write("Ingrese la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // pido el ancho y convertimos a tipo double
            Console.Write("Ingrese la ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());


            // calculo area y perimetro
            area = altura * ancho;

            perimetro = 2 * (altura + ancho);

            // muestro el area y perimetro
            Console.WriteLine($"El area es: {area}");
            Console.WriteLine($"El perimetro: {perimetro}");
        }
    }
}
