//https://www.hackerrank.com/challenges/compare-the-triplets

using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() { 17, 28, 30 };
            var b = new List<int>() { 99, 16, 8 };
            PrintList(compareTriplets(a, b));
            Console.WriteLine("Hello World!");
        }
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var newList = new List<int>();
            var asum = 0;
            var bsum = 0;
            for (var i = 0; i < a.Count; i++)
            {

                if (a[i] > b[i])
                {
                    asum += 1;
                }
                if (a[i] < b[i])
                {
                    bsum += 1;
                }
                // if(a[i]==b[j])
                // {
                //     break;
                // }


            }
            newList.Add(asum);
            newList.Add(bsum);
            return newList;

        }

        static void PrintList(List<int> list)
        {
            foreach (var n in list)
            {
                Console.Write("{0}, ", n);
            }
            Console.WriteLine();
        }
    }
}
