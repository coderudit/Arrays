using System;
using Common;

//https://www.geeksforgeeks.org/maximum-and-minimum-in-an-array/
namespace _3_MaxAndMinOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 3, 1, 10, 0, 17 };
            arr.PrintArray();
            //var minAndMax = LinearSearchMethod(ref arr);
            var tupleMinAndMax = Tournament_DivideAndConquer(ref arr, 0, arr.Length - 1);
            //var pairMinAndMax = PairWise(ref arr);
            arr.PrintArray();
        }

        /// <summary>
        /// Time complexity: O(n)
        /// Worst case comparisons: O(1+2(n-2)) 
        /// Best case comparisons: O(1+n-2) [When only 1 comparison executes]
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static Tuple<int, int> LinearSearchMethod(ref int[] arr)
        {
            if (arr.Length == 1)
                return new Tuple<int, int>(arr[0], arr[0]);

            int min = arr[0], max = arr[1];
            if (arr[0] > arr[1])
            {
                max = arr[0];
                min = arr[1];
            }

            if (arr.Length == 2)
            {
                return new Tuple<int, int>(min, max);
            }


            for (int start = 2; start < arr.Length; start++)
            {
                if (arr[start] > max)
                    max = arr[start];
                else if (arr[start] < min)
                    min = arr[start];
            }
            return new Tuple<int, int>(min, max);
        }

        static Tuple<int, int> Tournament_DivideAndConquer(ref int[] arr, int start, int end)
        {
            if (start == end)
                return new Tuple<int, int>(arr[start], arr[start]);

            int min = arr[start], max = arr[end];
            if (arr[start] > arr[end])
            {
                max = arr[start];
                min = arr[end];
            }

            if (end == start + 1)
                return new Tuple<int, int>(min, max);
           
            int mid = (start + end) / 2;
            var mml = Tournament_DivideAndConquer(ref arr, start, mid);
            var mmr = Tournament_DivideAndConquer(ref arr, mid + 1, end);

            min = mml.Item1;
            max = mml.Item2;
            if (mmr.Item1 < mml.Item1)
                min = mmr.Item1;
            if (mml.Item2 < mmr.Item2)
                max = mmr.Item2;
            return new Tuple<int, int>(min, max);
        }

        /// <summary>
        /// Time complexity: If n is odd: 3*(n-1)/2
        /// If n is even: 1 + 3*(n-2)/2 = 3n/2 - 2          
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static Tuple<int, int> PairWise(ref int[] arr)
        {
            int length = arr.Length;
            int min, max;
            int startIndex;
            if (length % 2 == 0)
            {
                if (arr[0] > arr[1])
                {
                    max = arr[0];
                    min = arr[1];
                }
                else
                {
                    min = arr[0];
                    max = arr[1];
                }
                startIndex = 2;
            }
            else
            {
                min = arr[0];
                max = arr[0];
                startIndex = 1;
            }
            while (startIndex < length - 1) //Elements processed: n-1 if n is odd and n-2 if n is even
            {
                if (arr[startIndex] > arr[startIndex + 1]) //Comparison 1
                {
                    if (arr[startIndex] > max) //Comparison 2
                        max = arr[startIndex];
                    if (arr[startIndex + 1] < min) //Comparison 3
                        min = arr[startIndex + 1];

                }
                else
                {
                    if (arr[startIndex + 1] > max)
                        max = arr[startIndex + 1];
                    if (arr[startIndex] < min)
                        min = arr[startIndex];
                }
                startIndex += 2; //n/2 elements processing as increment of 2
                /* Increment the index by 2 as two 
            elements are processed in loop */
            }
            return new Tuple<int, int>(min, max);
        }
    }
}
