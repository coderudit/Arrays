using System;

namespace _7_MinimizeTheMaximumDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 9, 12, 16, 20 };
            int key1 = 3;
            int[] arr2 = new int[] { 2, 6, 3, 4, 7, 2, 10, 3, 2, 1 };
            int key2 = 5;
            int value = MinimizeTheMaximumDifference(arr2, arr2.Length, key2);
        }

        static int MinimizeTheMaximumDifference(int[] arr, int n, int k)
        {
            if (n == 1)
                return 0;

            // Sort all elements 
            Array.Sort(arr);

            // Initialize result 
            int ans = arr[n - 1] - arr[0];

            int small = arr[0] + k;
            int large = arr[n-1] - k;
            int temp;
            //After addition and subtraction, if small becomes large, interchange it.
            if (small > large)
            {
                temp = small;
                small = large;
                large = temp;
            }
            for (int index = 1; index < n - 1; index++)
            {
                int subtract = arr[index] - k;
                int add = arr[index] + k;
                // If both subtraction and  
                // addition do not change diff 
                if (subtract >= small || add <= large)
                    continue;
                // Either subtraction causes a smaller 
                // number or addition causes a greater 
                // number. Update small or big using 
                // greedy approach (If big - subtract 
                // causes smaller diff, update small 
                // Else update big) 
                if (large - subtract <= add - small)
                    small = subtract;
                else
                    large = add;
            }
            return Math.Min(ans, large - small);
        }
    }
}
