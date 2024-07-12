using LinkedList;
using System;
using System.IO;
using Xunit;

namespace LinkedList_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIncludes()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(8);
            list.Head.Next.Next.Next = new Node(16);

            // Act
            bool includes4 = list.Includes(4);
            bool includes15 = list.Includes(15);

            // Assert
            Assert.True(includes4);
            Assert.False(includes15);
        }

        [Fact]
        public void TestRemove()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(8);
            list.Head.Next.Next.Next = new Node(16);

            // Act
            list.Remove(4);
            list.Remove(2);

            // Assert
            Assert.False(list.Includes(4));
            Assert.False(list.Includes(2));
            Assert.True(list.Includes(8));
            Assert.True(list.Includes(16));
        }

        [Fact]
        public void TestPrintList()
        {
            // Arrange
            LinkedListClass list = new LinkedListClass();
            list.Head = new Node(2);
            list.Head.Next = new Node(4);
            list.Head.Next.Next = new Node(8);
            list.Head.Next.Next.Next = new Node(16);

            // Act
            string output = CaptureConsoleOutput(() => list.PrintList());


            // Assert
            Assert.Equal("2 -> 4 -> 8 -> 16 -> Null\r\n", output);
        }

        // Helper method for testing PrintList()
        private string CaptureConsoleOutput(Action action)
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            action();

            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            return consoleOutput.ToString();
        }
    }
}
