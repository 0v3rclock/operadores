using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            CompararNumeros(num1, num2);

            Console.ReadKey();
        }

        static void CompararNumeros(double a, double b)
        {
            if (a == b)
            {
                Console.WriteLine("Los números son iguales.");
            }
            else if (a > b)
            {
                Console.WriteLine("El primer número es mayor que el segundo.");
            }
            else
            {
                Console.WriteLine("El primer número es menor que el segundo.");
            }
        }
    }
}
