using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.AddNode(10);    // BinaryTree { rootNode = Node(10); }
            tree.AddNode(1);    // BinaryTree { rootNode = Node(10, LeftNode = Node(1)) }
            tree.AddNode(15);   // BinaryTree { rootNode = Node(10, LeftNode = Node(1), RightNode = Node(15) ) }
            tree.AddNode(100); // BinaryTree { rootNode = Node(10, LeftNode = Node(1), RightNode = Node(15, RightNode = Node(100) ) ) }

            tree.print();

        }
    }
}
