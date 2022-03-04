using System.Collections;

class dictionary
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> users = new Dictionary<int, string>();
        users.Add(1, "Fatih");
        users.Add(2, "Burak");
        users.Add(3, "Baran");

        // Access to array
        Console.WriteLine(users[1]);
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }

        // Count
        Console.WriteLine(users.Count);

        // Contains
        Console.WriteLine(users.ContainsKey(2));
        Console.WriteLine(users.ContainsValue("Baran"));

        // Remove
        users.Remove(1);
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }

        // Keys
        foreach (var user in users.Keys)
        {
            Console.WriteLine(user);
        }

        // Value
        foreach (var user in users.Values)
        {
            Console.WriteLine(user);
        }
    }
}

class hackerrank
{
    public static void DictsAndMaps()
    {
        int n = Int32.Parse(Console.ReadLine());
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            phonebook[line[0]] = line[1];
        }

        string searchInput;
        while ((searchInput = Console.ReadLine()) != null)
        {
            if (phonebook.ContainsKey(searchInput))
                Console.WriteLine(searchInput + "=" + phonebook[searchInput]);
            else
                Console.WriteLine("Not found");
        }
    }
}