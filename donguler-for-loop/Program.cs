namespace donguler_for_loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Print to last input
            System.Console.WriteLine("Please enter a number.");
            int counter = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                if (i % 2 == 1)
                    System.Console.WriteLine(i);
            }

            // 0-1000 odd and even numbers summary
            int min = 0, max = 1000, sum = 0, oddSum = 0, evenSum = 0;

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }
            System.Console.WriteLine("Odd summary: " + oddSum);
            System.Console.WriteLine("Even summary: " + evenSum);

            //Break and continue conditional
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                System.Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                System.Console.WriteLine(i);
            }
        }
    }
}
