using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 0 };
        int[] array2 = { 2, 3, 4, 9 };

        int[] commonElements = CommonElements(array1, array2);
        Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
    }

    public static int[] CommonElements(int[] array1, int[] array2)
    {
        List<int> result = new List<int>();

        foreach (int value in array1)
        {
            foreach (int elem in array2)
            {
                if (value == elem)
                {
                    result.Add(value);
                    break;
                }
            }
        }

        return result.ToArray();
    }
}
