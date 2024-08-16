﻿using System;
using System.Collections.Generic;

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
        }
    }
}
