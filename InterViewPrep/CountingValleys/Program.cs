//  https://www.hackerrank.com/challenges/counting-valleys
// counting valleys hacker rank
// watch video for explanation https://www.youtube.com/watch?v=MMmFELo0QjM

using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountingValleys(12, "DDUUDDUDUUUD"));
            Console.WriteLine(CountingValleys(8, "UDDDUDUU"));
            Console.WriteLine(CountingValleys(13, "DDUUUUDDDUUUU"));
            Console.WriteLine("Hello World!");
        }

        static int CountingValleys(int n, string s)
        {
            var countValley = 0;
            var altitude = 0;   // if altitude is zero means Garry is at sea level.
            foreach(var c in s)
            {
                if (c == 'U')    // Only care about upsteps because we count valleys
                {
                    altitude++;
                }
                else
                {
                    altitude--;
                }
                if(c == 'U' && altitude == 0)   // altitude == 0 && 'U' means upstep and touch sea level.
                {
                    countValley++;
                }
            }
            return countValley;
        }
    }
}
