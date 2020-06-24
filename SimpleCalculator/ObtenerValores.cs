using SimpleCalculator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public static class ObtenerValores
    {
        // Obtener los numeros y la opcion seleccionada
        public static void ObtenerCalculos(out Calculos calculos, out Enums.Opciones opciones)
        {
            decimal numero1 = ObtenerNumero("Primer");

            decimal numero2 = ObtenerNumero("Segundo");

            calculos = new Calculos(numero1, numero2);
            Console.WriteLine("Primer número: {0}, Segundo número: {1}", numero1, numero2);

            MostrarMenu();

            opciones = OpcionSeleccionada();
        }

        private static decimal ObtenerNumero(string nombreNumero)
        {
            Console.WriteLine("Ingrese el {0} número: ", nombreNumero);
            decimal numero;
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out numero))
                    break;
                else
                    Console.WriteLine("Vuelva a escribir el {0} número: ", nombreNumero);
            }

            return numero;
        }

        private static void MostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menú");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Cambiar el valor de los números");
            Console.WriteLine("6 - Salir");
            Console.WriteLine();
        }

        public static Enums.Opciones OpcionSeleccionada()
        {
            Console.WriteLine("Ingrese la opción deseada: ");

            int opcionSeleccionada;

            // Si hay problema retorna 0
            int.TryParse(Console.ReadLine(), out opcionSeleccionada);

            // Convertir de int a enum
            Opciones opciones = (Opciones)Enum.ToObject(typeof(Opciones), opcionSeleccionada);

            // Si no hay proboema
            if (Opciones.Error != opciones)
                Console.WriteLine("La opcion seleccionada es {0}", opciones);

            return opciones;
        }
    }
}
