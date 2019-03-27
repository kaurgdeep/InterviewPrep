//28. Given a number, return binary representation
//   string toBinary(int n)
//   For example:
//Given: 1234, return "0b10011010010"

using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecimalToBinary(10));
            Console.WriteLine(DecimalToBinary(100));
            Console.WriteLine(DecimalToBinary(128));
            Console.WriteLine(DecimalToBinary(256));
            Console.WriteLine(DecimalToBinary(4));
            Console.WriteLine("Hello World!");
        }

        static string DecimalToBinary(int n)
        {
            int q = 0;
            int r = 0;
            string retunValue = "";
            while(n>0)
            {
                q = n / 2;                //get Quotient bt dividing number by diviser 2(binary)
                r = n - (2 * q);          //get remainder by substracting (2*quotient) fron number
                retunValue = (char)(r+'0') + retunValue;          //adding remainder 
                n = q;
            }
            return retunValue; 
        }
    }
}
