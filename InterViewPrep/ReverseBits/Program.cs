using System;

namespace ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ReverseBits(0b1000101));
            Console.WriteLine("Hello World!");
        }
        static byte ReverseBits(byte b)
        {
            var reverseBits = (byte)0;
            while (b > 0)
            {
                //byte getLsb = (byte)(b & 1);             // (b&1) is picking the lsb(last significant bit)
                //reverseBits |= getLsb;                  //
                reverseBits |= (byte)(b & 1); 
                reverseBits <<= 1;
                b >>= 1;

            }
            return reverseBits;
        }
    }
}
