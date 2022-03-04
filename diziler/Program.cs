namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array generating

            string[] colors = new string[5];

            string[] animals = {"Dog", "Cat", "Bird", "Lion", "Tiger"};

            int[] array;

            array = new int[5];

            // Array access and extension

            colors[3] = "Blue";
            array[3] = 10;

            // Print

            System.Console.WriteLine(animals[3]);
            System.Console.WriteLine(array[3]);
            System.Console.WriteLine(colors[3]);

            // Loops with array usage
            // Calculate average of the array

            System.Console.WriteLine("Please enter a array length");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());
            int[] arrayOne = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                System.Console.WriteLine("Please {0}. number.", i + 1);
                arrayOne[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            foreach (var number in arrayOne)
            {
                sum += number;
            }

            System.Console.WriteLine("Average: " + sum / arrayLenght);
        }
    }
}