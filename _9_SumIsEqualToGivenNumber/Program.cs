using System;
using System.Collections.Generic;

namespace _9_SumIsEqualToGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, -1, 5 };
            SumIsEqualToGivenNumber(arr, 6);
        }

        /// <summary>
        /// Time complexity: O(n), Auxiliary space: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        static int SumIsEqualToGivenNumber(int[] arr, int sum)
        {
            var dict = new Dictionary<int, int>();
            int index = 0;
            while (index < arr.Length)
            {
                if (!dict.ContainsKey(arr[index]))
                    dict[arr[index]] = 0;
                dict[arr[index]] = dict[arr[index]] + 1;
                index++;
            }
            index = 0;
            int twiceCount = 0;
            while (index < arr.Length)
            {
                if (dict[sum - arr[index]] != 0)
                {
                    twiceCount += dict[sum - arr[index]];
                }
                if (sum - arr[index] == arr[index])
                    twiceCount--;
                index++;
            }
            return twiceCount / 2;
        }
    }
}
