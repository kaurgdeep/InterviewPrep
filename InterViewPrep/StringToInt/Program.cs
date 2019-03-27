using System;

namespace StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringToInt("1234"));
            Console.WriteLine("Hello World!");
        }

        static int StringToInt(string str)
        {
            int returnVal = 0;
            foreach(var c in str)
            {
                //int intVal = c - '0';
                //returnVal = (returnVal*10) + intVal;
                returnVal = returnVal * 10 + (c - '0');
            }
            return returnVal;
        }
    }
}
