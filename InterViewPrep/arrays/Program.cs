using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class A{
        public int i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var i = 2;
            incr(ref i);
            Console.WriteLine(i);
            var a = new A();
            a.i = 10;
            incr(a);
            Console.WriteLine(a.i);
        }

        private static void incr(ref int i)
        {
            i++;
        }

        private static void incr(A a)
        {
            a.i++;
        }
    }
}
