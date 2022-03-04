class Coderbyte
{
    public static void Main(string[] args)
    {
        Console.WriteLine(PrimeTime(int.Parse(Console.ReadLine())));
    }

    public static string ConsonantCount(string input)
    {
        string lowerInput = input.ToLower().Trim();
        int vowelCounter = 0, constantCounter = 0;

        for (int i = 0; i < lowerInput.Length; i++)
        {
            if (lowerInput[i] == 'a' || lowerInput[i] == 'e' || lowerInput[i] == 'i' || lowerInput[i] == 'o' ||
                lowerInput[i] == 'u')
                vowelCounter++;
            else
                constantCounter++;
        }

        return constantCounter.ToString();
    }

    public static bool PrimeTime(int strNum)
    {
        int num = Convert.ToInt32(strNum);
        if (num == 1) return false;
        if (num == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(num));

        for (int i = 2; i <= limit; ++i)
            if (num % i == 0)
                return false;
        return true;
    }
}