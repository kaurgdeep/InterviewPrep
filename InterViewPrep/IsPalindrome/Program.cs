using System;
using System.Collections.Generic;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = BuildList(new char[] { 'd', 'b', 'c', 'c', 'b', 'd' });
            var list2 = BuildList(new char[] { 'a', 'b', 'c', 'a' });
            var list3 = BuildList(new char[] { 'a', 'b', 'c', 'd', 'd', 'c', 'b', 'a' });
            var list4 = BuildList(new char[] { 'a'});
            Print(list1);
            Print(list2);
            Print(list3);
            Print(list4);
            Console.WriteLine("**************PairWiseRevese****************");
            IsPalindrome(list1);
            IsPalindrome(list2);
            IsPalindrome(list3);
            IsPalindrome(list4);
            Console.WriteLine("Hello World!");
        }
        static bool IsPalindrome(Node head)
        {
            if(head == null || head.next == null)
            {
                Console.WriteLine("FALSE");
                return false;
            }
            var current = head;
            var stk = new Stack<char>();
            while(current != null)
            {
                stk.Push(current.data);
                current = current.next;
            }

            while (stk.Count != 0)
            {
                var val = stk.Pop();
                if(val != head.data)
                {
                    Console.WriteLine("false");
                    return false;
                }
                head = head.next;
            }
            Console.WriteLine("IsPalindrome");
            return true;
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

        static void Print(Node headNode)
        {
            while (headNode != null)
            {
                Console.Write("{0} ->", headNode.data);
                headNode = headNode.next;
            }
            Console.WriteLine("NULL");

        }
    }
}
