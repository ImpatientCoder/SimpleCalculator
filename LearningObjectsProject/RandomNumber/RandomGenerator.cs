using System;
using System.Text;

namespace LearningObjectsProject
{
    public class RandomGenerator
    {

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max); // Generate a random number between two numbers    
        }


        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)// Generate a random string with a given size  
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }


        public string RandomPassword()
        {
            StringBuilder builder = new StringBuilder(); // Generate a random password of size 10
            builder.Append(RandomString(4, true)); //4 LowerCaseLetters, 4 numbers and two upperCase.
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
    }
}



