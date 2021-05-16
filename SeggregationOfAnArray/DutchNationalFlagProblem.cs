using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SeggregationOfAnArray
{
    public class DutchNationalFlagProblem
    {
        public void Sort012(ref int[] arr)
        {
            int low = 0; int mid = 0; int high = arr.Length - 1;
            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        if (arr[low] != arr[mid])
                            Swap(ref arr, low, mid);
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        if (arr[mid] != arr[high])
                            Swap(ref arr, mid, high);
                        high--;
                        break;
                }
            }
        }

        private static void Swap(ref int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
