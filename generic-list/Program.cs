class generic_list
{
    public static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);

        List<string> colorList = new List<string>();

        colorList.Add("red");
        colorList.Add("blue");
        colorList.Add("yellow");

        // Count
        Console.WriteLine(colorList.Count);
        Console.WriteLine(numberList.Count);

        // Foreach display
        foreach (var color in colorList)
        {
            Console.WriteLine(color);
        }

        foreach (var number in numberList)
        {
            Console.WriteLine(number);
        }

        colorList.ForEach(color => Console.WriteLine(color));
        numberList.ForEach(number => Console.WriteLine(number));

        // Remove in list
        colorList.Remove("red");
        numberList.Remove(10);
        // colorList.RemoveAt(0);
        // numberList.RemoveAt(0);

        // Search in list
        if (colorList.Contains("blue"))
        {
            Console.WriteLine("Color founded.");
        }

        // Access index to list element
        Console.WriteLine(colorList.BinarySearch("blue"));

        // Convert array to list
        string[] animalsArray = {"cat", "dog", "bird"};

        List<string> animalsList = new List<string>(animalsArray);

        // Cleaning list
        animalsList.Clear();

        // Object handle in list and usage example
        List<User> userList = new List<User>();
        User firstUser = new User();
        firstUser.Name = "Fatih";
        firstUser.Age = 25;
        User secondUser = new User();
        secondUser.Name = "Burak";
        secondUser.Age = 25;

        userList.Add(firstUser);
        userList.Add(secondUser);

        List<User> thirdUser = new List<User>();
        thirdUser.Add(new User()
        {
            Name = "Baran",
            Age = 25
        });

        foreach (var user in userList)
        {
            Console.WriteLine("Username: " + user.Name);
            Console.WriteLine("Surname: " + user.Surname);
            Console.WriteLine("Age: " + user.Age);
        }

        thirdUser.Clear();
    }
}

public class User
{
    private string name;
    private string surname;
    private int age;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Surname
    {
        get => surname;
        set => surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }
}

public class hackerrankQ1
{
    public static void generic()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] intArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        n = Convert.ToInt32(Console.ReadLine());
        string[] stringArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        PrintArray<int>(intArray);
        PrintArray<String>(stringArray);
    }

    private static void PrintArray<T>(T[] rayRayArray)
    {
        foreach (var n in rayRayArray)
        {
            Console.WriteLine(n);
        }
    }
}