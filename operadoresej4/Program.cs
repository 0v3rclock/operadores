using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud de un lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double area = CalcularArea(lado);
            double perimetro = CalcularPerimetro(lado);

            Console.WriteLine($"El área del cuadrado es: {area} m²");
            Console.WriteLine($"El perímetro del cuadrado es: {perimetro} m");

            Console.ReadKey();
        }

        static double CalcularArea(double lado)
        {
            return lado * lado;
        }

        static double CalcularPerimetro(double lado)
        {
            return 4 * lado;
        }
    }
 }
