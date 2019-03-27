//	29. Given a number, return octal representation
//    string toOctal(int n)
//    For example:
//	Given: 1234 return "2322"
//Note: There is no special representation for octal in C#- like "0x" is used for hexadecimal.


using System;

namespace DecimalToOctal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecimalToOctal(9)); // 11
            Console.WriteLine(DecimalToOctal(256)); // 400
            Console.WriteLine(DecimalToOctal(65));  //  101
            Console.WriteLine(DecimalToOctal(34447)); // 103217
            Console.WriteLine(DecimalToOctal(479)); //  737
            Console.WriteLine("Hello World!");
        }

        static string DecimalToOctal(int n)
        {
            int q = 0;
            int r = 0;
            string retunValue = "";
            while (n > 0)
            {
                q = n /8;
                r = n - (8 * q);
                retunValue = (char)(r+'0') + retunValue;
                n = q;
            }
            return retunValue;
        }


    }
}
