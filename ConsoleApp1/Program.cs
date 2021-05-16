using System;
using Common;

namespace _1_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            arr.PrintArray();

            //var rotateOneByOne = new _1_RotateOneByOne();
            //rotateOneByOne.RotateOneByOne(ref arr, 2);

            //var rotateWithTempArray = new _2_RotateWithTempArray();
            //rotateWithTempArray.RotateWithTempArray(ref arr, 2);

            //var rotateByJuggling = new _3_RotateByJuggling();
            //rotateByJuggling.RotateByJuggling(ref arr, 2);
            //rotateByJuggling.RotateRightByJuggling(ref arr, 1);

            arr.PrintArray();
            Console.ReadLine();
        }

       

        

       
    }
}
