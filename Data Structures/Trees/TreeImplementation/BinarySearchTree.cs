using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node current = Root;
            Node parent = null;
            while (true)
            {
                parent = current;
                if (value < current.Value)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }
            }
        }

        public bool Contains(int value)
        {
            Node current = Root;
            while (current != null)
            {
                if (current.Value == value)
                    return true;
                else if (value < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return false;
        }

        public void Remove(int value)
        {
            Root = RemoveNode(Root, value);
        }

        private Node RemoveNode(Node node, int value)
        {
            if (node == null) return node;

            if (value < node.Value)
                node.Left = RemoveNode(node.Left, value);
            else if (value > node.Value)
                node.Right = RemoveNode(node.Right, value);
            else
            {
                if (node.Left == null) return node.Right;
                else if (node.Right == null) return node.Left;

                node.Value = MinValue(node.Right);
                node.Right = RemoveNode(node.Right, node.Value);
            }
            return node;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }

}
