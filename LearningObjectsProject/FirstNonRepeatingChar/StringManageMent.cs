using System.Collections.Generic;

namespace LearningObjectsProject.FirstNonRepeatingChar
{
    class StringManageMent
    {
        public char NonRepeatingCharByMethod(string sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence.IndexOf(sequence[i]) == sequence.LastIndexOf(sequence[i]))
                {
                    return sequence[i];
                }
            }
            return '_';
        }
        public char NonRepeatingCharByCountArray(string sequence)
        {
            int[] charCount = new int[26];

            foreach (var ch in sequence)
            {
                charCount[ch - 'a']++;
            }
            foreach (var ch in sequence)
            {
                if (charCount[ch - 'a'] == 1)
                {
                    return ch;
                }
            }
            return '_';
        }
        public char NonRepeatingCharByDicktionary(string sequence)
        {
            IDictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var item in sequence)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                {
                    dict[item]++;
                }
            }
            foreach (var keyValue in dict)
            {
                if (keyValue.Value != 1)
                {
                    continue;
                }
                return keyValue.Key;

            }
            return '_';
        }
    }
}
