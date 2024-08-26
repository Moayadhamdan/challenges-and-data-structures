using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Binary Tree Example
            Console.WriteLine("=============== Binary Tree Example ===============");
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(10);
            binaryTree.Root.Left = new Node(5);
            binaryTree.Root.Right = new Node(15);
            binaryTree.Root.Left.Left = new Node(3);
            binaryTree.Root.Left.Right = new Node(7);
            binaryTree.Root.Right.Left = new Node(12);
            binaryTree.Root.Right.Right = new Node(18);

            Console.WriteLine("PreOrder Traversal:");
            List<int> preOrderResult = binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine(string.Join(", ", preOrderResult));

            Console.WriteLine("InOrder Traversal:");
            List<int> inOrderResult = binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine(string.Join(", ", inOrderResult));

            Console.WriteLine("PostOrder Traversal:");
            List<int> postOrderResult = binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine(string.Join(", ", postOrderResult));

            // Print the Binary Tree structure
            Console.WriteLine("\nBinary Tree Structure:");
            binaryTree.Print(binaryTree.Root);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Binary Search Tree Example
            Console.WriteLine("=============== Binary Search Tree Example ===============");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(18);

            Console.WriteLine("BST Contains 7: " + bst.Contains(7));
            Console.WriteLine("BST Contains 20: " + bst.Contains(20));

            Console.WriteLine("\nRemoving 5 from BST");
            bst.Remove(5);
            Console.WriteLine("BST Contains 5: " + bst.Contains(5));

            // Print the BST structure
            Console.WriteLine("\nBinary Search Tree Structure:");
            bst.Print(bst.Root);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Mirror Tree Example
            Console.WriteLine("=============== Mirror Tree Example ===============");
            BinaryTree MirrorTree = new BinaryTree();
            MirrorTree.Root = new Node(4);
            MirrorTree.Root.Left = new Node(8);
            MirrorTree.Root.Right = new Node(7);
            MirrorTree.Root.Left.Left = new Node(12);
            MirrorTree.Root.Left.Right = new Node(9);

            Console.WriteLine("Original InOrder Traversal:");
            List<int> originalInorder = MirrorTree.InOrder(MirrorTree.Root);
            Console.WriteLine(string.Join(", ", originalInorder));

            Console.WriteLine("Original Binary Tree:");
            MirrorTree.Print(MirrorTree.Root);

            Console.WriteLine("\nMirroring the Binary Tree...");
            MirrorTree.MirrorTree(MirrorTree.Root);

            Console.WriteLine("\nMirrored Binary Tree:");
            MirrorTree.Print(MirrorTree.Root);

            Console.WriteLine("Mirrored InOrder Traversal:");
            List<int> mirroredInorder = MirrorTree.InOrder(MirrorTree.Root);
            Console.WriteLine(string.Join(", ", mirroredInorder));

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Second Maximum Value In Tree Example
            Console.WriteLine("=============== Second Maximum Value In Tree Example ===============");
            BinaryTree secondMaximumValue = new BinaryTree();
            secondMaximumValue.Root = new Node(10);
            secondMaximumValue.Root.Left = new Node(5);
            secondMaximumValue.Root.Right = new Node(20);
            secondMaximumValue.Root.Left.Left = new Node(3);
            secondMaximumValue.Root.Left.Right = new Node(7);
            secondMaximumValue.Root.Right.Left = new Node(15);
            secondMaximumValue.Root.Right.Right = new Node(25);

            // Print Tree
            Console.WriteLine("Binary Tree:");
            secondMaximumValue.Print(secondMaximumValue.Root);

            // Find the maximum value in the tree
            int maxValue = secondMaximumValue.FindMax(secondMaximumValue.Root); // Output: 25
            Console.WriteLine("\nMaximum Value: " + maxValue);

            // Find the second maximum value in the tree
            int secondMax = secondMaximumValue.FindSecondMax(); // Output: 20
            Console.WriteLine("Second Maximum Value: " + secondMax);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Sum Of Leaf Nodes In Tree Example
            Console.WriteLine("=============== Sum Of Leaf Nodes In Tree Example ===============");
            BinaryTree sumOfLeafNodes = new BinaryTree();
            sumOfLeafNodes.Root = new Node(9);
            sumOfLeafNodes.Root.Left = new Node(8);
            sumOfLeafNodes.Root.Right = new Node(12);
            sumOfLeafNodes.Root.Left.Left = new Node(3);
            sumOfLeafNodes.Root.Left.Right = new Node(7);
            sumOfLeafNodes.Root.Right.Left = new Node(17);
            sumOfLeafNodes.Root.Right.Right = new Node(23);
            sumOfLeafNodes.Root.Left.Left.Right = new Node(4);

            // Print Tree
            Console.WriteLine("Binary Tree:");
            sumOfLeafNodes.Print(sumOfLeafNodes.Root);

            // Calculate the sum of the leaf nodes
            int leafSum = sumOfLeafNodes.SumOfLeafNodes();

            // Output the result
            Console.WriteLine("\nThe sum of the leaf nodes is: " + leafSum);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Largest Value at Each Level In Tree
            Console.WriteLine("=============== Largest Value at Each Level In Tree ===============");
            BinaryTree largestValueAtEachLevel = new BinaryTree();
            largestValueAtEachLevel.Root = new Node(5);
            largestValueAtEachLevel.Root.Left = new Node(13);
            largestValueAtEachLevel.Root.Right = new Node(7);
            largestValueAtEachLevel.Root.Left.Left = new Node(3);
            largestValueAtEachLevel.Root.Left.Right = new Node(7);
            largestValueAtEachLevel.Root.Right.Left = new Node(12);
            largestValueAtEachLevel.Root.Right.Right = new Node(20);
            largestValueAtEachLevel.Root.Left.Left.Left = new Node(1);
            largestValueAtEachLevel.Root.Left.Left.Right = new Node(4);
            largestValueAtEachLevel.Root.Right.Left.Right = new Node(11);

            // Print Tree
            Console.WriteLine("Binary Tree:");
            largestValueAtEachLevel.Print(largestValueAtEachLevel.Root);

            // Finding the largest value at each level
            List<int> largestValues = largestValueAtEachLevel.LargestValueEachLevel();

            // Display the result
            Console.WriteLine("Largest values at each level:");
            foreach (int value in largestValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
