using System;
using System.Collections.Generic;
using System.Text;

namespace _6_MedianOfTwoSortedArrays
{
    public class MedianOfTwoSortedArraysWithDifferentSize
    {
        static void MedianOfTwoArrays(int[] arr1, int[] arr2)
        {

        }

        static int median(int[] arr, int length)
        {
            length = end - start + 1;
            if (length % 2 == 0)
                return (arr[length / 2 - 1] + arr[length / 2]) / 2;
            else
                return arr[length / 2] / 2;
        }
    }
}
