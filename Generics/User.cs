using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class User<T>
    {
        public ICalculator<T> chooseOperation(string choice)
        {
            switch (choice)
            {
                case "1": return new ComplexNumber<T>();

                case "2": return new VectorCalculator<T>();

                default:
                    Console.WriteLine("Invalid choice");
                    return null;
            }
        }
    }
}
