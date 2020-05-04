using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node leftBranch;
        Node rightBranch;
        Node root;

        public void AddData(int data)
        {
         if(root == null)
            {
                root = new Node();
                root.data = data;
            }
         else
            {
                if(data > root.data)
                {
                    rightBranch = new Node();
                    rightBranch.data = data;
                }
                else
                {
                    leftBranch = new Node();
                    leftBranch.data = data;
                }
            }
        }
    }
}
