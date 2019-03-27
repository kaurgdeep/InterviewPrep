using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            Console.WriteLine(JumpingOnTheClouds(arr));
            Console.WriteLine("Hello World!");
        }

        static int JumpingOnTheClouds(int[] arr)
        {
            int countJump = 0;
            var i = 0;
            while (i < arr.Length-1)
            {
                if(i+2 < arr.Length && arr[i+2] == 0) // or (i+2 <= arr.Length-1 )
                {
                    i = i + 2;
                    countJump++;
                }
                else
                {
                    i++;
                    countJump++;
                }
            }
            return countJump;
        }
    }
}
