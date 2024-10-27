using HashTableImplementation;

namespace HashTableImplementation_Tests
{
    public class HashTableTests
    {
        [Fact]
        public void TestInsertAndSearch()
        {
            // Arrange
            var hashTable = new HashTable<string, string>(10);
            hashTable.Insert("color", "Green");
            hashTable.Insert("bgColor", "Blue");

            // Act
            var colorResult = hashTable.Search("color");
            var bgColorResult = hashTable.Search("bgColor");

            // Assert
            Assert.Equal("Green", colorResult);
            Assert.Equal("Blue", bgColorResult);
        }

        [Fact]
        public void TestRemove()
        {
            // Arrange
            var hashTable = new HashTable<string, string>(10);
            hashTable.Insert("color", "Green");
            hashTable.Insert("bgColor", "Blue");

            // Act
            hashTable.Remove("bgColor");

            // Assert
            Assert.Throws<KeyNotFoundException>(() => hashTable.Search("bgColor"));
        }

        [Fact]
        public void TestContains()
        {
            // Arrange
            var hashTable = new HashTable<string, string>(10);
            hashTable.Insert("color", "Green");

            // Act
            var containsColor = hashTable.Contains("color");
            var containsBgColor = hashTable.Contains("bgColor");

            // Assert
            Assert.True(containsColor);
            Assert.False(containsBgColor);
        }

        [Fact]
        public void TestCount()
        {
            // Arrange
            var hashTable = new HashTable<string, string>(10);
            hashTable.Insert("color", "Green");
            hashTable.Insert("bgColor", "Blue");

            // Act
            var initialCount = hashTable.Count();
            hashTable.Remove("color");
            var countAfterRemove = hashTable.Count();

            // Assert
            Assert.Equal(2, initialCount);
            Assert.Equal(1, countAfterRemove);
        }

        [Fact]
        public void TestSearchKeyNotFound()
        {
            // Arrange
            var hashTable = new HashTable<string, string>(10);

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => hashTable.Search("NonExistentKey"));
        }

        [Fact]
        public void TestInsertDuplicateKeyThrowsException()
        {
            // Arrange
            var hashTable = new HashTable<string, string>(10);
            hashTable.Insert("color", "Green");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => hashTable.Insert("color", "Blue"));
        }
    }
}