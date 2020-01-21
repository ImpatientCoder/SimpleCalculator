using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Division : IOperation
    {
        public double calculate(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Can't divide by zero..!");
                return default;
            }
                

            return a / b;
        }

    }
}
