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

    }
}
