using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator.Interface
{
    interface IOperacionesAritmeticas
    {
        public decimal Sumar(decimal num1, decimal num2);
        public decimal Restar(decimal num1, decimal num2);
        public decimal Multiplicar(decimal num1, decimal num2);
        public decimal Dividir(decimal num1, decimal num2);

    }
}
