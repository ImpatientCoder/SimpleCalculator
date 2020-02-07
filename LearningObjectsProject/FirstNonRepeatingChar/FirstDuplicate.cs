using System.Collections.Generic;

namespace LearningObjectsProject.FirstNonRepeatingChar
{
    class FirstDuplicate
    {
        //Finding second occurence that has minimal index...
        public int Duplicate(int[] array)
        {
            int[] numberCount = new int[10];
            int minIndex = 9999;

            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];

                numberCount[number - 1]++;

                if (numberCount[number - 1] > 1)
                {
                    if (minIndex > i)
                    {
                        minIndex = i;
                    }
                }
            }

            if (minIndex != 9999) return array[minIndex];
            return -1;
        }

        public int DuplicateByDictionary(int[] array)
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();

            int minIndex = 9999;
            for (int i = 0; i < array.Length; i++)
            {
                if (!dict.ContainsKey(array[i]))
                    dict.Add(array[i], 1);
                else
                {
                    dict[array[i]]++; //return i; right way..!

                    if (minIndex > i)
                    {
                        minIndex = i;
                    }
                }
            }

            if (minIndex != 9999) return array[minIndex];
            return -1;
        }
    }
}
