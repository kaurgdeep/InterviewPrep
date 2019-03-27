//https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-lis

using System;

namespace InsertNodeAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = BuildList(new int[] { 1, 2, 3, 4, 5, 6 });
            var head = insertNodeAtPosition(node1, 10, 3);
            PrintList(head);
            Console.WriteLine("Hello World!");
        }

        static Node BuildList(int[] a)
        {
            Node headNode = null;
            Node current = null;
            foreach (var data in a)
            {
                var newNode = new Node(data);
                if (headNode == null)
                {
                    headNode = newNode;
                }
                if (current != null)
                {
                    current.next = newNode;
                }
                current = newNode;
            }
            return headNode;
        }

        static Node insertNodeAtPosition(Node head, int data, int position)
        {
            var current = head;
            Node next = null;
            var count = 0;
            while (count < position-1) //position-1 because position is 0 index base.
            {
                current = current.next;
                count++;
            }
            var newnode = new Node(data);
            next = current.next;
            current.next = newnode;
            newnode.next = next;
            return head;

        }

        static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write("{0} ->", node.data);
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
