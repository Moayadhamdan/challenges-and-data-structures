using TreeImplementation;

namespace TreeImplementation_Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Test_PreOrderTraversal()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(15);

            // Act
            var result = tree.PreOrder(tree.Root);

            // Assert
            Assert.Equal(new List<int> { 10, 5, 15 }, result);
        }

        [Fact]
        public void Test_InOrderTraversal()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(15);

            // Act
            var result = tree.InOrder(tree.Root);

            // Assert
            Assert.Equal(new List<int> { 5, 10, 15 }, result);
        }

        [Fact]
        public void Test_PostOrderTraversal()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(15);

            // Act
            var result = tree.PostOrder(tree.Root);

            // Assert
            Assert.Equal(new List<int> { 5, 15, 10 }, result);
        }
    }
}