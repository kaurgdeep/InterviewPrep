using System;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(simpleArraySum(new int[] { 1, 2, 3, 4, 5 })); //15
            Console.WriteLine("Hello World!");
        }
        static int simpleArraySum(int[] ar)
        {
            var sum = 0;
            for (var i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
