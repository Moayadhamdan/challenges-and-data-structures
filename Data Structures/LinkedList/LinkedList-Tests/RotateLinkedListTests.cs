using System;
using Xunit;
using LinkedList;

namespace LinkedListTests
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void RotateLeft_WhenKIsZero_ListRemainsUnchanged()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(1);
            list.Head.Next = new Node(2);
            list.Head.Next.Next = new Node(3);
            list.Head.Next.Next.Next = new Node(4);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("1 -> 2 -> 3 -> 4 -> Null", list.PrintListForTest());
        }

        [Fact]
        public void RotateLeft_WhenKGreaterThanLength_ListRotates()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(10);
            list.Head.Next = new Node(20);
            list.Head.Next.Next = new Node(30);
            list.Head.Next.Next.Next = new Node(40);
            list.Head.Next.Next.Next.Next = new Node(50);

            // Act
            list.RotateLeft(7);

            // Assert
            Assert.Equal("30 -> 40 -> 50 -> 10 -> 20 -> Null", list.PrintListForTest());
        }
    }
}
