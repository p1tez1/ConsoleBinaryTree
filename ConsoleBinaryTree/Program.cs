using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(7);
            tree.Add(2);
            

            Console.WriteLine("In-Order Traversal:\n");

            tree.PrintTree(tree.Root);
        }
    }
}
