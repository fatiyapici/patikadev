class Program
{
    public static void Main(string[] args)
    {
        string number = "333";
        bool isNumber = int.TryParse(number, out int outputNumber);
        if (isNumber)
            Console.WriteLine("Successfully parsed. Number is: " + outputNumber);
        else
            Console.WriteLine("Number is not parsed.");

        methods method = new methods();
        method.sum(3, 3, out int summary);
        Console.WriteLine(summary);

        // Method overloading

        int anotherNumber = 555;

        method.printScreen(anotherNumber.ToString());
        // if anotherNumber.ToString() is null, gives an error
        method.printScreen(Convert.ToString(anotherNumber));
        // if Convert.ToString(anotherNumber) is null, does not give an error

        // In the two examples above, the string method is used.

        method.printScreen(anotherNumber);
        // But this time int method is used.

        method.printScreen("Sefer", "Algan");
    }
}

class methods
{
    public int sum(int a, int b, out int summary)
    {
        summary = a + b;
        return summary;
    }

    public void printScreen(string value)
    {
        Console.WriteLine(value);
    }

    public void printScreen(int value)
    {
        Console.WriteLine(value);
    }

    public void printScreen(string name, string surname)
    {
        Console.WriteLine(name + surname);
    }
}