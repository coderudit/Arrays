using System;
using System.Collections.Generic;

namespace _7_FrequencyOfCharactersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToPrint = CountCharactersWithoutHashing("geeksforgeeks");
            CountCharactersWithDictionary("geeksforgeeks");
            foreach (var item in arrayToPrint)
            {
                Console.WriteLine(item);
            }
        }

        static int[] CountCharactersWithoutHashing(string str)
        {
            int alphabetsSize = 26;
            int[] frequencyArr = new int[alphabetsSize];
            for (int startIndex = 0; startIndex < str.Length; startIndex++)
            {
                frequencyArr[str[startIndex] - 'a']++;
            }
            return frequencyArr;
        }

        static void CountCharactersWithDictionary(string str)
        {
            Dictionary<char, int> countDict = new Dictionary<char, int>();
            for (int startIndex = 0; startIndex < str.Length; startIndex++)
            {
                char currentCharacter = str[startIndex];
                bool isValueReturned = countDict.TryGetValue(currentCharacter, out int frequency);
                frequency++;
                if (isValueReturned)
                    countDict[currentCharacter] = frequency;
                else
                    countDict.TryAdd(currentCharacter, frequency);
            }
        }
    }
}
