using SimpleCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class Calculos : IOperacionesAritmeticas
    {
        private decimal _num1 { get; set; }
        private decimal _num2 { get; set; }

        public Calculos(decimal num1, decimal num2)
        {
            this._num1 = num1;
            this._num2 = num2;
        }

        public decimal Dividir() => _num2 == 0 ? 0 : _num1 / _num2;

        public decimal Multiplicar() => _num1 * _num2;

        public decimal Restar() => _num1 - _num2;

        public decimal Sumar() => _num1 + _num2;
    }
}
