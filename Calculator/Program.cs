using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            IOperation div = user.chooseOperation("/");
            double output = div.calculate(100, 20);

            Console.WriteLine("\nOutput of the operation: " + output);

            IOperation mul = user.chooseOperation("*");
            output = mul.calculate(100, 20);

            Console.WriteLine("Output of the operation: " + output + "\n");
        }


    }
}
