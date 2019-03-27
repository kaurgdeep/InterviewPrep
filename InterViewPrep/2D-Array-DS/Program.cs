//HackerRank https://www.hackerrank.com/challenges/2d-array
// read article to understand 2D array https://www.cs.cmu.edu/~mrmiller/15-110/Handouts/arrays2D.pdf

using System;

namespace _2D_Array_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = {{ 1, 1, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0, 0 },{0, 9, 2, -4, -4, 0 },{0, 0, 0, -2, 0, 0 },{0, 0, -1, -2, -4, 0 }}; // how to intialize
            Console.WriteLine(hourglassSum(arr)); 
            Console.WriteLine("Hello World!");
        }

        static int hourglassSum(int[][] arr)
        {
            //var newarr = new int[arr.Length-1][arr[0].Length-1]; // don't need new arr
            var largeSum = Int32.MinValue;
            for (var row = 0; row < arr.Length - 2; row++)
            {
                for (var col = 0; col < arr[0].Length - 2; col++)
                {
                    //newarr[col,row]
                    var sum = arr[row][col] + arr[row][col + 1] + arr[row][col + 2] +
                                        arr[row + 1][col + 1] +
                            arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];
                    if (sum > largeSum)
                    {
                        largeSum = sum;
                    }

                }
            }
            // for(var i=0; i<newarr.Length; i++)
            // {
            //     for(var j=0; i<newarr[0].Length; j++)
            //     {
            //         if(newarr[i]>largeSum)
            //         largeSum = newarr[i];
            //     }
            // }
            return largeSum;
        }
    
    }
}
