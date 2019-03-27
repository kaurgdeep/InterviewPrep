//	15. Remove consecutive duplicate characters from a string
//    For example:
//	Given "aabbaa", return "aba"
//	Given "aaabbcc", return "abc"
//Given "abc", return "abc"

using System;
using System.Text;

namespace RemoveConsecutiveDups
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDups("aaabbc"));
            Console.WriteLine("Hello World!");
        }

        static string RemoveDups(string str)
        {
            var newString = new StringBuilder();
            char prevChar = '\0';
            foreach(var c in str)
            {
                if(c != prevChar)
                {
                    newString.Append(c);
                    prevChar = c;
                }
            }
            return newString.ToString();
        }
    }
}
