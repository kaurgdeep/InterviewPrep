using System;

namespace BuildList
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintList(BuildList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            PrintList(BuildList(new int[] { }));
            PrintList(BuildList(new int[] { 9,8,7,6,5,4 }));
            PrintList(BuildList(new int[] { 1, 6,7,9,10 }));
            Console.WriteLine("Hello World!");
        }
        static Node BuildList(int[] a)
        {
            Node headNode = null;
            Node prev = null;
            foreach(var data in a)
            {
                var newNode = new Node(data);
                if(headNode == null)
                {
                    headNode = newNode;
                }
                if(prev != null)
                {
                    prev.next = newNode;
                }
                prev = newNode;
            }
            return headNode;
        }

        static void PrintList(Node headNode)
        {
            while(headNode != null)
            {
                Console.Write("{0} ->", headNode.data);
                headNode = headNode.next;
            }
            Console.WriteLine();
            
        }
    }
}
