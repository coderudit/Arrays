namespace _4_SeggregationOfAnArray
{
    public class SeparateNegativeAndPositiveElements
    {
        public void SeparateElements(ref int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                if (arr[start] > 0)
                {
                    Swap(ref arr, start, end);
                    end--;
                }
                else
                    start++;
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
