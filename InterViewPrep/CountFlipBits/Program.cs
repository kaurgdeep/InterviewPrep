using System;

namespace CountFlipBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountFlipBits(0b1010, 0b0010));        // should return 1
            Console.WriteLine(CountFlipBits(0b10010, 0b00100000));  // should return 3
            Console.WriteLine("Hello World!");
        }

        static int CountFlipBits(byte n1, byte n2)
        {
            var flipedBits = 0;
            byte n3 = (byte)(n1^n2);   // here n3 is equal to flipedbits by XOR operator for example 
            while(n3>0)           // 1010 ^ 0010 = 1000  (so it has 1 flip)
            {
                if((n3&1) == 1)
                {
                    flipedBits++;
                }

                n3 >>= 1;
            }

            return flipedBits;
        }
    }
}
