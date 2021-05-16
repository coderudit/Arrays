using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SeggregationOfAnArray
{
    public class Seggregate0sAnd1s
    {
        /// <summary>
        /// Time complexity: O(2n)
        /// </summary>
        /// <param name="arr"></param>
        public void CountingMethod(ref int[] arr)
        {
            int count_0 = 0;
            int count_1 = 0;
            for (int startIndex = 0; startIndex < arr.Length; startIndex++)
            {
                if (arr[startIndex] == 0)
                    count_0++;
                if (arr[startIndex] == 1)
                    count_1++;
            }
            for (int startIndex = 0; startIndex < count_0; startIndex++)
            {
                arr[startIndex] = 0;
            }
            for (int startIndex = count_0; startIndex < arr.Length; startIndex++)
            {
                arr[startIndex] = 1;
            }
        }

        /// <summary>
        /// Time complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        public void TraversingTwoIndexes(ref int[] arr)
        {
            int startIndex = 0;
            int endIndex = arr.Length - 1;
            while (startIndex < endIndex)
            {
                if (arr[startIndex] == 1)
                {
                    Swap(ref arr, startIndex, endIndex);
                    endIndex--;
                }
                else
                    startIndex++;
            }
        }

        private static void Swap(ref int[] arr, int left, int right)
        {
            int temp = 0;
            arr[right] = arr[left];
            arr[left] = temp;
        }
    }
}
