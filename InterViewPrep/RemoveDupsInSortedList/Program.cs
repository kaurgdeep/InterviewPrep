using System;

namespace RemoveDupsInSortedList
{
    class Program
    {
        static void Main(string[] args)
        {

            var list1 = BuildList(new char[] { 'a', 'a', 'c', 'd', 'e', 'f', 'g' });
            var list2 = BuildList(new char[] { 'a', 'a', 'b', 'c', 'd', 'd' });
            var list3 = BuildList(new char[] { 'a', 'b','b','b','c' });
            var list4 = BuildList(new char[] { 'a','a' });
            Print(list1);
            Print(list2);
            Print(list3);
            Print(list4);
            Console.WriteLine("**************revese****************");
            Print(RemoveDups(list1));
            Print(RemoveDups(list2));
            Print(RemoveDups(list3));
            Print(RemoveDups(list4));
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


        static Node RemoveDups(Node node)
        {
            if(node == null || node.next == null)
            {
                return node;

            }

            var current = node;
            var next = current.next;

            while(current != null && next != null)
            {
                while(current != null && next != null && current.data != next.data)
                {
                    current = next;
                    next = current.next;
                }

                while(current != null && next != null && current.data == next.data)
                {
                    current.next = next.next;
                    next = current.next;

                }

            }
            return node;
        }

       
        static void Print(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data);
                head = head.next;
            }
            Console.WriteLine();
        }
    }
}
