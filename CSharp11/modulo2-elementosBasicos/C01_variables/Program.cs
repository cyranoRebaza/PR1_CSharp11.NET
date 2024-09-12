using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             TIPOS DE VALOR:
                - tipos simples:
                    - entero con signo: sbyte, short, int, long
                    - entero sin signo: byte, ushort, uint, ulong
                    - cararteres unicode: char
                    - punto flotante binario: float, double
                    - punto flotante decimal: decimal
                    - booleano: bool

                - tipos de enumeracion:
                        - tipos definidos por el usuario con el formato enum E {}
                    
                - tipos de estructura:
                            - tipos definidos por el usuario con el formato struc S {}

                 - tipos de valores que aceptan valores NULL:
                                - extensiones de todos los demas tipos de valor con un valor null


            TIPOS DE REFERENCIA:
                - tipos de clase:
                    - clase base definida de todos los demas tipos: object
                    - cadenas unicode: string
                    - tipos definidos por el usuario con el formato class C {}

                - tipos de interfaz:                        
                        - tipos definidos por el usuario con el formato interfaz I {}

                - tipos de matriz:                        
                            - unidimensional y multidimensional: int[] y int[,]

                - tipos delegados:                        
                                - tipos definidos por el usuario con el formato delegate int D()

             */


            
            // declarando tres variables de tipo entero
            int numeroLibros = 300; 
            int librosNinios = 100; // asigno el valor de 100 a la variable
            int librosMatematicas = 200;

            //declaro e inicializo una variable de tipo double
            double promedioFinal = 9.5; // literal sin sufijo o  colocando una d o D

            //declaro e inicializo una variable de tipo float
            float promedioNotas = 8.5f; // conversion EXPLICITA  colocando una f o F

            //declaro e inicializo una variable de tipo decimal
            decimal promedioExamenes = 8.5M; // conversion EXPLICITA  colocando una m o M

            //declaro e inicializo una variable de tipo char
            char salon = 'A'; 

            //declaro e inicializo una variable de tipo string
            string saludo = "S";  // string es un tipo de dato de referencia pero tambien es una clase String

            //declaro e inicializo una variable de tipo bool
            bool bandera = false; // puede ser false o true

            

            // mostrar el valor de las variables en la consola
            Console.WriteLine($"numero libros: {numeroLibros}");


        }
    }
}
