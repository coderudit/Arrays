using System;
using Common;

namespace SumOfkElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            arr.PrintArray();
            Console.WriteLine($"Sum: {SumOfElements(arr, 3)}");
            arr.PrintArray();
            Console.ReadLine();
        }

        /// <summary>
        /// Time complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="streak"></param>
        /// <returns></returns>
        static int SumOfElements(int[] arr, int streak)
        {
            int sum = 0;
            for (int index = 0; index < streak; index++)
            {
                sum += arr[index];
            }
            int currentIndex = 0;
            int maxSum = sum;
            for (int index = streak; index < arr.Length; index++, currentIndex++)
            {
                sum -= arr[currentIndex];
                sum += arr[index];
                if (maxSum < sum)
                    maxSum = sum;
            }
            return sum;
        }
    }
}
