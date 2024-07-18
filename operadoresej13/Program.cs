using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadoresej13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializar variable de tipo entero con un valor predeterminado
            int edad = 30;
            Console.WriteLine("Valor inicial de la variable 'edad': " + edad);

            // Inicializar variable de tipo cadena con un valor predeterminado
            string nombre = "Juan Pérez";
            Console.WriteLine("Valor inicial de la variable 'nombre': " + nombre);

            // Inicializar variable de tipo decimal con un valor predeterminado
            double salario = 6000.25;
            Console.WriteLine("Valor inicial de la variable 'salario': " + salario);

            // Inicializar variable de tipo booleano con un valor predeterminado
            bool isAdmin = false;
            Console.WriteLine("Valor inicial de la variable 'isAdmin': " + isAdmin);

            // Inicializar variable de tipo caracter con un valor predeterminado
            char inicial = 'J';
            Console.WriteLine("Valor inicial de la variable 'inicial': " + inicial);

            Console.WriteLine("Ahora, vamos a cambiar los valores de las variables...");

            // Cambiar el valor de la variable 'edad'
            edad = 35;
            Console.WriteLine("Nuevo valor de la variable 'edad': " + edad);

            // Cambiar el valor de la variable 'nombre'
            nombre = "María García";
            Console.WriteLine("Nuevo valor de la variable 'nombre': " + nombre);

            // Cambiar el valor de la variable 'salario'
            salario = 7000.50;
            Console.WriteLine("Nuevo valor de la variable 'salario': " + salario);

            // Cambiar el valor de la variable 'isAdmin'
            isAdmin = true;
            Console.WriteLine("Nuevo valor de la variable 'isAdmin': " + isAdmin);

            // Cambiar el valor de la variable 'inicial'
            inicial = 'M';
            Console.WriteLine("Nuevo valor de la variable 'inicial': " + inicial);

            Console.ReadKey();
        }
    }
}
