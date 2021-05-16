using System;
using Common;

namespace _4_SeggregationOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 1, 0, 1, 1, 1 };
            //arr.PrintArray();
            //var seggregate0sAnd1s = new Seggregate0sAnd1s();
            //seggregate0sAnd1s.CountingMethod(ref arr);
            //var seggregate0sAnd1s = new Seggregate0sAnd1s();
            //seggregate0sAnd1s.TraversingTwoIndexes(ref arr);

            int[] arr012 = new int[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            var dutchProblem = new DutchNationalFlagProblem();
            dutchProblem.Sort012(ref arr012);
            arr012.PrintArray();

            int[] negArr = new int[] { -12, 11, -13, -5, 6, -7, 5, -3, -6 };
            negArr.PrintArray();
            var separateNegativeAndPositive = new SeparateNegativeAndPositiveElements();
            separateNegativeAndPositive.SeparateElements(ref negArr);
            negArr.PrintArray();
            Console.ReadLine();
        }
    }
}
