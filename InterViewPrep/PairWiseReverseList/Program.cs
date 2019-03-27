//	9. Pair-wise reverse singly-linked list. 
//For example: Given a singly-linked list: a -> b -> c -> d -> e -> f 
// Return: b -> a -> d -> c -> f -> e


using System;

namespace PairWiseReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = BuildList(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g'});
            var list2 = BuildList(new char[] { 'a', 'b', 'c' });
            var list3 = BuildList(new char[] { 'a', 'b'});
            var list4 = BuildList(new char[] { 'a'});
            Print(list1);
            Print(list2);
            Print(list3);
            Print(list4);
            Console.WriteLine("**************PairWiseRevese****************");
            Print(PairWiseReverseList(list1));
            Print(PairWiseReverseList(list2));
            Print(PairWiseReverseList(list3));
            Print(PairWiseReverseList(list4));
            Console.WriteLine("Hello World!");
        }

        static Node BuildList(char[] a)
        {
            Node headNode = null;
            Node prev = null;
            foreach (var data in a)
            {
                var newNode = new Node(data);
                if (headNode == null)
                {
                    headNode = newNode;
                }
                if (prev != null)
                {
                    prev.next = newNode;
                }
                prev = newNode;
            }
            return headNode;

        }
        static Node PairWiseReverseList(Node head)
        {
            Node next = null;
            if(head == null || head.next == null)
            {
                return head;
            }

            Node prev = head;
            Node current = head.next;
            Node newHead = current;

            //newHead = current;
            while(prev != null && current != null)
            {

                next = current.next; //c
                current.next = prev; // a
                
                if (next == null || next.next == null)
                {
                    prev.next = next;
                    break;
                }

                prev.next = next.next; // d
                prev = next; //c
                current = prev.next; // d
                
                

            }


            return newHead;
        }

        static void Print(Node head)
        {
            while(head != null)
            {
                Console.Write("{0} -> ", head.data);
                head = head.next;
            }
            Console.WriteLine("null");
        }
    }
}
