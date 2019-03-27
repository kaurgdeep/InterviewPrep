//26. Given a number, convert it to string
//   string toString(int n)
//   For example:
//Given: 1234, return "1234"


using System;

namespace IntToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToString(12345));
            Console.WriteLine("Hello World!");
        }
        static string IntToString(int n)
        {
            int m = 0;
            int j = 0;
            int k = 0;
            string returnString = "";
            
            while(n>0)
            {
                m = n / 10;
                j = m * 10;
                k = n - j;
                returnString = (char)(k+'0') + returnString;
              
                n = m;
            }
      
            return returnString;
        }
    }
}
