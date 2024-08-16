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


        // Unit Tests For Mirror Tree
        [Fact]
        public void TestMirrorTree()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(4);
            binaryTree.Root.Left = new Node(8);
            binaryTree.Root.Right = new Node(7);
            binaryTree.Root.Left.Left = new Node(12);
            binaryTree.Root.Left.Right = new Node(9);

            List<int> expectedOriginalInorder = new List<int> { 12, 8, 9, 4, 7 };
            List<int> expectedMirroredInorder = new List<int> { 7, 4, 9, 8, 12 };

            // Act
            List<int> originalInorder = binaryTree.InorderTraversal();
            binaryTree.MirrorTree(binaryTree.Root);
            List<int> mirroredInorder = binaryTree.InorderTraversal();

            // Assert
            Assert.Equal(expectedOriginalInorder, originalInorder);
            Assert.Equal(expectedMirroredInorder, mirroredInorder);
        }

        [Fact]
        public void TestMirrorTreeSingleNode()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);

            List<int> expectedOriginalInorder = new List<int> { 1 };
            List<int> expectedMirroredInorder = new List<int> { 1 };

            // Act
            List<int> originalInorder = binaryTree.InorderTraversal();
            binaryTree.MirrorTree(binaryTree.Root);
            List<int> mirroredInorder = binaryTree.InorderTraversal();

            // Assert
            Assert.Equal(expectedOriginalInorder, originalInorder);
            Assert.Equal(expectedMirroredInorder, mirroredInorder);
        }

        [Fact]
        public void TestMirrorTreeEmpty()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            List<int> expectedInorder = new List<int>();

            // Act
            List<int> originalInorder = binaryTree.InorderTraversal();
            binaryTree.MirrorTree(binaryTree.Root);
            List<int> mirroredInorder = binaryTree.InorderTraversal();

            // Assert
            Assert.Empty(originalInorder);
            Assert.Empty(mirroredInorder);
        }
    }
}
