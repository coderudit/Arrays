 using System;
using System.Collections.Generic;
using Common;

namespace _5_UnionAndIntersectionOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            UnionAndIntersectionOfSortedArray();
            UnionAndIntersectionOfUnsortedArray();
            UnionAndIntersectionOfUnsortedArrayWithHashing();
        }

        private static void UnionAndIntersectionOfSortedArray()
        {
            int[] arr1 = { 1, 2, 4, 5, 6 };
            int[] arr2 = { 2, 3, 5, 7 };
            int[] unionArrWithoutDuplicates = UnionOf2SortedArrays(arr1, arr2);
            unionArrWithoutDuplicates.PrintArray();
            int[] intersectionArrWithoutDuplicates = IntersectionOf2SortedArrays(arr1, arr2);
            intersectionArrWithoutDuplicates.PrintArray();
            int[] arr3 = { 1, 2, 2, 2, 3 };
            int[] arr4 = { 2, 3, 4, 5 };
            int[] unionArrWithDuplicates = UnionOf2SortedArrays(arr3, arr4);
            unionArrWithDuplicates.PrintArray();
            int[] intersectionArrWithDuplicates = IntersectionOf2SortedArrays(arr3, arr4);
            intersectionArrWithDuplicates.PrintArray();
            /*
             * Another approach that is useful when difference between sizes of two given arrays is 
             * significant. 
               The idea is to iterate through the shorter array and do a binary search for every element 
               of short array in big array (note that arrays are sorted). Time complexity of this 
               solution is O(min(mLogn, nLogm)). This solution works better than the above approach when
               ratio of larger length to smaller is more than logarithmic order.
             */
        }

        /// <summary>
        /// Union of the two arrays can be defined as the set containing distinct elements from both
        /// the arrays. If there are repetitions, then only one occurrence of element should be printed 
        /// in union.
        /// Time Complexity : O(m + n)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        static int[] UnionOf2SortedArrays(int[] arr1, int[] arr2)
        {
            int[] unionArr = new int[arr1.Length + arr2.Length];
            int unionArrIndex = 0;
            int arr1Index = 0;
            int arr2Index = 0;
            int prevAddedElement = 0;
            while (arr1Index < arr1.Length && arr2Index < arr2.Length)
            {
                //Handles duplicacy
                if (prevAddedElement == arr1[arr1Index])
                {
                    arr1Index++;
                    continue;
                }
                else if (prevAddedElement == arr2[arr2Index])
                {
                    arr2Index++;
                    continue;
                }
                if (arr1[arr1Index] == arr2[arr2Index])
                {
                    unionArr[unionArrIndex] = arr1[arr1Index];
                    arr1Index++;
                    arr2Index++;
                }
                else if (arr1[arr1Index] < arr2[arr2Index])
                {
                    unionArr[unionArrIndex] = arr1[arr1Index];
                    arr1Index++;
                }
                else
                {
                    unionArr[unionArrIndex] = arr2[arr2Index];
                    arr2Index++;
                }
                prevAddedElement = unionArr[unionArrIndex];
                unionArrIndex++;
            }
            while (arr1Index < arr1.Length)
            {
                unionArr[unionArrIndex] = arr1[arr1Index];
                arr1Index++;
                unionArrIndex++;
            }
            while (arr2Index < arr2.Length)
            {
                unionArr[unionArrIndex] = arr2[arr2Index];
                arr2Index++;
                unionArrIndex++;
            }
            return unionArr;
        }

        /// <summary>
        /// Intersection of the two arrays can be defined as the set containing same elements from both
        /// the arrays. If there are repetitions, then only one occurrence of element should be printed 
        /// in union.
        /// Time Complexity : O(Min(m,n))
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        static int[] IntersectionOf2SortedArrays(int[] arr1, int[] arr2)
        {
            int max_arr1 = arr1.Length;
            int max_arr2 = arr2.Length;
            int intersectionArrIndex = max_arr1;
            if (max_arr2 > max_arr1)
                intersectionArrIndex = max_arr2;
            int[] intersectionArr = new int[intersectionArrIndex];
            intersectionArrIndex = 0;
            int arr1Index = 0;
            int arr2Index = 0;
            int prevAddedElement = 0;
            while (arr1Index < arr1.Length && arr2Index < arr2.Length)
            {
                //Handles duplicacy
                if (prevAddedElement == arr1[arr1Index])
                {
                    arr1Index++;
                    continue;
                }
                else if (prevAddedElement == arr2[arr2Index])
                {
                    arr2Index++;
                    continue;
                }
                if (arr1[arr1Index] == arr2[arr2Index])
                {
                    intersectionArr[intersectionArrIndex] = arr1[arr1Index];
                    arr1Index++;
                    arr2Index++;
                    intersectionArrIndex++;
                }
                else if (arr1[arr1Index] < arr2[arr2Index])
                {
                    arr1Index++;
                }
                else
                {
                    arr2Index++;
                }
                prevAddedElement = intersectionArr[intersectionArrIndex];
            }
            return intersectionArr;
        }

        private static void UnionAndIntersectionOfUnsortedArray()
        {
            int[] arr1 = { 7, 1, 5, 2, 3, 6 };
            int[] arr2 = { 3, 8, 6, 20, 7 };
            Array.Sort(arr1);
            Array.Sort(arr2);
            int[] unionArrWithoutDuplicates = UnionOf2SortedArrays(arr1, arr2);
            unionArrWithoutDuplicates.PrintArray();
            int[] intersectionArrWithoutDuplicates = IntersectionOf2SortedArrays(arr1, arr2);
            intersectionArrWithoutDuplicates.PrintArray();

            int[] arr3 = { 1, 2, 2, 2, 3 };
            int[] arr4 = { 2, 3, 4, 5 };
            Array.Sort(arr3);
            Array.Sort(arr4);
            int[] unionArrWithDuplicates = UnionOf2SortedArrays(arr3, arr4);
            unionArrWithDuplicates.PrintArray();
            int[] intersectionArrWithDuplicates = IntersectionOf2SortedArrays(arr3, arr4);
            intersectionArrWithDuplicates.PrintArray();
            /*
             * Another approach that is useful when difference between sizes of two given arrays is 
             * significant. 
               The idea is to iterate through the shorter array and do a binary search for every element 
               of short array in big array (note that arrays are sorted). Time complexity of this 
               solution is O(min(mLogn, nLogm)). This solution works better than the above approach when
               ratio of larger length to smaller is more than logarithmic order.
             */
        }

        private static void UnionAndIntersectionOfUnsortedArrayWithHashing()
        {
            int[] arr1 = { 7, 1, 5, 2, 3, 6 };
            int[] arr2 = { 3, 8, 6, 20, 7 };
            printUnion(arr1, arr2);
            printIntersection(arr1, arr2);
        }

        // Prints union of arr1[0..m-1] and arr2[0..n-1]
        static void printUnion(int[] arr1, int[] arr2)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);
            for (int i = 0; i < arr2.Length; i++)
                hs.Add(arr2[i]);

            Console.WriteLine(string.Join(", ", hs));
        }

        // Prints intersection of arr1[0..m-1] and arr2[0..n-1]
        static void printIntersection(int[] arr1, int[] arr2)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);

            for (int i = 0; i < arr2.Length; i++)
                if (hs.Contains(arr2[i]))
                    Console.Write(arr2[i] + " ");
        }
    }
}
