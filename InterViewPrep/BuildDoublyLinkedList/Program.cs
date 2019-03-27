using System;

namespace BuildDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintList(BuildDoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }));
            Console.WriteLine("Hello World!");
        }

        static Node BuildDoublyLinkedList(int[] a)
        {
            Node headNode = null;
            Node Current = null;
            foreach(var val in a)
            {
                var newNode = new Node(val);
                newNode.prev = Current;
                if(headNode == null)
                {
                    headNode = newNode;
                }

                if(Current != null)
                {
                   
                    Current.next = newNode;
                    
                }
                Current = newNode;

            }
            return headNode;
        }

        static void PrintList(Node head)
        {
            while(head != null)
            {
                Console.Write("{0} <-> ", head.data);
                head = head.next;
            }
            
            Console.WriteLine("NULL");
        }
    }
}
