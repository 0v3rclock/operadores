using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio de la esfera: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = CalcularArea(radio);
            double volumen = CalcularVolumen(radio);

            Console.WriteLine($"El área de la esfera es: {area} u²");
            Console.WriteLine($"El volumen de la esfera es: {volumen} u³");

            Console.ReadKey();
        }

        static double CalcularArea(double radio)
        {
            return 4 * Math.PI * Math.Pow(radio, 2);
        }

        static double CalcularVolumen(double radio)
        {
            return (4 / 3) * Math.PI * Math.Pow(radio, 3);
        
        }
    }
}
