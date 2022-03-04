class Program
{
    public static void Main(string[] args)
    {
        // Recursive - repeat itself
        // example : 3^4
        int result = 1;
        for (int i = 0; i < 4; i++)
        {
            result *= 3;
        }

        Console.WriteLine(result);
        operations operation = new();
        Console.WriteLine(operation.Expo(3, 4));

        // Extension method
        string name = "Pablo Emilio Escobar Gaviria";
        Console.WriteLine(Extension.CheckSpace(name));
        // or 
        bool hasSpace = name.CheckSpace();
        if (hasSpace)
        {
            Console.WriteLine(name.RemoveSpace());
        }

        Console.WriteLine(name.UpperCase());
        Console.WriteLine(name.LowerCase());

        int[] arr = {0, 1, 3, 5, 7, 9};
        arr.PrintScreen();
        
        int randomNumber = 3;
        Console.WriteLine(randomNumber.IsEven());

        string surname = "Gaviria";
        Console.WriteLine(surname.GetFirstChar());

        hackerrank solution = new hackerrank();
        int factNumber = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(solution.fact(factNumber));
    }
}

public class operations
{
    public int Expo(int number, int power)
    {
        if (power < 2)
            return number;
        return Expo(number, power - 1) * number;
    }
}

public static class Extension
{
    public static bool CheckSpace(this string parameter)
    {
        return parameter.Contains(' ');
    }

    public static string RemoveSpace(this string parameter)
    {
        string[] arr = parameter.Split(' ');
        return string.Join("", arr);
    }

    public static string UpperCase(this string parameter)
    {
        return parameter.ToUpper();
    }

    public static string LowerCase(this string parameter)
    {
        return parameter.ToLower();
    }

    public static void PrintScreen(this int[] parameter)
    {
        foreach (var number in parameter)
            Console.WriteLine(number);
    }

    public static bool IsEven(this int parameter)
    {
        return parameter % 2 == 0;
    }

    public static string GetFirstChar(this string parameter)
    {
        return parameter.Substring(0,1);
    }
}

class hackerrank
{
    public int fact(int n)
    {
        if (n < 2)
            return n;
        return fact(n - 1) * n;
    }
}