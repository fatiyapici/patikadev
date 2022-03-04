using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("Please enter a number.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Entered number: " + sayi);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            System.Console.WriteLine("First try block is successfully completed.");
        }

        try
        {
            // int a = int.Parse(null);                 ---> First catch block
            // int a = int.Parse("test");               ---> Second catch block
            // int a = int.Parse("555555555555555");    ---> Third catch block
        }
        catch (ArgumentNullException ex)
        {
            System.Console.WriteLine("Entered null value.");
            System.Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine("Invalid data type.");
            System.Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            System.Console.WriteLine("Entered value is out of bound.");
            System.Console.WriteLine(ex);
        }
        finally
        {
            System.Console.WriteLine("Second try block is successfully completed.");
        }

        forExit();
    }
    public static void forExit()
    {
        System.Console.WriteLine("Please press any key to close this window.");
        Console.ReadLine();
    }
}