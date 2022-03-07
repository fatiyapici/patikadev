class cs_enum
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Days.Friday);
        Console.WriteLine((int) Days.Saturday);

        int degree = 32;
        if (degree <= (int) Weather.Warm)
            Console.WriteLine("You should wait to warm up for go outside");
        else if (degree >= (int) Weather.Hot)
            Console.WriteLine("The weather is too hot for go outside");
        else if (degree >= (int) Weather.Normal && degree < (int) Weather.Hot)
            Console.WriteLine("Weather is so good. Lets go outside");
    }
}

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Weather
{
    Cold = 5,
    Normal = 20,
    Warm = 25,
    Hot = 30
}