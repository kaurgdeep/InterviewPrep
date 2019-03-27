//https://www.hackerrank.com/challenges/birthday-cake-candles

using System;

namespace birthdayCakeCandle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(birthdayCakeCandles(new int[] { 3, 2, 1, 3 }));
            Console.WriteLine(birthdayCakeCandles(new int[] { 18, 90, 90, 13, 90, 75, 90, 8, 90, 43}));
            Console.WriteLine("Hello World!");
        }

        static int birthdayCakeCandles(int[] ar)
        {
            var maxHeight = ar[0]; 
            var candles = 1; // candles = 1 because we assign maxHeiht to arr[0] already to do comparison
            for (var i = 1; i < ar.Length; i++)
            {
                if (ar[i] == maxHeight)      //put comparison of a[i] and maxHeight first 
                {                            // otherwise it will set set new maxheight with candle 1 
                    candles++;               //and then do candles++ again.
                }
                if (ar[i] > maxHeight)
                {
                    maxHeight = ar[i];
                    candles = 1;
                }

                //if (ar[i] > maxHeight)
                //{
                //    maxHeight = ar[i];
                //    candles = 1;
                //}
                                                 //Will fail if ar[1] would be greater than maxHeight.
                //if (ar[i] == maxHeight)      
                //{                            
                //    candles++;              
                //}

            }
            return candles;

        }
    }
}
