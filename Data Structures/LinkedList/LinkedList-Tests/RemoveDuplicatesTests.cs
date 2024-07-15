using System;
using Xunit;
using LinkedList;

namespace LinkedListTests
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void Test_WithOutDuplicates()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(8);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.Equal("2 -> 4 -> 8 -> Null", GetListString(list));
        }

        [Fact]
        public void Test_WithDuplicates()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(4);
            list.Head.Next.Next.Next = new Node(8);
            list.Head.Next.Next.Next.Next = new Node(8);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.Equal("2 -> 4 -> 8 -> Null", GetListString(list));
        }

        [Fact]
        public void Test_AllDuplicates()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(2);
            list.Head.Next = new Node(2);
            list.Head.Next.Next = new Node(2);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.Equal("2 -> Null", GetListString(list));
        }

        public string GetListString(LinkedListClass list)
        {
            if (list.Head == null) return "Null";

            Node current = list.Head;
            string result = "";

            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }

            result += "Null";
            return result;
        }
    }
}
