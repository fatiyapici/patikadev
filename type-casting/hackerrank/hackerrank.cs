using System;


class hackerrank
{
    //~~~~~Hackerrank "Solve Me First" example
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(solveMeFirst(a,b));

    }
    public static int solveMeFirst(int a, int b)
    {
        return a+b;
    }
}
