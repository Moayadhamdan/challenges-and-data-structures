using System;

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


            Console.WriteLine("--------------------- Linked List Merge Sorted Lists ---------------------");
            // Adding nodes to the sortedList1
            LinkedListClass sortedList1 = new LinkedListClass();
            sortedList1.Head = new Node(1);
            sortedList1.Head.Next = new Node(3);
            sortedList1.Head.Next.Next = new Node(5);

            // Print sortedList1 
            Console.WriteLine("sortedList1:");
            sortedList1.PrintList();

            // Adding nodes to the sortedList2
            LinkedListClass sortedList2 = new LinkedListClass();
            sortedList2.Head = new Node(2);
            sortedList2.Head.Next = new Node(4);
            sortedList2.Head.Next.Next = new Node(6);

            // Print sortedList2 
            Console.WriteLine("sortedList2:");
            sortedList2.PrintList();

            // Tests Merge Sorted Lists method
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(sortedList1, sortedList2);
            Console.WriteLine("Merged List:");
            mergedList.PrintList();
        }
    }
}
