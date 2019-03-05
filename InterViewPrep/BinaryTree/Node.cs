using System;

namespace BinaryTree
{
    internal class Node
    {
        private int val;
        private Node left;
        private Node right;

        public Node(int val)
        {
            this.val = val;
        }

        public void addValue(int value)
        {
            if (value < this.val)
            {
                if (this.left == null)
                {
                    this.left = new Node(value);
                    return;
                }
                else
                {
                    this.left.addValue(value);
                }
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new Node(value);
                    return;

                }
                else
                {
                    this.right.addValue(value);
                }
            }
        }
        public void print()
        {
            Console.WriteLine("Value: {0}", val);
            if (this.left != null)
            {
                Console.Write("Left Node: ");
                this.left.print();
            }
            if (this.right != null)
            {
                Console.Write("Right Node: ");
                this.right.print();
            }
        }
       
    }

}