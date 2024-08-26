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

        /// <summary>
        /// ==============================================================================================================================================
        /// </summary>

        // Unit Tests For Mirror Tree
        // Test 1: Test converting a tree into its mirror and performing inorder traversal
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

        // Test 2: Test with a single-node tree
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

        // Test 3: Test with an empty tree
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

        /// <summary>
        /// ==============================================================================================================================================
        /// </summary>

        // Unit Tests Second Maximum Value in Tree
        // Test 1: Finding the maximum value in a binary tree using the provided example
        [Fact]
        public void FindMaxProvidedExample()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(5);
            Btree.Root.Right = new Node(20);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(15);
            Btree.Root.Right.Right = new Node(25);

            // Act
            int maxValue = Btree.FindMax(Btree.Root);

            // Assert
            Assert.Equal(25, maxValue);
        }

        // Test 2: Testing with a tree having fewer than two unique values
        [Fact]
        public void FindMaxTreeWithFewerThanTwoUniqueValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(10);
            Btree.Root.Right = new Node(10);

            // Act
            int maxValue = Btree.FindMax(Btree.Root);

            // Assert
            Assert.Equal(10, maxValue);
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        // Test 3: Testing with a tree having negative values
        [Fact]
        public void FindMaxNegativeValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(-10);
            Btree.Root.Left = new Node(-20);
            Btree.Root.Right = new Node(-5);
            Btree.Root.Left.Left = new Node(-30);
            Btree.Root.Left.Right = new Node(-15);
            Btree.Root.Right.Left = new Node(-7);
            Btree.Root.Right.Right = new Node(-3);

            // Act
            int maxValue = Btree.FindMax(Btree.Root);

            // Assert
            Assert.Equal(-3, maxValue);

        }

        /// <summary>
        /// ==============================================================================================================================================
        /// </summary>

        // Unit Tests Sum Of Leaf Nodes In Tree Example
        // Test 1: Test calculating the sum of all leaf nodes in a binary tree using the provided example
        [Fact]
        public void TestSumOfLeafNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, leafSum);
        }

        // Test 2: Test calculating the sum of all leaf nodes in a binary tree using example with negative leaf values
        [Fact]
        public void TestSumOfLeafNodeWithNegativeValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(-3);
            Btree.Root.Right = new Node(2);
            Btree.Root.Right.Left = new Node(4);
            Btree.Root.Right.Right = new Node(-7);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(-6, leafSum);
        }


        /// <summary>
        /// ==============================================================================================================================================
        /// </summary>
        

        // Unit Tests Largest Value at Each Level In Tree
        // Test 1: Verify the sum of calculated largest values of each level are correct
        [Fact]
        public void LargestValueEachLevel()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(13);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(12);
            Btree.Root.Right.Right = new Node(20);
            Btree.Root.Left.Left.Left = new Node(1);
            Btree.Root.Left.Left.Right = new Node(4);
            Btree.Root.Right.Left.Right = new Node(11);

            // Act
            List<int> largestValues = Btree.LargestValueEachLevel();

            // Assert
            List<int> expectedValues = new List<int> { 5, 13, 20, 11 };
            Assert.Equal(expectedValues, largestValues);
        }
    }
}
