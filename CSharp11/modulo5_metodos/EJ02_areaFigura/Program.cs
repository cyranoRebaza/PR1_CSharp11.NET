using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02_areaFigura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una aplicacion que calcule el area de un circulo, cuadrado o triangulo. Le
            preguntamos al usuario a que figura le quiere calcular el area y dependiendo del caso
            ejecutara un de los tres metodos

            ************************
            - AREA CIRCULO = PI * r2

            - AREA CUADRADO = lado * lado

            - AREA TRIANGULO = (base * altura) / 2
             
             */


            // declaracion variables
            double radioAr;
            double baseAr;
            double alturaAr;
            double ladoAr;
            double area;

            int opcion;

            // mostramos las opciones
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");

            // preguntamos
            Console.Write("Elige una opcion para calcular el area: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion) 
            {
                case 1:
                    // pedimos el valor de radio
                    Console.Write("Ingresa el valor del radio del circulo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());

                    // invoco al metodo Circulo()
                    area = Circulo(radioAr);

                    // mostramos el resultado
                    Console.WriteLine($"El area es: {area}");
                    break;

                case 2:
                    // pedimos los valores  de base y altura
                    Console.Write("Ingresa el valor de la base del triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingresa el valor de la altura del triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());

                    // invoco al metodo Triangulo()
                    area = Triangulo(baseAr, alturaAr);

                    // mostramos el resultado
                    Console.WriteLine($"El area es: {area}");
                    break;

                case 3:
                    // pedimos el valor de lado
                    Console.Write("Ingresa el valor de uno de los lados del cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());

                    // invoco al metodo Cuadrado()
                    area = Circulo(ladoAr);

                    // mostramos el resultado
                    Console.WriteLine($"El area es: {area}");
                    break;
            
            
            
            }





        }

        // metodo que calcula el area de un circulo
        static double Circulo(double radioPa)
        {
            double area;
      
            
            // calculo el area
            area = Math.PI * (radioPa * radioPa);

            // regresamos el valor de area
            return area;
        }
                
        // metodo que calcula el area de un triangulo
        static double Triangulo(double basePa, double alturaPa)
        {
            double area;


            // calculo el area
            area = (basePa * alturaPa) / 2;

            // regresamos el valor de area
            return area;
        }

        // metodo que calcula el area de un cuadrado
        static double Cuadrado(double ladoPa)
        {
            double area;


            // calculo el area
            area = ladoPa * ladoPa;

            // regresamos el valor de area
            return area;
        }
    }
}
