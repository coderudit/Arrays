using System;

namespace _10_CommonElementIn3SorteddArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 10, 20, 40, 80 };
            int[] arr2 = { 6, 7, 20, 80, 100 };
            int[] arr3 = {3, 4, 15, 20, 30, 70, 80, 120};
            CommonElements(arr1, arr2, arr3);
        }

        static void CommonElements(int[] arr1, int[] arr2, int[] arr3)
        {
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            while (index1 < arr1.Length && index2 < arr2.Length && index3 < arr3.Length)
            {
                if (arr1[index1] == arr2[index2] && arr2[index2] == arr3[index3])
                {
                    Console.WriteLine(arr1[index1]);
                    index1++;
                    index2++;
                    index3++;
                }
                else if (arr1[index1] < arr2[index2])
                    index1++;
                else if (arr2[index2] < arr3[index3])
                    index2++;
                else
                    index3++;

            }
        }
    }
}
