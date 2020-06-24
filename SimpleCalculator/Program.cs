using System;
using System.Runtime.CompilerServices;
using SimpleCalculator.Enums;

namespace SimpleCalculator
{
    public class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine();

            Calculos calculos;
            Enums.Opciones opciones;

            ObtenerValores.ObtenerCalculos(out calculos, out opciones);

            // Calcular 
            decimal total = ProcesarOpcionSeleccionada.ObtenerTotal(opciones, calculos);


            Console.WriteLine("El total es: {0}", total);
        }
    }
}
