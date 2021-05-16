using System;
using System.Collections;
using System.Collections.Generic;

namespace _0_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[11] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, -1 };
            //BinarySearch(arr, 4);
            //InsertingInSortedArray(arr, 15);
            //SingleMissingElementInArray_Formula();
            //SingleMissingElementInArray_WithIndex();
            //MultipleMissingElementsInArray_WithIndex();
            //MultipleMissingElementsInUnsortedArray_WithHashing();
            //DuplicateElementsInSortedArray();
            //CountingDuplicateElementsInSortedArray();
            //CountingDuplicateElementsInSortedAndUnsortedArrayUsingHashing();
            //DuplicateElementsInUnsortedArray();
            //FindPairWithSumK();
            FindPairWithSumKWithHashing();
        }

        static void BinarySearch(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == key)
                {
                    Console.WriteLine($"Value find at index {mid + 1}");
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
        }

        static void InsertingInSortedArray(int[] arr, int value)
        {
            int index = arr.Length - 2;
            while (arr[index] > value)
            {
                arr[index + 1] = arr[index];
                index--;
            }
            arr[index + 1] = value;
        }

        static void SingleMissingElementInArray_Formula()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };
            int actualSum = 0;
            foreach (var item in arr)
            {
                actualSum += item;
            }
            int n = arr.Length + 1;
            int expectedSum = (n * (n + 1)) / 2;
            Console.WriteLine($"Missing element is {expectedSum - actualSum}");
        }

        static void SingleMissingElementInArray_WithIndex()
        {
            int[] arr = { 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17 };
            int diff = arr[0];
            int index = 0;
            for (int start = 1; start < arr.Length; start++)
            {
                if (!(diff == arr[start] - start))
                {
                    index = start;
                    break;
                }
            }
            Console.WriteLine($"Missing element is {index + diff}");
        }

        static void MultipleMissingElementsInArray_WithIndex()
        {
            int[] arr = { 6, 7, 8, 9, 11, 12, 13, 16, 17 };
            int diff = arr[0];
            for (int index = 1; index < arr.Length; index++)
            {
                if (!(diff == arr[index] - index))
                {
                    while (diff < arr[index] - index)
                    {
                        Console.WriteLine($"Missing element is {index + diff}");
                        diff++;
                    }
                }
            }
        }

        static void MultipleMissingElementsInUnsortedArray_WithHashing()
        {
            int[] arr = { 3, 7, 4, 9, 12, 6, 1, 11, 2, 10 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int start = 0; start < arr.Length; start++)
            {
                max = Math.Max(arr[start], max);
                min = Math.Min(arr[start], min);
                int count = 0;
                if (!dict.ContainsKey(arr[start]))
                {
                    dict.TryAdd(arr[start], 0);
                }
                else
                {
                    count = dict[arr[start]];
                }
                dict[arr[start]] = ++count;
            }
            for (int start = min; start <= max; start++)
            {
                if (!dict.ContainsKey(start))
                    Console.WriteLine($"Missing element is {start}");
            }
        }

        static void DuplicateElementsInSortedAndUnsortedArray()
        {
            int[] arr = { 3, 6, 8, 8, 10, 12, 15, 15, 15, 20 };
            int lastDuplicate = 0;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index] == arr[index + 1] && (arr[index + 1] != lastDuplicate))
                {
                    lastDuplicate = arr[index + 1];
                    Console.WriteLine(lastDuplicate);
                }
            }
        }

        static void CountingDuplicateElementsInSortedArray()
        {
            int[] arr = { 3, 6, 8, 8, 10, 12, 15, 15, 15, 20 };
            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index] == arr[index + 1])
                {
                    int count = 0;
                    while (arr[index] == arr[index + 1])
                    {
                        index = index + 1;
                        count++;
                    }
                    Console.WriteLine($"{arr[index]} appreared {count} times.");
                }
            }
        }

        static void CountingDuplicateElementsInSortedAndUnsortedArrayUsingHashing()
        {
            int[] arr = { 3, 6, 8, 8, 10, 12, 15, 15, 15, 20 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int count = 0;
                if (!dict.ContainsKey(arr[index]))
                {
                    dict.TryAdd(arr[index], 0);
                }
                else
                {
                    count = dict[arr[index]];
                }
                dict[arr[index]] = ++count;


            }
            foreach (var item in dict)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"{item.Key} appreared {item.Value} times.");
                }
            }
        }

        static void DuplicateElementsInUnsortedArray()
        {
            int[] arr = { 15, 15, 15, 20, 8, 8, 3, 6, 10, 12, };
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int count = 1;
                if (arr[index] != -1)
                {
                    for (int j = index + 1; j < arr.Length; j++)
                    {
                        if (arr[index] == arr[j])
                        {
                            count++;
                            arr[j] = -1;
                        }
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"{arr[index]} appreared {count} times.");
                }
            }
        }

        static void FindPairWithSumK()
        {
            int[] arr = { 1, 3, 4, 5, 6, 8, 9, 10, 12, 14 };
            int sum = 10;
            int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                if (arr[start] + arr[end] == sum)
                {
                    Console.WriteLine($"{arr[start]}+{arr[end]}={sum}");
                    start++;
                    end--;
                }
                else if (arr[start] + arr[end] > sum)
                    end--;
                else
                    start++;
            }
        }

        static void FindPairWithSumKWithHashing()
        {
            int[] arr = { 1, 3, 4, 5, 6, 8, 9, 10, 12, 14 };
            int sum = 10;
            HashSet<int> hashSet = new HashSet<int>();
            for (int start = 0; start < arr.Length - 1; start++)
            {
                int temp = sum - arr[start];
                if (hashSet.Contains(temp))
                    Console.WriteLine("Pair with given sum " + sum + " is (" + arr[start] + ", " + temp + ")");
                hashSet.Add(arr[start]);
            }
        }
    }
}
