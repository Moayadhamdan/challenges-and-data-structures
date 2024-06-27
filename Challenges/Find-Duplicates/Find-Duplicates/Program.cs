using System;
using System.Collections.Generic;
namespace Find_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            int[][] testCases = new int[][]
            {
                new int[] {1, 2, 3, 1, 2, 3},
                new int[] {16, 8, 31, 17, 15, 23, 17, 8},
                new int[] {5, 10, 16, 20, 10, 16},
                new int[] {1, 2, 3, 4, 5},
                new int[] {}
            };
            foreach (var testCase in testCases)
            {
                int[] duplicates = FindDuplicates(testCase);
                Console.WriteLine($"Input: [{string.Join(", ", testCase)}]");
                Console.WriteLine($"Output: [{string.Join(", ", duplicates)}]");
                Console.WriteLine();
            }
        }
        static int[] FindDuplicates(int[] arr)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            List<int> duplicates = new List<int>();
            foreach (var element in arr)
            {
                if (elementCount.ContainsKey(element))
                {
                    elementCount[element]++;
                }
                else
                {
                    elementCount[element] = 1;
                }
            }
            foreach (var pair in elementCount)
            {
                if (pair.Value > 1)
                {
                    duplicates.Add(pair.Key);
                }
            }
            return duplicates.ToArray();
        }
    }
}