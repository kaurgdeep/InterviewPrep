using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        /* 1. without using reverse() method change string "Hello" to "olleh" in-place*/
        public static string reverseString(string str)
        {
            if (str == null || str.Length <= 1)
            {
                string msg = "Either String is empty or 1 char";
                Console.WriteLine(msg);
                return msg;
            }
            char[] chars = str.ToCharArray();
            int lastIndex = chars.Length - 1;
            /*This is a method to reverse a string 'in Place'*/
            for (int i = 0; i < lastIndex; i++)
            {
                char temp = chars[i];
                chars[i] = chars[lastIndex];
                chars[lastIndex] = temp;
                lastIndex--;
            }
            Console.WriteLine(chars);
            return new string(chars);

        }
        public static string stringToWordArray(string str)
        {
            string[] wordArray = str.Split(' ');
            foreach (string word in wordArray)
            {
                //char words = wordArray[word];
                Console.WriteLine(word);
            }
            //var newString = str.split(" ");
            int LastIndex = wordArray.Length - 1;
            for (int i = 0; i < LastIndex; i++)
            {
                string temp = wordArray[i];
                wordArray[i] = wordArray[LastIndex];
                wordArray[LastIndex] = temp;
                LastIndex--;

            }
            var reverseString = string.Join(" ", wordArray);
            Console.WriteLine(reverseString);
            return reverseString;
   
        }

        public static bool IsPalindrome(string str)
        {
            //str = new Regex("[^a-zA-Z]").Replace(str, "").ToLower();
            string LowerCaseStr = str.ToLower().Replace("[^0-9a-zA-Z]", "");
            //string remove = Regex.Replace(LowerCaseStr, "[^0-9a-zA-Z]+", "");
            char[] NewStr = LowerCaseStr.ToCharArray();
            //string[] NewStr = LowerCaseStr.Split();

            if (NewStr.Length <= 1)
            {
                return true;
            }
            int LastIndex = NewStr.Length - 1;
            for (var i = 0; i < LastIndex; i++)
            {
                if (NewStr[i] != NewStr[LastIndex])
                {
                    return false;
                }
                LastIndex--;
            }
            return true;
        }

        static void Main(string[] args)
        {
            IsPalindrome("Never odd or even");
            IsPalindrome("Red rum sir, is murder.");
            IsPalindrome("one two three");
            IsPalindrome("a");

        }
    }
}
