using System;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        // ~~~~~ Multiple line if-else if-else display ~~~~~

        if (time >= 5 && time <= 12)
        {
            System.Console.WriteLine("Good morning");
        }
        else if (time <= 17)
        {
            System.Console.WriteLine("Have a good day.");
        }
        else
        {
            System.Console.WriteLine("Good night.");
        }

        // ~~~~~ Single line if-else if-else display ~~~~~

        string sonuc = time <= 17 ? "Have a good day." : "Good night";

        sonuc = time >= 5 && time <= 11 ? "Good morning." : time <= 17 ? "Have a good day." : "Good night.";

        System.Console.WriteLine(sonuc);

        hackerrank.weirdOrNotWeird();

        forExit();
    }
    public static void forExit()
    {
        System.Console.WriteLine("Press any key to close this window.");
        System.Console.ReadLine();
    }
}
