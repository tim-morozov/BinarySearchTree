using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.AddData(90);
            tree.AddData(44);
            tree.AddData(46);
            tree.AddData(59);
            tree.AddData(33);
            tree.AddData(94);
            tree.AddData(67);

            tree.Search(67);
        }
    }
}
