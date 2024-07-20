using System;
using Xunit;

namespace LinkedList.Tests
{
    public class MergeSortedLinkedListsTests
    {
        [Fact]
        public void TestMergingWhenOneListIsEmpty()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();
            list2.Head = new Node(1);
            list2.Head.Next = new Node(2);
            list2.Head.Next.Next = new Node(3);

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);
            int[] result = GetListValues(mergedList);

            // Assert
            int[] expected = { 1, 2, 3 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMergingWhenBothListsAreEmpty()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            LinkedListClass list2 = new LinkedListClass();

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);

            // Assert
            Assert.Null(mergedList.Head);
        }

        [Fact]
        public void TestMergingExampleLists()
        {
            // Arrange
            LinkedListClass list1 = new LinkedListClass();
            list1.Head = new Node(5);
            list1.Head.Next = new Node(10);
            list1.Head.Next.Next = new Node(15);

            LinkedListClass list2 = new LinkedListClass();
            list2.Head = new Node(2);
            list2.Head.Next = new Node(3);
            list2.Head.Next.Next = new Node(20);

            // Act
            LinkedListClass mergedList = LinkedListClass.MergeSortedLists(list1, list2);
            int[] result = GetListValues(mergedList);

            // Assert
            int[] expected = { 2, 3, 5, 10, 15, 20 };
            Assert.Equal(expected, result);
        }

        private int[] GetListValues(LinkedListClass list)
        {
            var values = new System.Collections.Generic.List<int>();
            Node current = list.Head;
            while (current != null)
            {
                values.Add(current.Data);
                current = current.Next;
            }
            return values.ToArray();
        }
    }
}
