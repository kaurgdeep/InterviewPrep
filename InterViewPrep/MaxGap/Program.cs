using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGap
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxGap(561892));
            //Console.WriteLine(MaxGap(9));
            //Console.WriteLine(MaxGap(20));
            //Console.WriteLine(MaxGap(15));
            //Console.WriteLine(MaxGap(32));
            //Console.WriteLine(MaxGap(0xFFF));
        }

        public static int MaxGap(int i)
        {
            bool SawOne = false;
            int MaxZeros = 0;
            int CountZero = 0;

            while(i>0)
            {
                if ((i & 1) == 0)
                {
                    if(SawOne)
                    {
                        CountZero++;
                    }
                }
                else
                {
                    SawOne = true;
                    if(CountZero>MaxZeros)
                    {
                        MaxZeros = CountZero;
                        
                    }
                    CountZero = 0;
                }

                i = i >> 1;
            }

            return MaxZeros;

        }
    }
}
