class Program
{
    public static void Main(string[] args)
    {
        // Datetime Libs

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(1));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        Console.WriteLine(DateTime.Now.ToString("dd")); // numeric day
        Console.WriteLine(DateTime.Now.ToString("ddd")); // shorted day name
        Console.WriteLine(DateTime.Now.ToString("dddd")); // long day name

        Console.WriteLine(DateTime.Now.ToString("MM")); // numeric month
        Console.WriteLine(DateTime.Now.ToString("MMM")); // shorted month name
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // long month name

        Console.WriteLine(DateTime.Now.ToString("yy")); // numeric year
        Console.WriteLine(DateTime.Now.ToString("yyyy")); // long year presentation

        // Math Libs

        Console.WriteLine(Math.Abs(-25)); // |-25| = 25
        Console.WriteLine(Math.Sin(30));
        Console.WriteLine(Math.Cos(30));
        Console.WriteLine(Math.Tan(30));

        Console.WriteLine(Math.Ceiling(33.3)); // deletion of fractions
        Console.WriteLine(Math.Round(33.3)); // rounding to the nearest whole number
        Console.WriteLine(Math.Floor(33.3)); // rounding to the nearest lower whole number

        Console.WriteLine(Math.Min(3, 5));
        Console.WriteLine(Math.Max(3, 5));

        Console.WriteLine(Math.Pow(3, 4));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Log(9));
        Console.WriteLine(Math.Exp(3));
        Console.WriteLine(Math.Log10(10));
    }
}




class hackerrank
{
    // public static void MoreExceptions()
    // {
    //     Calculator myCalculator = new Calculator();
    //     int T = Int32.Parse(Console.ReadLine());
    //     while (T-- > 0)
    //     {
    //         string[] num = Console.ReadLine().Split();
    //         int n = int.Parse(num[0]);
    //         int p = int.Parse(num[1]);
    //         try
    //         {
    //             int ans = Convert.ToInt32(Math.Pow(n, p));
    //             Console.WriteLine(ans);
    //         }
    //         catch (Exception)
    //         {
    //             Console.WriteLine("n and p should be non-negative");
    //         }
    //     }
    // }
    //
    // public static void Calculator()
    // {
    //     
    // }
}