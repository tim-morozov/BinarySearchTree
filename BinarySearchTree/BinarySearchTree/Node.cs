using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node rightBranch;
        public Node leftBranch;

        public Node(int value)
        {
            data = value;
        }

        public void AddNode(int newData)
        {
            if(newData >= data)
            {
                if(rightBranch == null)
                {
                    rightBranch = new Node(newData);
                }
                else
                {
                    rightBranch.AddNode(newData);
                }
            }
            else
            {
                if(leftBranch == null)
                {
                    leftBranch = new Node(newData);
                }
                else
                {
                    leftBranch.AddNode(newData);
                }
            }
        }
    }
}
