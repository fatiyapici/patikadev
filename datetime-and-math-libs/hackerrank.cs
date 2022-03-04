using System.Globalization;

namespace datetime_and_math_libs;

public class hackerrank
{
    static void hackerrankQ1()
    {
        Calculator myCalculator = new Calculator();

        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception)
            {
                Console.WriteLine("n and p should be non-negative");
            }
        }
    }
}

public class Calculator
{
    public int power(int n, int p)
    {
        if (n < 0 & p < 0)
            throw new Exception("n and p should be non-negative");
        return (int) Math.Pow(n, p);
    }
}

public class hackerrankQ2
{
    public static void solution()
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }

    public static string timeConversion(string s)
    {
        var dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
        return $"{dt:HH:mm:ss}";
    }
}