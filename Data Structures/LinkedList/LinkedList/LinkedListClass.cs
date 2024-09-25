using System;

namespace LinkedList
{
    public class LinkedListClass
    {
        public Node Head { get; set; }

        public LinkedListClass()
        {
            Head = null;
        }

        // Includes method
        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                    return true;
                current = current.Next;
            }
            return false;
        }

        // Remove method
        public void Remove(int data)
        {
            if (Head == null)
                return;

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        // PrintList method
        public void PrintList()
        {
            if (Head == null)
            {
                Console.WriteLine("Head is Null");
                return;
            }

            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
        // PrintListForTest method
        public string PrintListForTest()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "Null";
            return result;
        }

        // RemoveDuplicate method
        public void RemoveDuplicate()
        {
            Node current = Head;

            while (current != null)
            {
                Node duplicates = current;
                while (duplicates.Next != null)
                {
                    if (duplicates.Next.Data == current.Data)
                    {
                        duplicates.Next = duplicates.Next.Next;
                    }
                    else
                    {
                        duplicates = duplicates.Next;
                    }
                }
                current = current.Next;
            }
        }

        // MergeSortedLists method
        public static LinkedListClass MergeSortedLists(LinkedListClass list1, LinkedListClass list2)
        {
            Node dummy = new Node(0);
            Node tail = dummy;

            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data < current2.Data)
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                tail = tail.Next;
            }

            if (current1 != null)
            {
                tail.Next = current1;
            }
            if (current2 != null)
            {
                tail.Next = current2;
            }

            LinkedListClass mergedList = new LinkedListClass();
            mergedList.Head = dummy.Next;
            return mergedList;
        }

        // RotateLeft method
        public void RotateLeft(int k)
        {
            if (Head == null || k == 0)
                return;

            int length = 1;
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }
            k = k % length;
            if (k == 0)
                return;

            current = Head;
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }
            Node newHead = current.Next;
            current.Next = null;

            Node end = newHead;
            while (end.Next != null)
            {
                end = end.Next;
            }
            end.Next = Head;

            Head = newHead;
        }
    }
}
