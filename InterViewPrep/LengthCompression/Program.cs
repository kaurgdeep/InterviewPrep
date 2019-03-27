//13. Compress consecutive characters in a string in O(n). This is called run length encoding(RLE) compression.
//  For example: 
//Given: "AAABBCCCDEEEEFG" return "3ABB3CDD4EFG"


using System;
using System.Text;

namespace LengthCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompressChars("AAABC"));
            Console.WriteLine("Hello World!");
        }

        static string CompressChars(string str)
        {
            var newString = new StringBuilder();
            char prevChar = '\0';
            int count = 1;
            foreach(var c in str)
            {
                if(prevChar == c)
                {
                    count++;
                }
                else if(prevChar != '\0')
                {
                    newString.Append(count);
                    newString.Append(prevChar);
                    count = 1;
                   
                }

                prevChar = c;
            }
            newString.Append(count);
            newString.Append(prevChar);
            return newString.ToString();
        }
    }
}
