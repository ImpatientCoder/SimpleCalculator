using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class User
    {
        public IOperation chooseOperation(string choice)
        {
            //Console.WriteLine("Object passed...");
            if (choice.Equals("+"))
            {
                //Console.WriteLine("Object passed...");
                return new Addition();
            }
            else if(choice.Equals("-"))
            {
                return new Substraction();
            }
            else if (choice.Equals("*"))
            {
                return new Multiplication();
            }
            else if (choice.Equals("/"))
            {
                return new Division();
            }
            return null;
        }
    }
}
