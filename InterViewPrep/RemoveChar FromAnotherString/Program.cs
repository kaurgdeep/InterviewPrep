	//10. Remove all occurrences of characters from the 2nd string from the 1st string
 //   string strChr(string s, string t)

 //   For example: strChr("hello world", "ld") => "heo wor"(all instances of l and d are removed)strChr("hello word", "abc") => "hello world"


using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveChar_FromAnotherString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveChar("hello world", "ed"));
            Console.WriteLine(removeChars("hello world", "ed"));
            Console.WriteLine("Hello World!");
        }

        static string RemoveChar(string str1, string str2)
        {
            // analysis runtime = o(n) * o(n) = O(n^2)
            //memory = o(n)   not a efficient solution because 2 forloops its o(n^2)
            var newString = new StringBuilder();
            
            foreach(var c in str1)
            {
                var found = false;                    
                foreach (var r in str2)
                {
                    if(c == r)
                    {
                        found = true;
                        break;
                    }
                }
                if(found == false)
                {
                    newString.Append(c);
                }
            }
            return newString.ToString();
        }

        static string removeChars(string str1, string str2)
        {
            // This solution is more efficient than previous one
            // because runtime = o(n) + o(n) = o(2n) = o(n) dop 2 because its constant
            // memory = o(n)+o(n) = o(2n) = o(n) dop 2 because its constant
            var dict = new Dictionary<char, bool>();
            var newString = new StringBuilder();
            foreach(var r in str2)
            {
                dict[r] = true; // adding to th dictionary with value
            }
            foreach(var c in str1)
            {
                if(dict.ContainsKey(c) == false)
                {
                    newString.Append(c);
                }
            }
            return newString.ToString();
        }
    }


}
