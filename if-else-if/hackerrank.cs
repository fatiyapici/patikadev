class hackerrank
{
    public static void weirdOrNotWeird()
    {
        int n = Convert.ToInt32(System.Console.ReadLine());

        if (n % 2 == 1)
        {
            System.Console.WriteLine("Weird");
        }
        else if (n % 2 == 0 && n >= 2 && n <= 5)
        {
            System.Console.WriteLine("Not Weird");
        }
        else if (n % 2 == 0 && n >= 6 && n <= 20)
        {
            System.Console.WriteLine("Weird");
        }
        else if (n % 2 == 0 && n > 20)
        {
            System.Console.WriteLine("Not Weird");
        }
    }

}