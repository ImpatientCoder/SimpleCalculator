using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ComplexNumber<T>: ICalculator<T>
    {
        double real, img;

        public T calculate(T a, T b)
        {
            throw new NotImplementedException();
        }
    }
}
