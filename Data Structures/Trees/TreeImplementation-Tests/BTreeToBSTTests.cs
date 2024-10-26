using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Tests
{
    public class BTreeToBSTTests
    {
        [Fact]
        public void ConvertToBST_WithExampleTree_ShouldConvertCorrectly()
        {
            // Arrange

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(40);
            binaryTree.Root.Left = new Node(10);
            binaryTree.Root.Right = new Node(50);
            binaryTree.Root.Left.Left = new Node(5);
            binaryTree.Root.Left.Right = new Node(30);
            binaryTree.Root.Right.Right = new Node(60);
            binaryTree.Root.Left.Right.Left = new Node(20);
            binaryTree.Root.Left.Right.Right = new Node(35);

            List<int> expectedInOrderValues = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 };

            // Act

            binaryTree.ConvertToBST();
            List<int> actualInOrderValues = binaryTree.InorderTraversal();

            // Assert

            Assert.Equal(expectedInOrderValues, actualInOrderValues);
        }

        [Fact]
        public void ConvertToBST_WithLeftSkewedTree_ShouldConvertCorrectly()
        {
            // Arrange

            BinaryTree leftSkewedTree = new BinaryTree();
            leftSkewedTree.Root = new Node(30);
            leftSkewedTree.Root.Left = new Node(20);
            leftSkewedTree.Root.Left.Left = new Node(10);

            List<int> expectedInOrderValues = new List<int> { 10, 20, 30 };

            // Act

            leftSkewedTree.ConvertToBST();

            List<int> actualInOrderValues = leftSkewedTree.InorderTraversal();

            // Assert

            Assert.Equal(expectedInOrderValues, actualInOrderValues);
        }

        [Fact]
        public void ConvertToBST_WithRightSkewedTree_ShouldConvertCorrectly()
        {
            // Arrange

            BinaryTree rightSkewedTree = new BinaryTree();
            rightSkewedTree.Root = new Node(10);
            rightSkewedTree.Root.Right = new Node(20);
            rightSkewedTree.Root.Right.Right = new Node(30);

            List<int> expectedInOrderValues = new List<int> { 10, 20, 30 };

            // Act

            rightSkewedTree.ConvertToBST();

            List<int> actualInOrderValues = rightSkewedTree.InorderTraversal();

            // Assert

            Assert.Equal(expectedInOrderValues, actualInOrderValues);
        }
    }
}
