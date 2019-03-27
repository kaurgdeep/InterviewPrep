using System;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[]{ 1, 2, 3, 4, 5};
            Console.Write(LeftRotation(a, 4));
            Console.WriteLine("Hello World!");
        }

        static int[] LeftRotation(int[]a, int d)
        {
            var arr2 = new int[a.Length];
            var j = 0;
            for (var i = d; i < a.Length; i++)
            {
                arr2[j] = a[i];
                j++;
            }
            for (var i = 0; i < d; i++)
            {
                arr2[j] = a[i];
                j++;
            }
            return arr2;
        

        //var temp = 0;

        //    for(var i = a.Length-1; i<d; i--)
        //    {
        //        temp = a[i - 1];
        //        a[i - 1] = a[i];                 //not working
        //        a[i] = temp;
        //    }

        //return a;
        }
    }
}
