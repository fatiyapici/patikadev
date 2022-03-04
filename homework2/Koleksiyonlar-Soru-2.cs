using System.Collections;

namespace homework2;

public class Koleksiyonlar_Soru_2
{
    public void question2()
    {
        int n = 20;
        ArrayList number = new ArrayList();

        for (int i = 0; i < n; i++)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            number.Add(input);
        }

        number.Sort();

        ArrayList lowerNumbers = new ArrayList();

        for (int i = 0; i < 3; i++)
        {
            lowerNumbers.Add(number[i]);
        }

        int lowerSum = 0;
        foreach (var num in lowerNumbers)
        {
            lowerSum += (int) num;
        }

        number.Reverse();
        ArrayList higherNumbers = new ArrayList();

        for (int i = 0; i < 3; i++)
        {
            higherNumbers.Add(number[i]);
        }

        int higherSum = 0;
        foreach (var num in higherNumbers)
        {
            higherSum += (int) num;
        }

        Console.WriteLine("Lower three numbers average is: " + lowerSum / 3);
        Console.WriteLine("Higher three numbers average is: " + higherSum / 3);
        Console.WriteLine("Higher three and lower three numbers average summary is: " + lowerSum / 3 + higherSum / 3);
    }
}