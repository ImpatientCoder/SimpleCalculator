using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface ICalculator<T>
    {
        public T calculate(T a, T b);
    }
}
