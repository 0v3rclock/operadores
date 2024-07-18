using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double suma = Suma(num1, num2);
            double resta = Resta(num1, num2);
            double multiplicacion = Multiplicacion(num1, num2);
            double division = Division(num1, num2);

            Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
            Console.WriteLine($"La resta de {num1} y {num2} es: {resta}");
            Console.WriteLine($"La multiplicación de {num1} y {num2} es: {multiplicacion}");

            if (num2 != 0)
            {
                Console.WriteLine($"La división de {num1} entre {num2} es: {division}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }

            Console.ReadKey();
        }

        static double Suma(double a, double b)
        {
            return a + b;
        }

        static double Resta(double a, double b)
        {
            return a - b;
        }

        static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
