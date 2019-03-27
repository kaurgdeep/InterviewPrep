//a.Given a binary representation, return the int value
//   int fromBinary(string binary)
//        For example:
//		Given: "0b10011010010" return 1234

using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(BinaryToDecimal("1010")); //10
            Console.Write(BinaryToDecimal("1010000")); //80
            Console.Write(BinaryToDecimal("00010010")); //18
            Console.WriteLine("Hello World!");
        }

        static double BinaryToDecimal(string str)
        {
            //int n = 0;
            //var convertedToInt = Int32.TryParse(str, out n);
            double multiply = 0;
            double addition = 0;
            int p = 0;
            double m = 0;
            int strlength = str.Length-1;
            for(var i=strlength; i>=0; i--)   // starting from LSB
            {
                m = Math.Pow(2, p);  // 2^p
                multiply = m * (str[i]-'0'); // str[i]-'0' = (char-char = num)
                addition += multiply;
                p++;

            }
            return addition;
        }
    }
}
