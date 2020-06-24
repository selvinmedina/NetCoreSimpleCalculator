using System;
using System.Runtime.CompilerServices;
using SimpleCalculator.Enums;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos calculos;
            int resultado;

            ObtenerValores(out calculos, out resultado);

            Enums.Opciones opciones = (Enums.Opciones)Enum.ToObject(typeof(Enums.Opciones), resultado);

            // Calcular 
            decimal total = ProcesarOpcionSeleccionada.ObtenerTotal(opciones, calculos);


            Console.WriteLine("El total es: {0}", total);
        }

        private static void ObtenerValores(out Calculos calculos, out int resultado)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine();

            Console.WriteLine("Ingrese el primer número: ");
            decimal numero1;
            decimal.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Ingrese el segundo número: ");
            decimal numero2;
            decimal.TryParse(Console.ReadLine(), out numero2);

            calculos = new Calculos(numero1, numero2);
            Console.WriteLine("Número 1: {0}, Número 2: {1}", numero2, numero2);

            Console.WriteLine("Menú");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Cambiar el valor de los números");
            Console.WriteLine("6 - Salir");

            Console.WriteLine();

            Console.WriteLine("Ingrese la opción deseada: ");

            int.TryParse(Console.ReadLine(), out resultado);

            Console.WriteLine("La opcion seleccionada es {0}", resultado);
        }
    }
}
