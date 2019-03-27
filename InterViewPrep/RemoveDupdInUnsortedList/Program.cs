//a.Remove duplicate nodes from an unsorted singly-linked listFor example:
//Given: e -> b -> e -> a -> c -> e -> f -> a 
  //  Return: e -> b -> a -> c -> f
  // use Dictionary

using System;
using System.Collections.Generic;

namespace RemoveDupdInUnsortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = BuildList(new char[] { 'd', 'b', 'c', 'c', 'e', 'f', 'd' });
            var list2 = BuildList(new char[] { 'a', 'b', 'c','a' });
            var list3 = BuildList(new char[] { 'e', 'b','e','a','c','e','f','a' });
            var list4 = BuildList(new char[] { 'a' });
            Print(list1);
            Print(list2);
            Print(list3);
            Print(list4);
            Console.WriteLine("**************PairWiseRevese****************");
            Print(RemoveDupsInUnsortedList(list1));
            Print(RemoveDupsInUnsortedList(list2));
            Print(RemoveDupsInUnsortedList(list3));
            Print(RemoveDupsInUnsortedList(list4));
            Console.WriteLine("Hello World!");
        }

        static Node RemoveDupsInUnsortedList(Node head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            Node current = head;
            var dict = new Dictionary<char, char>();
            Node newhead = null;
            Node prev = null;
            while (current != null) //&& current.next != null) //don't need to check current.next if
            {                                                         // we are checking right after assign it.
                //if (dict.ContainsKey(current.data))
                //{
                //    current = current.next;
                //}
                //dict.Add(current.data, current.data);
                //current = current.next;
                if (!dict.ContainsKey(current.data))
                {
                    dict.Add(current.data, current.data); // better way to not repeat code
                }
                current = current.next;
            }

            foreach (var val in dict)
            {
                var newNode = new Node(val.Value);
                if (newhead == null)
                {
                    newhead = newNode;

                }
                if (prev != null)
                {
                    prev.next = newNode;

                }
                prev = newNode;
                
            }

            return newhead;
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
