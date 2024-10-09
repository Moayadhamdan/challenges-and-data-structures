using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementation_Tests
{
    public class MinimumDepthTests
    {
        [Fact]
        public void FindMinimumDepth_MultipleNodes_VaryingDepths_ReturnsCorrectDepth()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(10);
            binaryTree.Root.Left = new Node(5);
            binaryTree.Root.Right = new Node(15);
            binaryTree.Root.Left.Left = new Node(3);
            binaryTree.Root.Left.Right = new Node(7);

            // Act
            int result = binaryTree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMinimumDepth_EmptyTree_ReturnsZero()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            // Act
            int result = binaryTree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, result);
        }
    }
}
