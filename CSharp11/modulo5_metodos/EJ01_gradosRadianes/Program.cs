using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01_gradosRadianes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             crear un metodo para transformar de grados a radianes

            *******************
            - Pedir el numero de grados
            _ Enviar los grados al metodo
            - convertir los grados a radianes, mediante la formula --> radianes = grados * pi /  180
            - Devolver la conversion
            - mostrar el resultado

            
             */

            // declaracion varibles
            double gradosAr;
            
            double radianes;

            // ingrese los grados
            Console.Write("Ingrese los grados: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            // Invocamos al metodo GradosRadianes() y le paso el argumento gradosAr
            radianes = GradosRadianes(gradosAr);

            // muestro la conversion
            Console.WriteLine($"{gradosAr}° =  {radianes} radianes");



        }

        static double GradosRadianes(double gradosPa)
        {
            const double PI = 3.1416;

            double radian = gradosPa * PI / 180;  // radian = (gradosPa * Math.PI) / 180;
            return radian;
        }
    }
}
