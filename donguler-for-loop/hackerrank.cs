class hackerrank
{
    public static void dayFiveSolution()
    {
        int n = Convert.ToInt32(System.Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            System.Console.WriteLine(n + " x " + i + " = " + n * i);
        }
    }
    public static void staircase()
    {
        int n = 6;
        for (int i = 0; i <= n; i++)
        {
            string step = "";
            for (int k = 0; k < n - i; k++)
            {
                step += " ";
            }
            for (int j = 0; j < i; j++)
            {
                step += "#";
            }
            if (i > 0)
            {
                Console.WriteLine(step);
            }
        }
    }
}