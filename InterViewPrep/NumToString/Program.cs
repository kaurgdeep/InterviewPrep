using System;

namespace NumToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumToString(1234));
            Console.WriteLine("Hello World!");
        }
        static String NumToString(int n)
        {
            if(n>0)
            {
                var m = n / 10;
                var k = m * 10;
                var j = n - k;
                var r = NumToString(m) + (Char)(j + '0'); // 48 is ascii table value for zero. converting int j to character.

                return r;
            }
            return "*";
        }

        
    }
}
