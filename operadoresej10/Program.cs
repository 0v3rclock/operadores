using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar variable
            int edad = 25;

            // Mostrar valor inicial de la variable
            Console.WriteLine("Valor inicial de la variable: " + edad);

            // Modificar valor de la variable
            edad = 30;

            // Mostrar valor modificado de la variable
            Console.WriteLine("Valor modificado de la variable: " + edad);

            // Modificar valor de la variable nuevamente
            edad = edad + 5;

            // Mostrar valor modificado de la variable nuevamente
            Console.WriteLine("Valor modificado de la variable nuevamente: " + edad);

            Console.ReadKey();
        }
    }
}
