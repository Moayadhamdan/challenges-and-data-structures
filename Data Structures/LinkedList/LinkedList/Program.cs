using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Linked List Implementation ---------------------");
            LinkedListClass list = new LinkedListClass();

            // Adding nodes to the list
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(8);
            list.Head.Next.Next.Next = new Node(16);

            // Test PrintList method  
            Console.WriteLine("List:");
            list.PrintList();


            // Test Includes method
            Console.WriteLine("\nTesting Includes method:");
            Console.WriteLine($"Does the list include 4? {list.Includes(4)}");
            Console.WriteLine($"Does the list include 15? {list.Includes(15)}");

            // Test Remove method
            Console.WriteLine("\nRemoving node with data 4:");
            list.Remove(4);
            list.PrintList();

            Console.WriteLine("--------------------- Linked List Remove Duplicates ---------------------");
            LinkedListClass list2 = new LinkedListClass();

            // Adding nodes to the list
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(8);
            list.Head.Next.Next.Next = new Node(4);
            list.Head.Next.Next.Next.Next = new Node(16);
            list.Head.Next.Next.Next.Next.Next = new Node(8);
            list.Head.Next.Next.Next.Next.Next.Next = new Node(4);

            // Test PrintList method  
            Console.WriteLine("List before removing duplicates:");
            list.PrintList();

            // Remove duplicates
            list.RemoveDuplicate();

            // Print list after removing duplicates
            Console.WriteLine("List after removing duplicates:");
            list.PrintList();


        }
    }
}
