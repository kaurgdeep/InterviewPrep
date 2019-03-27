//a.Given a hexadecimal number representation, return the int value
//        int fromHex(string hex)
//        For example:
//		Given: "0x4D2" return 1234

using System;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HexadecimalToDecimal("4D2"));
            Console.WriteLine("Hello World!");
        }
        static double HexadecimalToDecimal(string str)
        {
            double multiply = 0;
            double addition = 0;
            int p = 0;
            double m = 0;
            int strlength = str.Length - 1;
            for (var i = strlength; i >= 0; i--)   // starting from LSB
            {
                m = Math.Pow(16, p);  // 16^p
                if (str[i] >= '0' && str[i] <= '9')
                {
                    multiply = m * (int)(str[i] - '0'); // str[i]-'0' = (char-char = num)
                }
                if (str[i] >= 'A' && str[i] <= 'F')
                {
                    multiply = m * (int)((str[i] + 10) - 'A');
                }
                //multiply = m * (str[i] - '0'); // str[i]-'0' = (char-char = num)
                addition += multiply;
                p++;

            }
            return addition;
        }
    }
}
