using Xunit;
using Reverse_Words;


namespace Reverse_Words_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCase1()
        {
            // Arrange
            string input = "csharp is programming language";
            string Output = "language programming is csharp";

            // Act
            string result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(Output, result);
        }

        [Fact]
        public void TestCase2()
        {
            // Arrange
            string input = "Reverse the words in this sentence";
            string Output = "sentence this in words the Reverse";

            // Act
            string result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(Output, result);
        }

        [Fact]
        public void TestCase3()
        {
            // Arrange
            string input = "challenges and data structures";
            string Output = "structures data and challenges";

            // Act
            string result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(Output, result);
        }
    }
}