using System;

namespace _6_MaximumProductSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 6, -3, -10, 0, 2 };
            int[] arr2 = { 8, -2, -2, 0, 8, 0, -6, -8, -6, -1 };
            int[] arr3 = { -8, 5, 3, 1, 6 };
            //int value = MaxProductArray(arr1);
            int value2 = MaximumProductArray(arr3);
        }

        /// <summary>
        /// Time complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int MaximumProductArray(int[] arr)
        {
            int minValue = arr[0];
            int maxValue = arr[0];
            int maxProduct = arr[0];
            int index = 1;
            while (index < arr.Length)
            {
                if (arr[index] < 0)
                    swap(ref minValue, ref maxValue);
                maxValue = Math.Max(arr[index] * maxValue, arr[index]);
                minValue = Math.Min(arr[index] * minValue, arr[index]);
                maxProduct = Math.Max(maxValue, maxProduct);
                index++;
            }
            return maxProduct;
        }

        /// <summary>
        /// Time complexity: O(n), Auxiliary Space: O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int MaxProductArray(int[] arr)
        {
            int minValue = 1; //It is always 1 or negative
            int maxValue = 1; //It is always 1 or positive
            int index = 0;
            int maxProduct = 0;
            int flagIfSomePositiveElementFound = 1;
            while (index < arr.Length)
            {
                //Update maxValue for positive element, and update minValue only when minValue is negative
                if (arr[index] > 0)
                {
                    maxValue = maxValue * arr[index];
                    minValue = Math.Min(minValue * arr[index], 1);
                    flagIfSomePositiveElementFound = 1;
                }
                //If element is negative, maxValue can be either positive or 1 and minValue can be either
                // negative or 1. 
                else if (arr[index] < 0)
                {
                    int temp = maxValue;
                    maxValue = Math.Max(minValue * arr[index], 1);
                    minValue = temp * arr[index];
                }
                else
                {
                    maxValue = 1;
                    minValue = 1;
                }
                if (maxProduct < maxValue)
                    maxProduct = maxValue;
                index++;
            }
            if (flagIfSomePositiveElementFound == 0 && maxValue == 0)
                return 0;
            return maxValue;
        }

        static void swap(ref int minValue, ref int maxValue)
        {
            int temp = minValue;
            minValue = maxValue;
            maxValue = temp;
        }
    }
}
