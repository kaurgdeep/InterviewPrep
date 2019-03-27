//https://www.hackerrank.com/challenges/diagonal-difference

using System;

namespace DigonalDifference2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello World!");
        }

        static int diagonalDifference(int[][] arr)
        {
            var sumA = 0;
            var sumB = 0;
            var defference = 0;
            var j = arr.Length - 1;
            for (var i = 0; i < arr.Length; i++)
            {
                sumA += arr[i][i];
                sumB += arr[i][j];
                j--;

            }
            defference = Math.Abs(sumA - sumB);
            return defference;
        }

    }
}
