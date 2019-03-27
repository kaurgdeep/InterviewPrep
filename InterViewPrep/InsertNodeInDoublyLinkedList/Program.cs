using System;

namespace InsertNodeInDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = BuildDoublyLinkedList(new int[] { 1, 2, 3,5 });
            PrintList(list1);
            PrintList(sortedInsert(list1, 4));
            
            Console.WriteLine("Hello World!");
        }

        static Node sortedInsert(Node head, int data)
        {

            Node current = head;
            Node prev = null;
            var newNode = new Node(data);
            while(current != null)
            {
                if (head == null)
                {
                    head = newNode;
                    return head;
                }

                if (current.data > newNode.data)
                {
                    prev = current.prev;
                    current.prev = newNode;
                    newNode.next = current;
                    newNode.prev = prev;
                    prev.next = newNode;
                }
                current = current.next;
            }
            
            
            return head;
        }

        static Node BuildDoublyLinkedList(int[] a)
        {
            Node headNode = null;
            Node Current = null;
            foreach (var val in a)
            {
                var newNode = new Node(val);
                newNode.prev = Current;
                if (headNode == null)
                {
                    headNode = newNode;
                }

                if (Current != null)
                {

                    Current.next = newNode;

                }
                Current = newNode;

            }
            return headNode;
        }

        static void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write("{0} <-> ", head.data);
                head = head.next;
            }

            Console.WriteLine("NULL");
        }
    }
}
