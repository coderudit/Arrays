namespace _1_ArrayRotation
{
    public class _3_RotateByJuggling
    {
        /// <summary>
        /// Take GCD of Array's length and rotation, it helps us to find length of subarrays
        /// i.e. grouping possible.
        /// It ensures rotations does not exceeds n.
        /// As for n=30, d=1 => 1*30
        /// n=30, d=2 => 2*15
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rotateWith"></param>
        public void RotateByJuggling(ref int[] arr, int rotateWith)
        {
            rotateWith %= arr.Length;
            int length = arr.Length;
            int outer_rotations = gcd(length, rotateWith);
            //Outer rotations is 1 but inner rotations are 30 for gcd of 1 and 30
            //Outer rotations is 2 but inner rotations are 15 for gcd of 2 and 30, as on first rotation elements with index
            //of 0,2,4,6,....28 will be rotated, then, 1,3,5,7,....29 will be rotated.
            for (int subArrayIndex = 0; subArrayIndex < outer_rotations; subArrayIndex++)
            {
                int temp = arr[subArrayIndex];//Assign initial index to temp
                int currentIndex = subArrayIndex;//Assign the index from where rotation will be started
                while (true)
                {
                    int nextIndex = currentIndex + rotateWith; //take the next index whose value will be stored inside current
                    //Greedy method
                    if (nextIndex >= length)
                        nextIndex -= length; //Will execute for atmost 1 time per rotation
                    //or for above 2 steps nextIndex = (currentIndex + rotateWith)%length
                    if (nextIndex == subArrayIndex) //If index is same from where it started
                        break;
                    arr[currentIndex] = arr[nextIndex];
                    currentIndex = nextIndex;
                }
                arr[currentIndex] = temp;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rotateWith"></param>
        public void RotateRightByJuggling(ref int[] arr, int rotateWith)
        {
            rotateWith %= arr.Length;
            int length = arr.Length;
            int outer_rotations = gcd(length, rotateWith);
            for (int rotationIndex = 0; rotationIndex < outer_rotations; rotationIndex++)
            {
                int currentIndex = arr.Length - 1 - rotationIndex; //Assign the index from where rotation will be started
                int temp = arr[currentIndex]; //Assign initial index to temp
                while (true)
                {
                    int nextIndex = currentIndex - rotateWith; //take the next index whose value will be stored inside current
                    
                    if (nextIndex <= -1) //For left rotate it was length
                        nextIndex += length; //Will execute for atmost 1 time per rotation
                    if (nextIndex == arr.Length - 1 - rotationIndex) //For left rotate it was starting index
                        break;
                    arr[currentIndex] = arr[nextIndex];
                    currentIndex = nextIndex;
                }
                arr[currentIndex] = temp;
            }
        }

        private int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }
    }
}
