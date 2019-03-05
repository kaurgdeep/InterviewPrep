using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node rootNode;
        public void AddNode(int val)
        {
            var newNode = new Node(val);
            if (this.rootNode == null)
            {
               this.rootNode = newNode;
                return;
                
            }
            else
            {
                this.rootNode.addValue(val);
            }
           
        }


        public void print()
        {
            if(this.rootNode != null)
            {
                this.rootNode.print();
            }

        }



    }


}
