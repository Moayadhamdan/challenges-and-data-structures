using System;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void TestCase1()
    {
        // Arrange
        int[] array1 = { 1, 2, 3, 0 };
        int[] array2 = { 2, 3, 4, 9 };
        int[] expected = { 2, 3 };
        
        // Act
        int[] result = Program.CommonElements(array1, array2);
       
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestCase2()
    {
        // Arrange
        int[] array1 = { 79, 8, 15 };
        int[] array2 = { 23, 79, 8 };
        int[] expected = { 79, 8 };
        
        // Act
        int[] result = Program.CommonElements(array1, array2);
        
        // Assert
        Assert.Equal(expected, result);
    }
}
