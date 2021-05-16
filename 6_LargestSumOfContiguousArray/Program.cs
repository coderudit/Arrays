using System;

namespace _6_LargestSumOfContiguousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine("Largest sum: " + LargestSum(ref arr));
            Console.ReadLine();
        }
        private static int LargestSum(ref int[] arr)
        {
            int max_so_far = int.MinValue;
            int current_sum = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                current_sum += arr[index];
                //if (max_so_far < current_sum)
                //    max_so_far = current_sum;
                //if (current_sum < 0)
                //    current_sum = 0;
                //Optimized
                if (current_sum < 0)
                    current_sum = 0;
                else if (current_sum > max_so_far)
                    max_so_far = current_sum;
                
            }
            return max_so_far;
        }
    }
}
