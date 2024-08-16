using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        // ( Root - Left - Right )
        public List<int> PreOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node == null) return result;
            result.Add(node.Value);
            result.AddRange(PreOrder(node.Left));
            result.AddRange(PreOrder(node.Right));
            return result;
        }

        // ( Left - Root - Right )
        public List<int> InOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node == null) return result;
            result.AddRange(InOrder(node.Left));
            result.Add(node.Value);
            result.AddRange(InOrder(node.Right));
            return result;
        }

        // ( Left - Right - Root )
        public List<int> PostOrder(Node node)
        {
            List<int> result = new List<int>();
            if (node == null) return result;
            result.AddRange(PostOrder(node.Left));
            result.AddRange(PostOrder(node.Right));
            result.Add(node.Value);
            return result;
        }
        // Print the tree
        public void Print(Node node, string indent = "", bool last = true)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "   ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|  ";
                }
                Console.WriteLine(node.Value);

                Print(node.Left, indent, false);
                Print(node.Right, indent, true);
            }


        }

        // Mirror the tree
        public void MirrorTree(Node node)
        {
            if (node == null)
                return;

            MirrorTree(node.Left);
            MirrorTree(node.Right);

            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        public List<int> InorderTraversal()
        {
            return InOrder(Root);
        }



    }

}
