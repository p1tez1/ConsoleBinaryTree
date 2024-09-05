using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            this.Root = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                AddRecursive(Root, newNode);
            }
        }

        private void AddRecursive(Node current, Node newNode)
        {
            if (newNode.Data < current.Data)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                }
                else
                {
                    AddRecursive(current.Left, newNode);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                }
                else
                {
                    AddRecursive(current.Right, newNode);
                }
            }
        }

   
        public void PrintTree(Node node, string indent = "", bool last = true)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "| ";
                }
                Console.WriteLine(node.Data);

                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }
    }
}
