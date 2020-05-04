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
            while(root != null)
            {
                if(data != root.data)
                {

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
