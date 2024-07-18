using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribir un programa que declare variables para almacenar el nombre, 
             * la edad y la estatura de una persona. 
             * Asignar valores a las variables y luego mostrarlos en la consola.
             */
            string Nombre = "Jose Mosquera";
            int Edad = 21;
            double Estatura = 1.50;
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Tu edad es : " + Edad);
            Console.WriteLine("Tu altura:" + Estatura);

            Thread.Sleep(5000);
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }
    }
}
