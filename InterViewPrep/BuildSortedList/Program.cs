using System;

namespace BuildSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node headNode = BuildSortedList(new int[]{ 20,1,0,10,3,5,100});
            PrintList(headNode);
            PrintList(BuildSortedList(new int[] { }));
            PrintList(BuildSortedList(new int[] {1,2,3,4,5,6,7,8}));
            PrintList(BuildSortedList(new int[] {100,90,80,70,60,50,40,30,20,10}));
            Console.WriteLine("Hello World!");
        }

        static Node BuildSortedList(int[] a)
        {
            Node headNode = null;
            foreach(var data in a)
            {
                //var newHeadNode = insertNode(headNode, data);
                //headNode = newHeadNode;
                headNode = insertNode(headNode, data);
            }
            return headNode;
        }

        // insertNode will return the head of the list
        private static Node insertNode(Node headNode, int data)
        {
            //make new node

            var newNode = new Node(data);
            //If list is Empty
            if(headNode == null)
            {
                //headNode = newNode;
                return newNode;
            }
            //if list have 1node
            if(headNode.next == null)
            {
                if (data > headNode.data)
                {
                    headNode.next = newNode;
                    return headNode;
                }
                else
                {
                    newNode.next = headNode;
                    return newNode;
                }
            }

            if (data <= headNode.data)
            {
                newNode.next = headNode;
                return newNode;
            }
            // inseting between 2nodes

            var currentNode = headNode;
            Node nextNode = null;
            while(currentNode != null)
            {
                nextNode = currentNode.next;
                if(nextNode != null)
                {
                    if(currentNode.data<data && data<= nextNode.data)
                    {
                        currentNode.next = newNode;
                        newNode.next = nextNode;
                        return headNode;
                    }
                }
                else
                {
                    currentNode.next = newNode; //insert in the end
                    return headNode;
                }
                currentNode = nextNode;
            }
            return headNode;
        }

        static void PrintList(Node headNode)
        {
            while(headNode != null)
            {
                Console.Write("{0} ->", headNode.data);
                headNode = headNode.next;

            }
            Console.WriteLine();
        }
    }
}
