using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ArrayRotation
{
    public class _2_RotateWithTempArray
    {
        /// <summary>
        /// Rotate by storing d elements in temp array
        /// Time complexity = O(n) = O(rotateWith) + O(arr.Length-rotateWith) + O(rotateWith)
        /// Auxiliary Space = O(d)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rotateWith"></param>
        public void RotateWithTempArray(ref int[] arr, int rotateWith)
        {
            Console.WriteLine("Rotate With Temp Array started: ");
            int[] temp = new int[rotateWith];
            //O(rotateWith)
            for (int start = 0; start < rotateWith; start++)
            {
                temp[start] = arr[start];
            }

            //O(arr.Length-rotateWith)
            for (int start = 0; start < arr.Length - rotateWith; start++)
            {
                arr[start] = arr[start + rotateWith];
            }

            //O(rotateWith)
            int tempIndex = 0;
            for (int start = arr.Length - rotateWith; start < arr.Length; start++)
            {
                arr[start] = temp[tempIndex];
                tempIndex++;
            }
            Console.WriteLine("Rotate With Temp Array ended: ");
        }
    }
}
