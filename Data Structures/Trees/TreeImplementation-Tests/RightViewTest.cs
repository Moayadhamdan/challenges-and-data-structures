using TreeImplementation;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace TreeImplementation_Tests
{
    public class RightViewTest
    {
        [Fact]
        public void TestRightView()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);

            Btree.PrintRightView();

            // Assert
            var output = sw.ToString();
            Assert.Equal("2 5 6 7 ", output);
        }

        [Fact]
        public void TestRightViewSingleRightSide()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Right = new Node(2);
            Btree.Root.Right.Right = new Node(3);

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);

            Btree.PrintRightView();

            // Assert
            var output = sw.ToString();
            Assert.Equal("1 2 3 ", output);
        }
    }
}
