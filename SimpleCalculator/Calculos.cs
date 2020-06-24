using SimpleCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class Calculos : IOperacionesAritmeticas
    {
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        private decimal total { get; set; }

        public Calculos(decimal num1, decimal num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public decimal Dividir() => num2 == 0 ? 0 : num1 / num2;

        public decimal Multiplicar() => num1 * num2;

        public decimal Restar() => num1 - num2;

        public decimal Sumar() => num1 + num2;


    }
}
