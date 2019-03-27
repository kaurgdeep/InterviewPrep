//https://www.hackerrank.com/challenges/mini-max-sum/problem
//use long for overflow number 64bit int(which is long)
using System;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxSum(new int[] { 1, 2, 3, 4, 5 }); //10,14

            Console.WriteLine("Hello World!");
        }
        static void MinMaxSum(int[] arr)
        {
            long sum = 0;
            long minsum = 0;
            long maxsum = 0;
            var i = 0;
            var max = arr[i];
            var min = arr[i];

            for (i = 0; i < arr.Length; i++)
            {
                sum += (long)arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            maxsum = sum - (long)min;
            minsum = sum - (long)max;
            Console.WriteLine("{0} {1} ", minsum, maxsum);

        }
    }
}
