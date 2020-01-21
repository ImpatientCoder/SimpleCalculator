using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class User
    {
        public IOperation chooseOperation(string choice)
        {
            switch (choice)
            {
                case "+":   return new Addition(); 
                   
                case "-":   return new Substraction(); 
        
                case "*":   return new Multiplication();
                    
                case "/":   return new Division();
                    
                default:
                    Console.WriteLine("Invalid choice");

                return null;                   
            }
        }
    }
}
