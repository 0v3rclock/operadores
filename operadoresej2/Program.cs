using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace operadoresej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero entero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("el menor es " + num1);
                Console.WriteLine("el mayor es " + num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("el menor es " + num2);
                Console.WriteLine("el mayor es " + num1);
            }
            else
            {
                Console.WriteLine(num2 + " ambos son iguales " + num1);
            }
            Thread.Sleep(500);
            Console.WriteLine("pulse para continuar");
            Console.ReadKey();
        }
    }
}
