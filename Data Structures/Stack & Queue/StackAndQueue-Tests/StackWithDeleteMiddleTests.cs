using Xunit;
using StackAndQueue.DeleteMiddleElement;

namespace StackAndQueue_Tests
{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void Test_DeleteMiddle_OddSizedStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            var expected = new int[] { 5, 8, 14, 7 };
            AssertStackContents(expected, stack);
        }

        [Fact]
        public void Test_DeleteMiddle_EvenSizedStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);

            // Act
            stack.DeleteMiddle();

            // Assert
            var expected = new int[] { 8, 14, 7 };
            AssertStackContents(expected, stack);
        }

        private void AssertStackContents(int[] expected, StackWithDeleteMiddle stack)
        {
            foreach (var value in expected)
            {
                Assert.Equal(value, stack.Pop());
            }
        }
    }
}
