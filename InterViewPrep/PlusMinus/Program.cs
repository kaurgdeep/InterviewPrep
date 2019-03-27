//https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings

using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            plusMinus(new int[] { -4, 3, -9, 0, 4, 1 });
            Console.WriteLine("Hello World!");
        }
        static void plusMinus(int[] arr)
        {
            int countPositive = 0;
            int countNegative = 0;
            int countzero = 0;
            float pRatio = 0;
            float nRatio = 0;
            float zRatio = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    countPositive++;
                }

                if (arr[i] < 0)
                {
                    countNegative++;
                }

                if (arr[i] == 0)
                {
                    countzero++;
                }
            }
            pRatio = (float)countPositive / (float)arr.Length;
            nRatio = (float)countNegative / (float)arr.Length;
            zRatio = (float)countzero / (float)arr.Length;
            float truncated = (float)(Math.Truncate((double)pRatio * 1000000.0) / 1000000.0);

            //Console.WriteLine("{0:0.000000} {1:0.000000} {2:0.000000}", pRatio, nRatio, zRatio); //format specifier, 
            Console.WriteLine("{0:0.000000}", pRatio); //format specifier, 
            Console.WriteLine("{0:0.000000} ", nRatio); //print on deferent line
            Console.WriteLine("{0:0.000000}", zRatio);
        }
    }
}
