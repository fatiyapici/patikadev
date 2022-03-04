namespace diziler_array_sinifi_metodlari;

public class hackerrankFirstQ
{
    public static void firstQ()
    {
        int birthdayCakeCandles = int.Parse(Console.ReadLine()); // length input
        int[] candles = new int[birthdayCakeCandles]; // creating array with length
        int candleOutput; // must be candle size
        string input = Console.ReadLine(); // candles size with spaces
        var seperatedCandles = input.Trim().Split(' '); // decontamination from the spaces 
        for (int i = 0; i < seperatedCandles.Length; i++) // every single candle add to candles array
        {
            if (!Int32.TryParse(seperatedCandles[i], out candleOutput))
            {
                Console.WriteLine("Exception throwing.");
            }
            else
            {
                candles[i] = candleOutput;
            }
        }

        int maxValue = candles.Max();
        int maxCounter = 0;
        for (int i = 0; i < candles.Length; i++)
        {
            if (maxValue == candles[i])
            {
                maxCounter++;
            }
        }

        Console.WriteLine(maxCounter);
    }
}

public class hackerrankSecondQ
{
    public static void secondQ()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];
        int numberOutput;
        string input = Console.ReadLine();
        var seperatedNumber = input.Trim().Split(' ');
        for (int i = 0; i < seperatedNumber.Length; i++)
        {
            if (!Int32.TryParse(seperatedNumber[i], out numberOutput))
            {
                Console.WriteLine("Exception throwing");
            }
            else
            {
                numbers[i] = numberOutput;
            }
        }

        int sumNumbers = 0;
        foreach (var number in numbers)
        {
            sumNumbers += number;
        }

        Console.WriteLine(sumNumbers);
    }
}

public class hackerrankThirdQ
{
    public static void thirdQ()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];
        int numberOutput;
        string input = Console.ReadLine();
        var seperatedNumber = input.Trim().Split(' ');
        for (int i = 0; i < seperatedNumber.Length; i++)
        {
            if (!Int32.TryParse(seperatedNumber[i], out numberOutput))
            {
                Console.WriteLine("Exception throwing");
            }
            else
            {
                numbers[i] = numberOutput;
            }
        }

        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i != (numbers.Length - 1))
            {
                Console.Write(" ");
            }
        }
    }
}

public class hackerrankFourthQ
{
    public static void fourthQ()
    {
        {
            int arrayLenght = int.Parse(Console.ReadLine());
            long[] numbers = new long[arrayLenght];
            int numberOutput;
            string input = Console.ReadLine();
            var seperatedNumber = input.Trim().Split(' ');
            for (int i = 0; i < seperatedNumber.Length; i++)
            {
                if (!Int32.TryParse(seperatedNumber[i], out numberOutput))
                {
                    Console.WriteLine("Exception throwing");
                }
                else
                {
                    numbers[i] = numberOutput;
                }
            }

            long veryBigSum = numbers.Sum();
            Console.WriteLine(veryBigSum);
        }
    }
}

public class hackerrankFifthQ
{
    public static int[] SeperateAndGet()
    {
        int pointOutput;
        string input = Console.ReadLine();
        var seperatedPoint = input.Trim().Split(' ');
        int[] points = new int[seperatedPoint.Length];
        for (int i = 0; i < seperatedPoint.Length; i++)
        {
            if (!Int32.TryParse(seperatedPoint[i], out pointOutput))
            {
                Console.WriteLine("Exception throwing");
            }
            else
            {
                points[i] = pointOutput;
            }
        }

        return points;
    }

    public static int[] calcPoints(int[] alicePoint, int[] bobPoints)
    {
        int[] result = new int[2];
        if (alicePoint.Length != bobPoints.Length)
        {
            throw new Exception("Points not valid");
        }

        for (int i = 0; i < alicePoint.Length; i++)
        {
            if (alicePoint[i] > bobPoints[i])
            {
                result[0] += 1;
            }
            else if (alicePoint[i] < bobPoints[i])
            {
                result[1] += 1;
            }
        }

        return result;
    }
}

public class hackerrankSixthQ
{
    public static List<int> swap(List<int> a, int index1, int index2)
    {
        var temp = a[index1];
        a[index1] = a[index2];
        a[index2] = temp;
        return a;
    }

    public static void bubbleSort()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int numberOfSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal


            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    a = swap(a, j, j + 1);
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[a.Count - 1]);
    }
}

public class hackerrankSeventh
{
    public static void solution()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        // your code goes here
        int[] birdCounts = new int[n];

        foreach (var type in types)
            birdCounts[type]++;

        int maxValue = birdCounts.Max();
        int maxType = birdCounts.ToList().IndexOf(maxValue);

        Console.WriteLine(maxType);
    }
}