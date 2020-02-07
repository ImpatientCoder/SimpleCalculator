using LearningObjectsProject.FirstNonRepeatingChar;
using System;
using System.Linq;
/* input
3
7 11
2 9 1 3 18 1 4
4 35
11 9 10 7
1 8
5
*/

namespace LearningObjectsProject
{
    class Program
    {
        private static String[] input;
        public static void Main(String[] args)
        {
            #region FirstDuplicateDemo

            FirstDuplicate firstDuplicate = new FirstDuplicate();
            //int[] inputArray = new int[] { 2, 1, 3, 5, 3, 2 };
            int[] inputArray = new int[] { 1, 2, 1, 2, 3, 3 };

            int output = firstDuplicate.Duplicate(inputArray);
            Console.WriteLine("Duplicate number: " + output);

            output = firstDuplicate.DuplicateByDictionary(inputArray);
            Console.WriteLine("Duplicate number: " + output);

            #endregion

            #region NonRepeatingCharacter

            StringManageMent stringMangement = new StringManageMent();
            string input = "aaabcccdeeef";
            char ch = stringMangement.NonRepeatingCharByCountArray(input);
            Console.WriteLine("Expected output: " + ch);

            ch = stringMangement.NonRepeatingCharByDicktionary(input);
            Console.WriteLine("Expected output: " + ch);

            ch = stringMangement.NonRepeatingCharByMethod(input);
            Console.WriteLine("Expected output: " + ch);

            #endregion

            #region DelegateEventDemo
            /*            var video = new Video() { Title = "Video 1" };
                        var videoEncoder = new VideoEncoder(); //publisher

                        var mail = new MailService(); //subscriber
                        var message = new MessageService();

                        videoEncoder.VideoEncoded += mail.OnVideoEncoded;
                        videoEncoder.VideoEncoded += message.OnVideoEncoded;

                        videoEncoder.Encode(video);*/
            #endregion

            #region RandomClassUsesDemo
            /*          RandomGenerator generator = new RandomGenerator();

                        Random random = new Random();
                        int num = random.Next(1000); //a random number. 
                        int num2 = random.Next(1000); //a random number less than 1000.

                        int rand = generator.RandomNumber(5, 100);
                        Console.WriteLine($"Random number between 5 and 100 is {rand}");

                        string str = generator.RandomString(10, false);
                        Console.WriteLine($"Random string of 10 chars is {str}");

                        string pass = generator.RandomPassword();
                        Console.WriteLine($"Random string of 6 chars is {pass}");

                        Console.ReadKey();*/
            #endregion

        }
        /*
                var arr = ReadIntLine();
                var n = arr[0];
                var q = arr[1];

                for (; q > 0; q--)
                {
                    var newArr = ReadIntLine();
                    var r = newArr[0];
                    var c = newArr[1];
                }
        */

        #region LibraryFunctions
        private static void Writeln<T>(T a) => Console.WriteLine(a);
        private static long[] ReadLongLine()
        {
            return Console.ReadLine().Split().Select(long.Parse).ToArray();
        }
        private static int[] ReadIntLine() => Console.ReadLine().Split().Select(int.Parse).ToArray();
        private static long ReadLong() => Convert.ToInt64(Console.ReadLine());
        private static int ReadInt() => Convert.ToInt32(Console.ReadLine());
        #endregion
    }
}
