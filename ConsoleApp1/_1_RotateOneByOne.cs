using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ArrayRotation
{
    public class _1_RotateOneByOne
    {
        /// <summary>
        /// Rotate elements one by one
        /// Time complexity = O(d * n) = O(rotateWith) * O(arr.Length)
        /// Auxiliary Space = O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rotateWith"></param>
        public void RotateOneByOne(ref int[] arr, int rotateWith)
        {
            //O(rotateWith)
            rotateWith = rotateWith % arr.Length;
            for (int startRotate = 0; startRotate < rotateWith; startRotate++)
            {
                int temp = arr[0];
                //O(arr.Length)
                for (int start = 0; start < arr.Length - 1; start++)
                {
                    arr[start] = arr[start + 1];
                }
                arr[arr.Length - 1] = temp;
            }
        }
    }
}
