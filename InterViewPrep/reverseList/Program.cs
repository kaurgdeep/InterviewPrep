using System;
using System.Collections.Generic;

namespace reverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node head = new Node(1);
            //head.next = new Node(2);
            //head.next.next = new Node(3);
            //head.next.next.next = new Node(4);

            var data = new int[] { 1, 2, 3, 6, 8, 9, 10, 11, 56, 100 };
            Node head = null;
            Node prevNode = null;
            foreach(var d in data)
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

            printList(head);

            Console.WriteLine("Reversing list");

            var newhead = reverseListStack(head);
            printList(newhead);
        

        }

        static Node reverseList(Node node)
        {
            Node currentNode = node;
            Node next = null;
            Node prev = null;

            while(currentNode != null)
            {
                next = currentNode.next;   // storing currentNode.next in next.
                currentNode.next = prev;  //
                prev = currentNode;
                currentNode = next;

            }

            return prev;

        }

        static Node reverseListRecursion(Node head)
        {
            if(head == null)  
        { 
            return head; 
        } 
  
        // last node or only one node 
        if(head.next == null)  
        { 
            return head; 
        } 
  
        Node newHeadNode = reverseListRecursion(head.next); 
  
        // change references for middle chain 
        head.next.next = head; 
        head.next = null; 
  
        // send back new head  
        // node in every recursion 
        return newHeadNode; 
        }

        static Node reverseListStack(Node node)
        {
            var current = node;
            Node head = null;
            Node prev = null;
            var stk = new Stack<Node>();
            while(current != null)
            {
                stk.Push(current);
                current = current.next;
            }

            while (stk.Count != 0)
            {
                current = stk.Pop();
                if(head == null)
                {
                    head = current;
                }
                if(prev != null)
                {
                    prev.next = current;
                }
                prev = current;
            }
            current.next = null;
            return head;
        }

        static void printList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }
}
