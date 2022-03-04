using diziler_array_sinifi_metodlari;

class Program
{
    public static void Main(string[] args)
    {
        var alicePoints = hackerrankFifthQ.SeperateAndGet();
        var bobPoints = hackerrankFifthQ.SeperateAndGet();
        var result = hackerrankFifthQ.calcPoints(alicePoints, bobPoints);
        Console.WriteLine(result[0] + " " + result[1]);
        
        Console.WriteLine("~~~~");
        
        hackerrankSixthQ.bubbleSort();

        Console.WriteLine("~~~~");
        // Sort 
        int[] numberArr = {23, 12, 4, 86, 72, 3, 11, 17};

        // non-sorted
        foreach (var number in numberArr)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("~~~~~");

        // sorted
        Array.Sort(numberArr);
        foreach (var number in numberArr)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("~~~~~");

        // set '0' intended of the array element
        Array.Clear(numberArr, 2, 2);
        foreach (var number in numberArr)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("~~~~~");

        // reverse
        Array.Reverse(numberArr);
        foreach (var number in numberArr)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("~~~~~");

        // indexOf
        Console.WriteLine(Array.IndexOf(numberArr, 3));

        Console.WriteLine("~~~~~");

        // resize
        Array.Resize(ref numberArr, 10);
        numberArr[8] = 11;
        Console.WriteLine(numberArr[8]);
    }
}