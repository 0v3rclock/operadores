using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el dividendo: ");
            double dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Error: no se puede dividir entre cero.");
            }
            else
            {
                double modulo = Modulo(dividendo, divisor);
                Console.WriteLine($"El módulo de {dividendo} entre {divisor} es: {modulo}");
            }

            Console.ReadKey();
        }

        static double Modulo(double a, double b)
        {
            return a % b;
        }
    }
}
