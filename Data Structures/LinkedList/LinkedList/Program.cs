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
            LinkedListClass removeDuplicatesList = new LinkedListClass();

            // Adding nodes to the list
            removeDuplicatesList.Head = new Node(2);
            removeDuplicatesList.Head.Next = new Node(4);
            removeDuplicatesList.Head.Next.Next = new Node(8);
            removeDuplicatesList.Head.Next.Next.Next = new Node(4);
            removeDuplicatesList.Head.Next.Next.Next.Next = new Node(16);
            removeDuplicatesList.Head.Next.Next.Next.Next.Next = new Node(8);
            removeDuplicatesList.Head.Next.Next.Next.Next.Next.Next = new Node(4);

            // Test PrintList method  
            Console.WriteLine("List before removing duplicates:");
            removeDuplicatesList.PrintList();

            // Remove duplicates
            removeDuplicatesList.RemoveDuplicate();

            // Print list after removing duplicates
            Console.WriteLine("List after removing duplicates:");
            removeDuplicatesList.PrintList();


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


            Console.WriteLine("--------------------- Linked List - Rotate by K ---------------------");
            // Test case 1: Rotate with k = 2
            Console.WriteLine("Test 1: Rotate Left by 2");
            LinkedListClass RotateList1 = new LinkedListClass();
            RotateList1.Head = new Node(1);
            RotateList1.Head.Next = new Node(2);
            RotateList1.Head.Next.Next = new Node(3);
            RotateList1.Head.Next.Next.Next = new Node(4);
            RotateList1.Head.Next.Next.Next.Next = new Node(5);

            Console.WriteLine("Original list:");
            RotateList1.PrintList();

            RotateList1.RotateLeft(2);

            Console.WriteLine("Rotated list by 2:");
            RotateList1.PrintList();
            Console.WriteLine();

            // Test case 2: Rotate with k = 3
            Console.WriteLine("Test 2: Rotate Left by 3");
            LinkedListClass RotateList2 = new LinkedListClass();
            RotateList2.Head = new Node(10);
            RotateList2.Head.Next = new Node(20);
            RotateList2.Head.Next.Next = new Node(30);
            RotateList2.Head.Next.Next.Next = new Node(40);
            RotateList2.Head.Next.Next.Next.Next = new Node(50);

            Console.WriteLine("Original list:");
            RotateList2.PrintList();

            RotateList2.RotateLeft(3); 

            Console.WriteLine("Rotated list by 3:");
            RotateList2.PrintList();
            Console.WriteLine();

            // Test case 3: Rotate with k = 1
            Console.WriteLine("Test 3: Rotate Left by 1");
            LinkedListClass RotateList3 = new LinkedListClass();
            RotateList3.Head = new Node(100);
            RotateList3.Head.Next = new Node(200);
            RotateList3.Head.Next.Next = new Node(300);
            RotateList3.Head.Next.Next.Next = new Node(400);

            Console.WriteLine("Original list:");
            RotateList3.PrintList();

            RotateList3.RotateLeft(1);

            Console.WriteLine("Rotated list by 1:");
            RotateList3.PrintList();
        }
    }
}
