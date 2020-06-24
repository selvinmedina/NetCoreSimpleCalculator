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
            Console.WriteLine("Ingrese el primer número: ");
            decimal numero1;
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out numero1))
                    break;
                else
                    Console.WriteLine("Vuelva a ingresar el primer número: ");
            }


            Console.WriteLine("Ingrese el segundo número: ");
            decimal numero2;
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out numero2))
                    break;
                else
                    Console.WriteLine("Vuelva a ingresar el segundo número: ");
            }

            calculos = new Calculos(numero1, numero2);
            Console.WriteLine("Número 1: {0}, Número 2: {1}", numero1, numero2);

            Console.WriteLine("Menú");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Cambiar el valor de los números");
            Console.WriteLine("6 - Salir");
            Console.WriteLine();

            opciones = OpcionSeleccionada();
        }

        public static Enums.Opciones OpcionSeleccionada()
        {
            Console.WriteLine("Ingrese la opción deseada: ");

            int opcionSeleccionada;
            int.TryParse(Console.ReadLine(), out opcionSeleccionada);
            Enums.Opciones opciones = (Enums.Opciones)Enum.ToObject(typeof(Enums.Opciones), opcionSeleccionada);

            Console.WriteLine("La opcion seleccionada es {0}", opciones);

            return opciones;
        }
    }
}
