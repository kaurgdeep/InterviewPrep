using System;

//Failing program:

//    static long repeatedString(string s, long n)
//{
//    // if s == "a"
//    if (s == "a")
//    {
//        return n;
//    }

//    // else
//    var noOfRepeats = (n / s.Length) + 1;
//    // s = "abcac", n = 10
//    // noOfRepeats = (10 / 5) + 1 = 3

//    var newString = "";
//    for (var i = 0; i < noOfRepeats; i++) // 0, 1, 2
//    {
//        newString += s;
//        // i = 0 "abcac"
//        // i = 1 "abcacabcac"
//        // i = 2 "abcacabcacabcac" <<< s.length > 10
//    }
//    // trim the length
//    newString = newString.Substring(0, (int)n);

//    var noOfAs = 0;
//    foreach (var c in newString)
//    {
//        if (c == 'a')
//        {
//            noOfAs++;
//        }
//    }
//    return noOfAs;
//}

// Pseudo-code:

//s = "aba" // 2 'as
//n = 10


//var noOfAs;
//// todo: find # of a's in S

//int noOfRepeats = n / s.length = 10 / 3 = 3;

//// # of a's in s = noOfRepeats * noOfAs;
//noOfAs = noOfRepeats* noOfAs; // = 6


//int reminder = n - (s.length * 3);
//// 10 - (3 * 3)

//var reminderStr = s.Substring(0, reminder);
//// count # of a's in reminderStr

//// add a's in reminderStr to noOfAs

//return noOfAs;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedString("aba", 10));
            Console.WriteLine("Hello World!");
        }

        static int RepeatedString(string s, long n)
        {
            var aInS = 0;
            var aInRepeatedS = 0;
            var aInRemainderS = 0;
            var totalAs = 0;
            var nOfRepeatation = 0;
            var remainder = 0;
            var remainderString = "";
            foreach (var c in s)
            {
                if (c == 'a')
                {
                    aInS++;
                }
            }

            nOfRepeatation = (int) n / s.Length;
            aInRepeatedS = aInS * nOfRepeatation;
            remainder = (int)n - (s.Length * nOfRepeatation);
            remainderString = s.Substring(0, remainder);
            foreach(var c in remainderString)
            {
                if (c == 'a')
                {
                    aInRemainderS++;
                }
            }
            totalAs = aInRepeatedS + aInRemainderS;
            return totalAs;
        }
    }
}
