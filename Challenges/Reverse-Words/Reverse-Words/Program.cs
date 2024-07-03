using System;


namespace Reverse_Words
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string[] testCases = {"csharp is programming language","Reverse the words in this sentence","challenges and data structures","Moayad Hamdan"};

            foreach (string testCase in testCases)
            {
                string reversedword = ReverseWords(testCase);
                Console.WriteLine($"Input: {testCase}");
                Console.WriteLine($"Output: {reversedword}");
                Console.WriteLine();
            }
        }

        public static string ReverseWords(string Sentence)
        {
            string[] arr = Sentence.Split(' ');
            Array.Reverse(arr);
            return string.Join(" ", arr);
        }
    }
}
