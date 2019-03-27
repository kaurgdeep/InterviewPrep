using System;

namespace MergeTwoList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var node1 = BuildList(new int[] { 1, 2, 3, 4, 5, 6 });
            var node2 = BuildList(new int[] { 2, 2, 4, 5, 5, 6,7,8 });
            var node3 = MergeSortedList(node1, node2);
            PrintList(node3);

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

        
        static Node MergeSortedList(Node node1, Node node2)
        {
            Node headNode3 = null;
            Node prevNode3 = null;
            while(node1 != null && node2 != null)
            {
                 while (node1 != null && node2 != null && node1.data <= node2.data)
            {
                var node3 = new Node(node1.data);
                if (headNode3 == null)
                {
                    headNode3 = node3;
                }
                if(prevNode3 != null)
                {
                    prevNode3.next = node3;
                }
                prevNode3 = node3;
                node1 = node1.next;
                
            }

            while (node1 != null && node2 != null && node2.data <= node1.data)
            {
                var node3 = new Node(node2.data);
                if (headNode3 == null)
                {
                    headNode3 = node3;
                }
                if (prevNode3 != null)
                {
                    prevNode3.next = node3;
                }
                prevNode3 = node3;
                node2 = node2.next;

            }
            }
           

            while(node1 == null && node2 != null)
            {
                var node3 = new Node(node2.data);
                if (headNode3 == null)
                {
                    headNode3 = node3;
                }
                if (prevNode3 != null)
                {
                    prevNode3.next = node3;
                }
                prevNode3 = node3;
                node2 = node2.next;
            }

            while (node2 == null && node1 != null)
            {
                var node3 = new Node(node1.data);
                if (headNode3 == null)
                {
                    headNode3 = node3;
                }
                if (prevNode3 != null)
                {
                    prevNode3.next = node3;
                }
                prevNode3 = node3;
                node1 = node1.next;
            }
            return headNode3;
        } 
        
        static void PrintList(Node node)
        {
            while(node != null)
            {
                Console.Write("{0} ->", node.data);
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
