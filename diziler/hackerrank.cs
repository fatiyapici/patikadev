public class hackerrank
{
    public static void solution()
    {
        System.Console.WriteLine("Please enter want to array lenght");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];

        int negativeCounter, zeroCounter, positiveCounter;
        negativeCounter = zeroCounter = positiveCounter = 0;

        int numberOutput;
        string input = Console.ReadLine();
        var seperatedNumbers = input.Trim().Split(' ');

        for (int i = 0; i < seperatedNumbers.Length; i++)
        {
            if (!Int32.TryParse(seperatedNumbers[i], out numberOutput))
            {
                Console.WriteLine("Exception throwing.");
            }
            else
            {
                array[i] = numberOutput;
                if (array[i] < 0)
                    negativeCounter++;
                else if (array[i] > 0)
                    positiveCounter++;
                else
                    zeroCounter++;
            }
        }

        System.Console.WriteLine(((decimal) positiveCounter / arrayLenght).ToString("N6"));
        System.Console.WriteLine(((decimal) negativeCounter / arrayLenght).ToString("N6"));
        System.Console.WriteLine(((decimal) zeroCounter / arrayLenght).ToString("N6"));
    }
}