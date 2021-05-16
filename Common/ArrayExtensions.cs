using System;
using System.Collections.Generic;

namespace Common
{
    public static class ArrayExtensions
    {
        public static void PrintArray<T>(this T[] arr)
        {
            Console.WriteLine("\nPrinting array:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
