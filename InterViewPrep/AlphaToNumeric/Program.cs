//	1. Write a C# function that converts a given phone # from alpha to numeric:function: string alphaPhoneToNumeric(string alphaPhone)[For example:
//		Given "1-800-CALL-ATT", function should return "1-800-2255-288"
//		Given "1800CALLATT", function should return "18002255288"
//Given "18002233288", function should return "18002255288"



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlphaToNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphaToNumeric("Hello World!"));
            Console.WriteLine(AlphaToNumeric("1800CALLATT"));
            Console.WriteLine(AlphaToNumeric("1800HELLOWorld"));
            Console.WriteLine(AlphaToNumeric("HelloWorld!"));
        }
        static String AlphaToNumeric(String S)
        {
            S = S.ToUpper();
            var newString = new StringBuilder();
            foreach(var C in S)
            {
                //if( C>='A'&& C<='Z')
                {
                    var numValue = LookUp(C);
                    newString.Append(numValue);
                }
                //else
                //{
                //    newString.Append(C);
                //}
                
            }
            return newString.ToString();
        }

        private static Char LookUp(Char C)
        {
            var dict = new Dictionary<char, char>()
            { {'A', '2'}, {'B', '2'}, {'C', '2'}, {'D', '3'},{'E', '3'},
              {'F', '3'}, {'G', '4'}, {'H', '4'}, {'I', '4'},{'J', '5'},
              {'K', '5'}, {'L', '5'}, {'M', '6'}, {'N', '6'},{'O', '6'},
              {'P', '7'}, {'Q', '7'}, {'R', '7'}, {'S', '7'},{'T', '8'},
              {'U', '8'}, {'V', '8'}, {'W', '9'}, {'X', '9'},{'Y', '9'},{'Z', '9'}
            };
            if (dict.ContainsKey(C))
            {
                return dict[C];
            }
            return C;
        }
    }
}
