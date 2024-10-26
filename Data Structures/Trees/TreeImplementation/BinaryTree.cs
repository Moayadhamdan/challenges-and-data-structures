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


        // Method to find the maximum value in the tree
        public int FindMax(Node node)
        {
            if (node == null)
                return int.MinValue;

            int maxLeft = FindMax(node.Left);
            int maxRight = FindMax(node.Right);
            return Math.Max(node.Value, Math.Max(maxLeft, maxRight));
        }


        // Method to find the second maximum value in the tree
        public int FindSecondMax()
        {
            if (Root == null)
                throw new InvalidOperationException("Tree is empty.");

            int max = FindMax(Root);
            int secondMax = FindSecondMaxHelper(Root, max);

            if (secondMax == int.MinValue)
                throw new InvalidOperationException("No second maximum found.");

            return secondMax;
        }

        private int FindSecondMaxHelper(Node node, int max)
        {
            if (node == null)
                return int.MinValue;

            int secondMax = node.Value < max ? node.Value : int.MinValue;
            int leftSecondMax = FindSecondMaxHelper(node.Left, max);
            int rightSecondMax = FindSecondMaxHelper(node.Right, max);

            return Math.Max(secondMax, Math.Max(leftSecondMax, rightSecondMax));
        }



        // Sum of leaf nodes in the tree
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Value;

            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }


        // Largest Value at Each Level In Tree
        public List<int> LargestValueEachLevel()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            var result = new List<int>();
            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxVal = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Value > maxVal)
                    {
                        maxVal = currentNode.Value;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                result.Add(maxVal);
            }

            return result;
        }



        // Print Right View
        public void PrintRightView()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                // Traverse all nodes of the current level
                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // If it's the last node in the current level, print it
                    if (i == levelSize - 1)
                    {
                        Console.Write(currentNode.Value + " ");
                    }

                    // Enqueue left and right children of the current node
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
        }

        // Level with Maximum Number of Nodes
        public int FindMaxLevelNodes()
        {
            if (Root == null) return -1;

            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxLevel = 0;
            int maxNodes = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
                currentLevel++;
            }

            return maxLevel;
        }


        // Find minimum depth
        public int FindMinimumDepth()
        {
            if (Root == null) return 0;

            var queue = new Queue<(Node node, int depth)>();
            queue.Enqueue((Root, 1));

            while (queue.Count > 0)
            {
                var (currentNode, currentDepth) = queue.Dequeue();

                if (currentNode.Left == null && currentNode.Right == null)
                {
                    return currentDepth;
                }

                if (currentNode.Left != null)
                {
                    queue.Enqueue((currentNode.Left, currentDepth + 1));
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue((currentNode.Right, currentDepth + 1));
                }
            }

            return 0;
        }


        // Binary Tree to Binary Search Tree
        public void ConvertToBST()
        {
            if (Root == null) return;

            List<int> values = new List<int>();
            CollectValuesInOrder(Root, values);

            values.Sort();

            int index = 0;
            AssignValuesInOrder(Root, values, ref index);
        }

        // Helper method to collect values in an in-order traversal
        private void CollectValuesInOrder(Node node, List<int> values)
        {
            if (node == null) return;
            CollectValuesInOrder(node.Left, values);
            values.Add(node.Value);
            CollectValuesInOrder(node.Right, values);
        }

        // Helper method to assign sorted values back to the nodes in an in-order traversal
        private void AssignValuesInOrder(Node node, List<int> values, ref int index)
        {
            if (node == null) return;
            AssignValuesInOrder(node.Left, values, ref index);
            node.Value = values[index++];
            AssignValuesInOrder(node.Right, values, ref index);
        }

    }

}
