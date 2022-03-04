namespace donguler_while_foreach
{
    class Program
    {
        public static void Main(string[] args)
        {
            // print start at 1 to input get average in console(input number include)
            System.Console.WriteLine("Please enter a number.");
            int n = Convert.ToInt32(System.Console.ReadLine());
            int counter = 1;
            int sum = 0;
            while (counter <= n)
            {
                sum += counter;
                counter++;
            }
            System.Console.WriteLine(sum / n);

            //print a to z char in console(last char is not include)
            char character = 'a';
            while (character < 'z')
            {
                System.Console.WriteLine(character);
                character++;
            }

            // FOREACH

            string[] cars = { "BMW", "MERCEDES", "FORD", "FIAT", "PEUGEOT" };
            foreach (var car in cars)
            {
                System.Console.WriteLine(car);
            }

        }
    }
}