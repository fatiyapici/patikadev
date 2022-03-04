using System;

class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;

        // Expression = Check the condition 
        // 'Month' example

        switch (month)
        {
            // Single case usage
            case 1:
                System.Console.WriteLine("January");
                break;
            case 2:
                System.Console.WriteLine("February");
                break;
            case 3:
                System.Console.WriteLine("March");
                break;
            case 4:
                System.Console.WriteLine("April");
                break;
            default:
                System.Console.WriteLine("Invalid value.");
                break;
        }
        switch (month)
        {
            // Multiple case usage
            case 12:
            case 1:
            case 2:
                System.Console.WriteLine("On Winter!");
                break;
            case 3:
            case 4:
            case 5:
                System.Console.WriteLine("On Spring!");
                break;
            case 6:
            case 7:
            case 8:
                System.Console.WriteLine("On Summer!");
                break;
            case 9:
            case 10:
            case 11:
                System.Console.WriteLine("On Autumn!");
                break;
            default:
                break;
        }
    }
}