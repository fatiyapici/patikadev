using System.Collections;

class arrayList
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();

        list.Add("Fatih");
        list.Add(25);
        list.Add(true);
        list.Add('F');

        // Access to ArrayList
        Console.WriteLine(list[1]);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // ArrayList methods
        // AddRange
        string[] colors = {"red", "blue", "yellow"};
        List<int> numbers = new List<int>() {1, 3, 5, 7, 9};
        list.AddRange(colors);
        list.AddRange(numbers);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Sort
        // list.Sort(); => Runtime exception is taken. Because arrayList contains a different types (string, int, bool)

        // Binary Search
        // Console.WriteLine(list.BinarySearch(9)); 
        // => For binary search firstly need to sort. Then binary search is given a index.

        // Reverse
        list.Reverse();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Clear();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}