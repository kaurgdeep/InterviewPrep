using System;

namespace CountList
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 6, 8, 9, 10, 11, 56, 100 };
            Node head = null;
            Node prevNode = null;
            foreach (var d in data)
            {
                var node = new Node(d);
                if (head == null)
                {
                    head = node;
                }
                if (prevNode != null)
                {
                    prevNode.next = node;
                }
                prevNode = node;
            }

            var newhead = CountList(head);
            Console.WriteLine(newhead);

            //Node head = new Node(1);
            //head.next = new Node(2);
            //head.next.next = new Node(3);
            //head.next.next.next = new Node(4);
            //head.next.next.next.next = new Node(5);

            //Console.WriteLine(CountList(head));

        }

        static int CountList(Node node)
        {
            var count = 0;
            var currentNode = node;
            while(currentNode != null)
            {
                count++;
                currentNode = currentNode.next;
               
            }

            return count;
        }
    }
}
