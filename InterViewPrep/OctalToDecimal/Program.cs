//a.Given an octal representation, return the int value
//        int fromOctal(string octal)
//        For example:
//		Given: "2322" return 1234



using System;

namespace OctalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OctalToDecimal("2322"));
            Console.WriteLine("Hello World!");
        }

        static double OctalToDecimal(string str)
        {
            double multiply = 0;
            double addition = 0;
            int p = 0;
            double m = 0;
            int strlength = str.Length - 1;
            for (var i = strlength; i >= 0; i--)   // starting from LSB
            {
                m = Math.Pow(8, p);  // 8^p 8because octal
                multiply = m * (str[i] - '0'); // str[i]-'0' = (char-char = num)
                addition += multiply;
                p++;

            }
            return addition;
        }

    }
}
