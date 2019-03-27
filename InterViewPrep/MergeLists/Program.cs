using System;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static List MergeList(Node list1, Node list2)
        {
            List<Node> list3 = new List<Node>();
            Node list3CurrentNode = list3headC
            Node list1CurrentNode = list1head;
            Node list2CurrentNode = list2head;
            while(list1CurrentNode!= null && list2CurrentNode != null)
            {
                if (list1CurrentNode.val <= list2CurrentNode.val)
                {
                    list3CurrentNode = 
                }
            }


        }
    }
}
