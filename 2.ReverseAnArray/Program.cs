using System;
using Common;

namespace _2_ReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            arr.PrintArray();
            ReverseArray(ref arr);
            arr.PrintArray();
            RecursivelyReverseArray(ref arr, 0, arr.Length - 1);
            arr.PrintArray();

            Console.ReadLine();
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        static void ReverseArray(ref int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        static void RecursivelyReverseArray(ref int[] arr, int start, int end)
        {
            if (start >= end)
                return;
            int temp;
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            RecursivelyReverseArray(ref arr, start + 1, end - 1);
        }
    }
}
