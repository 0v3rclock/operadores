using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("1. Convertir Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir Fahrenheit a Celsius");
            Console.Write("Seleccione una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese la temperatura en Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = CelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius}°C es igual a {fahrenheit}°F");
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese la temperatura en Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F es igual a {celsius}°C");
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }

            Console.ReadKey();
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    }
