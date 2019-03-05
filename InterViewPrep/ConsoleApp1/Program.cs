//	2. Write a C# function that converts a Roman numeral into its numeric equivalentFunction: int fromRoman(string roman)
//	Roman numerals are represented by combinations of letters from the Latin alphabet.Roman numerals, as used today, employ seven symbols, each with a fixed integer value, as follows:
	
//	Symbol  I   V   X   L   C   D   M

//   Value   1   5   10  50  100 500 1, 000For example:
//		Given "XXXIX", function should return 39
//Given "MLXVI", function should return 1066


using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("XXXIX"));
            Console.WriteLine(RomanToInt("MLXVI"));
            Console.WriteLine(RomanToInt("VIII"));
            Console.WriteLine("Hello World!");
        }

        static int RomanToInt(String S)
        {
            int length = S.Length - 1;
            int prev = 0;
            int returnVal = 0;

            for( var i=length; i>=0; i--)
            {
                int Value = LookUp(S[i]);
                if(Value<prev)
                {
                    Value = -Value;

                }

                returnVal += Value;
                prev = Math.Abs(Value);

            }
            return returnVal;

        }

        private static int LookUp(char v)
        {
            var dict = new Dictionary<Char, int>()
            { { 'I', 1},{ 'V', 5}, { 'X', 10}, { 'L', 50}, { 'C', 100}, { 'D', 500}, { 'M', 1000}, };

            return dict[v];
        }
    }
}
