using System;
using System.Collections.Generic;

namespace IntToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(ToRoman(356));

        }

        static String ToRoman(int n)
        {
            int place = 1;
            int m = 0;
            int k = 0;
            int j = 0;
            String returnValue = "";

            while(n>0)
            {
                m = n / 10;
                k = m * 10;
                j = n - k;

                Console.WriteLine($"{j},{place}");
                var roman = lookUp(j, place);
                returnValue = roman + returnValue;
                n = m;
                place = place * 10;
            }
            
            return returnValue;
                
        }

        private static String lookUp(int j, int place)
        {
            var dict = new Dictionary<int, String>() { { 6, "VI" }, { 50, "L" }, { 300, "CCC" } };
            var number = j * place;
            return dict[number];
        }
    }
}
