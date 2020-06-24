using System;
using System.Collections.Generic;
using System.Text;
using SimpleCalculator.Enums;

namespace SimpleCalculator
{
    public static class ProcesarOpcionSeleccionada
    {
        public static decimal ObtenerTotal(Opciones opcionSeleccionada, Calculos calculos)
        {
            while (true)
            {
                switch (opcionSeleccionada)
                {
                    case Opciones.Sumar:
                        return calculos.Sumar();
                    case Opciones.Restar:
                        return calculos.Restar();
                    case Opciones.Multiplicar:
                        return calculos.Multiplicar();
                    case Opciones.Dividir:
                        return calculos.Dividir();
                    case Opciones.CambiarValores:
                        ObtenerValores.ObtenerCalculos(out calculos, out opcionSeleccionada);
                        break;
                    case Opciones.Salir:
                        Environment.Exit(0);
                        return 0;
                    default:
                        Console.WriteLine("No existe la opción seleccionada, intente de nuevo");
                        opcionSeleccionada = ObtenerValores.OpcionSeleccionada();
                        break;
                }
            }
        }
    }
}
