using System;

namespace _6_MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 12, 15, 26, 38 };
            int[] arr2 = { 2, 13, 17, 30, 45 };
            //MedianOfTwoSortedArraysWithSameSize(arr1, arr2);
            MedianOfTwoSortedArraysWithSameSizeWithDivideAnConquer(arr1, arr2);
        }

        /// <summary>
        /// Time complexity: O(n)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        static int MedianOfTwoSortedArraysWithSameSize(int[] arr1, int[] arr2)
        {
            int arr1Index = 0;
            int arr2Index = 0;
            int index = 0;
            int currentElement = 0;
            int prevElement = 0;
            int median = 0;
            // Since there are 2n elements, median will be average of elements at index n-1 and n in  
            // the array obtained after merging ar1 and ar2 
            while (index <= arr1.Length)
            {
                if (arr1[arr1Index] < arr2[arr2Index])
                {
                    currentElement = arr1[arr1Index];
                    arr1Index++;
                }
                else if (arr2[arr2Index] <= arr2[arr1Index])
                {
                    currentElement = arr2[arr2Index];
                    arr2Index++;
                }
                if (index == arr1.Length)
                {
                    median = (prevElement + currentElement) / 2;
                }
                else
                {
                    prevElement = currentElement;
                }
                index++;
            }

            return median;
        }

        /// <summary>
        /// Time complexity: O(logn) 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        static void MedianOfTwoSortedArraysWithSameSizeWithDivideAnConquer(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;
            if (n1 != n2)
            {
                Console.WriteLine("Doesn't work for arrays " +
                                  "of unequal size");
            }
            else if (n1 == 0)
            {
                Console.WriteLine("Arrays are empty.");
            }
            else if (n1 == 1)
            {
                Console.WriteLine((arr1[0] + arr2[0]) / 2);
            }
            else
            {
                Console.WriteLine("Median is " +
                                   GetMedian(arr1, 0, arr1.Length - 1,
                                            arr2, 0, arr2.Length - 1));
            }
        }

        static int GetMedian(int[] arr1, int start1, int end1, int[] arr2, int start2, int end2)
        {
            if (end1 - start1 == 1)
            {
                return (Math.Max(arr1[start1], arr2[start2]) + Math.Min(arr1[end1], arr2[end2])) / 2;
            }
            else
            {
                int median_arr1 = Median(arr1, start1, end1);
                int median_arr2 = Median(arr2, start2, end2);
                if (median_arr1 == median_arr2)
                    return median_arr1;
                else if (median_arr1 < median_arr2)
                    return GetMedian(arr1, (end1 + start1 + 1) / 2, end1, arr2, start2, (end2 + start2 + 1) / 2);
                else
                    return GetMedian(arr2, start1, (end1 + start1 + 1) / 2, arr1, (end2 + start2 + 1) / 2, end2);
            }
        }

        static int Median(int[] arr, int start, int end)
        {
            int n = end - start + 1;
            if (n % 2 == 0)
                return (arr[start + (n / 2 - 1)] + arr[start + n / 2]);
            else
                return arr[start + n / 2];
        }
    }
}
