namespace _1_ArrayRotation
{
    public class _5_ReversalAlgorithmForArrayRotation
    {
        public void RotateArray(int[] arr, int d)
        {
            if (d == 0)
                return;
            int n = arr.Length;
            d %= n;
            ReverseArray(arr, 0, d - 1);
            ReverseArray(arr, d, n - 1);
            ReverseArray(arr, 0, n - 1);
        }

        /// <summary>
        /// Time complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void ReverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
