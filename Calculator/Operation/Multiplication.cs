using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Multiplication : IOperation
    {
        public double calculate(double a, double b)
        {
            return a * b;
        }
    }
}
