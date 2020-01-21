using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            IOperation operation =  user.chooseOperation("*");
            double output = operation.calculate(100, 200);
            Console.WriteLine("Output of the operation: "+output);

            IOperation add = new Addition();
            Console.WriteLine(add.calculate(100, 200));
        }
    }
}
