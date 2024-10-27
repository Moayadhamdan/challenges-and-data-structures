namespace HashTableImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<string, string>(5);

            // Insert some key-value pairs
            hashTable.Insert("color", "Green");
            hashTable.Insert("bgColor", "Blue");
            hashTable.Insert("SecondColor", "Red");

            // Display the hash table
            hashTable.Display();

            // Search for keys
            Console.WriteLine($"Search color: {hashTable.Search("color")}");
            Console.WriteLine($"Search SecondColor: {hashTable.Search("SecondColor")}");

            // Check contains
            Console.WriteLine($"Contains 'bgColor': {hashTable.Contains("bgColor")}");
            Console.WriteLine($"Contains 'invalidKey': {hashTable.Contains("invalidKey")}");

            // Remove a key
            hashTable.Remove("bgColor");
            hashTable.Display();

            // Get count of elements
            Console.WriteLine($"Total count: {hashTable.Count()}");
        }
    }
}
