using System;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 1, 5, 3, 6, 4 };
            int[] arr2 = new int[] { 7, 6, 4, 3, 1 };
            int[] arr3 = new int[] { 2, 1, 2, 1, 0, 1, 2 };
            int[] arr4 = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };
            int profit = MaxProfit(arr4);
        }
        public static int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int maxProfit = 0;
            for (int index = 0; index < prices.Length; index++)
            {
                if (prices[index] < min)
                {
                    min = prices[index];
                }
                else if (prices[index] - min > maxProfit)
                {
                    maxProfit = prices[index] - min;
                }
            }
            return maxProfit > 0 ? maxProfit : 0;
        }
    }
}
