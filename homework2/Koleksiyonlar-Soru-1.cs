using System.Collections;

namespace homework2;

public class Koleksiyonlar_Soru_1
{
    public void question1()
    {
        ArrayList list = new ArrayList();
        ArrayList primeList = new ArrayList();
        ArrayList notPrimeList = new ArrayList();

        int number;

        // 20 element adding a one arrayList (only int values)
        for (int i = 0; i < 20; i++)
        {
            string input = Console.ReadLine();
            while (!int.TryParse(input, out number) && number < 0)
            {
                input = Console.ReadLine();
            }

            list.Add(number);
        }

        // prime numbers and not prime numbers separate to 2 arrayList
        foreach (int item in list)
        {
            if (IsPrime(item))
                primeList.Add(item);
            else
                notPrimeList.Add(item);
        }

        // sorting and reversing
        primeList.Sort();
        primeList.Reverse();

        notPrimeList.Sort();
        notPrimeList.Reverse();

        int sum = 0;

        // higher than lower printing, counting array and average calculating
        Console.WriteLine("Prime List higher than lower");
        for (int i = 0; i < primeList.Count; i++)
        {
            Console.Write(primeList[i] + " \n");
        }

        foreach (int item in primeList)
        {
            sum += item;
        }

        Console.WriteLine("Count: " + primeList.Count + " Average: " + sum / primeList.Count);

        Console.WriteLine("Not prime list higher than lower");
        for (int i = 0; i < notPrimeList.Count; i++)
        {
            Console.Write(notPrimeList[i] + " \n");
        }

        foreach (int item in notPrimeList)
        {
            sum += item;
        }

        Console.WriteLine("Count: " + notPrimeList.Count + " Average: " + sum / notPrimeList.Count);
    }

    // number isPrime method
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int) Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}