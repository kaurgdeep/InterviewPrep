using System;

namespace CountListWithCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = head.next.next.next;

            Console.WriteLine(CountListWithLoop(head));
            Console.WriteLine("Hello World!");
        }

        static int CountListWithLoop(Node node)
        {
            Node pointer1 = node;
            Node pointer2 = node;
            int count = 0;

            while(pointer1 != null && pointer2 != null)
            {
                pointer1 = pointer1.next;
                count++;
                pointer2 = pointer2.next.next;

                if(pointer1 == pointer2)
                {
                    return count;
                }
            }
            return count;
        }
    }
}
