using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        
        Node root;

        public void AddData(int data)
        {
         if(root == null)
            {
                root = new Node(data);
            }
         else
            {
                root.AddNode(data);
            }
        }

        public void Search(int data)
        {
            Node parent = root;
            Node child = root;
            bool found;
            while(root != null)
            {
                if(data != root.data)
                {
                    if(data >= parent.data)
                    {
                        child = parent.rightBranch;
                        if(child.data == data)
                        {
                            Console.WriteLine("Data found!");
                            break;
                        }
                        else if (data >= child.data)
                        {
                            parent = child;
                            child = parent.rightBranch;
                        }
                        else
                        {
                            parent = child;
                            child = parent.leftBranch;
                        }
                    }
                    else
                    {
                        child = parent.leftBranch;
                        if(child.data == data)
                        {
                            Console.WriteLine("Data found!");
                            break;
                        }
                        else if(data >= child.data)
                        {
                            parent = child;
                            child = parent.rightBranch;
                        }
                        else
                        {
                            parent = child;
                            child = parent.leftBranch;
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Data not found!");
                    return;
                }
            }
        }
    }
}
