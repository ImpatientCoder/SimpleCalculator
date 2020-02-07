using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IOperation
    {
        public double calculate(double a, double b);

        /*public Object calculate(Object a, Object b);*/
    }
}
