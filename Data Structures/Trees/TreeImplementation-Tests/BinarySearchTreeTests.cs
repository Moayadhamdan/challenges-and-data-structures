using TreeImplementation;

namespace TreeImplementation_Tests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void Test_Add()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act & Assert
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
        }

        [Fact]
        public void Test_Contains()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act & Assert
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
            Assert.False(bst.Contains(20));
        }

        [Fact]
        public void Test_Remove()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act
            bst.Remove(5);

            // Assert
            Assert.False(bst.Contains(5));
        }
    }
}
