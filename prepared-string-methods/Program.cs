class Program
{
    public static void Main(string[] args)
    {
        string variable = "Our lesson is CSharp, Welcome!";
        string variable2 = "CSharp";

        // Length
        Console.WriteLine(variable.Length);

        // ToUpper, ToLower
        Console.WriteLine(variable.ToUpper());
        Console.WriteLine(variable.ToLower());

        // Concat
        Console.WriteLine(String.Concat(variable, " Hello"));

        // CompareTo, Compare
        Console.WriteLine(variable.CompareTo(variable2)); // -1 - 0 - 1 
        Console.WriteLine(String.Compare(variable, variable2, true)); // if is true : not case sensitive 
        Console.WriteLine(String.Compare(variable, variable2, false)); // if is false : case sensitive

        // Contains
        Console.WriteLine(variable.Contains(variable2));
        Console.WriteLine(variable.EndsWith("Welcome!"));
        Console.WriteLine(variable.StartsWith("Our"));

        // IndexOf
        Console.WriteLine(variable.IndexOf("CS"));
        Console.WriteLine(variable.IndexOf("Hello"));
        Console.WriteLine(variable.LastIndexOf("i"));

        // Insert
        Console.WriteLine(variable.Insert(0, "Hello. "));

        // PadLeft, PadRight
        Console.WriteLine(variable + variable2.PadLeft(30));
        Console.WriteLine(variable + variable2.PadLeft(30, '*'));
        Console.WriteLine(variable.PadRight(50) + variable2);
        Console.WriteLine(variable.PadRight(50, '*') + variable2);

        // Remove
        Console.WriteLine(variable.Remove(10));
        Console.WriteLine(variable.Remove(5, 10));
        Console.WriteLine(variable.Remove(0, 1));

        // Replace
        Console.WriteLine(variable.Replace("CSharp", ".Net"));

        // Split
        Console.WriteLine(variable.Split(' ')[1]);

        // Substring
        Console.WriteLine(variable.Substring(4, 6));
    }
}

class hackerrank
{
    public static void StrToInt()
    {
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
        }
        catch (Exception e)
        {
            Console.WriteLine("Bad String");
            throw;
        }
    }

    public static void LetsReview()
    {
        int wordCounter = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < wordCounter; i++)
        {
            string word = Console.ReadLine();
            for (int j = 0; j < word.Length; j++)
            {
                if (j % 2 == 0)
                    Console.Write(word[j]);
            }

            Console.Write(" ");

            for (int j = 0; j < word.Length; j++)
            {
                if (j % 2 != 0)
                    Console.Write(word[j]);
            }
            Console.Write(Environment.NewLine);

        }
    }
}
