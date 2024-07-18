using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de variables con nombres no descriptivos
            int x = 25;
            int y = 30;
            int z = x + y;

            Console.WriteLine("El resultado de la suma es: " + z);

            // Ejemplo de variables con nombres descriptivos
            int edadPersona1 = 25;
            int edadPersona2 = 30;
            int sumaEdades = edadPersona1 + edadPersona2;

            Console.WriteLine("La suma de las edades es: " + sumaEdades);

            Console.WriteLine("¿Cuál es el resultado más fácil de entender?");

            Console.ReadKey();
        }
    }
}
