using System;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            NewYearChaos(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }); // 7 swaps.
            NewYearChaos(new int[] { 2, 1, 5, 3, 4});  // 3 swaps.
            NewYearChaos(new int[] { 2, 5, 1, 3, 4 });  // 3 swaps.
        }

        static void NewYearChaos(int[] q)
        {
            var temp = 0;
            var lastPerson = q.Length;
            var totalswaps = 0;
            var swaps = 0;
            while(lastPerson>0)
            {
                while (lastPerson > 0 && q[lastPerson - 1] == lastPerson)
                {
                    lastPerson--;
                    swaps = 0;
                }
                for (var j=lastPerson-1; j>=0; j--)
                {
                    if (q[j] == lastPerson)
                    {
                        temp = q[j + 1];
                        q[j + 1] = q[j];
                        q[j] = temp;
                        printArr(q);
                        totalswaps++;
                        swaps++;
                        if(swaps>2)
                        {
                            Console.WriteLine("Too chaotic");
                            return;
                        }
                        
                        break;
                    }
                }
            }
            Console.WriteLine(totalswaps);

        }

        private static void printArr(int[] q)
        {
            for(var i=0; i<q.Length; i++)
            {
                Console.Write("{0} ", q[i]);
            }
            Console.WriteLine();
        }
    }
}
