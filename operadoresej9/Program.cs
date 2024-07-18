using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar variable constante
            const int CONSTANTE_PI = 3;

            // Declarar variable normal
            int variableNormal = 5;

            // Asignar valor a la variable normal
            variableNormal = 10;

            // Mostrar variables en la consola
            Console.WriteLine("Valor de la constante: " + CONSTANTE_PI);
            Console.WriteLine("Valor de la variable normal: " + variableNormal);

            Console.ReadKey();
        }
    }
}
