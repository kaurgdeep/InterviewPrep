//27. Given a number, return hexadecimal representation
//   string toHex(int n)
//   For example:
//Given: 1234, return "0x4d2" or "0x4D2"


using System;
using System.Collections.Generic;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecimalToHexadecimal(9)); // 9
            Console.WriteLine(DecimalToHexadecimal(256)); // 100
            Console.WriteLine(DecimalToHexadecimal(65));  // 41
            Console.WriteLine(DecimalToHexadecimal(34447)); // 868F
            Console.WriteLine(DecimalToHexadecimal(479)); // 1DF
            Console.WriteLine("Hello World!");
        }
        static string DecimalToHexadecimal(int n)
        {
            int q = 0;
            int r = 0;
            string retunValue = "";
            while (n >0)
            {
                q = n / 16;  // number divide by 16(because hexadecimal(hex=6 + decimal=10)) and get quotient
                r = n - (16 * q); // get remainder 
                if(r>=0 && r <= 9)
                {
                    retunValue = (char)(r +'0') + retunValue;
                }
                if(r>=10 && r <= 15)
                {
                    retunValue = (char)((r-10)+'A') + retunValue;
                }
                
                n = q;
            }
            return retunValue;
        }

    }
}
