namespace metods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             access_point return_type methodName(parameterList, arguments)
             { 
                ...commands || return;
             }
            */

            int a = 2;
            int b = 3;
            int result = Summary(a, b);

            Console.WriteLine(result);
            Console.WriteLine(Summary(a, b));

            var nonStaticMethods = new nonStaticMethods();

            int result2 = nonStaticMethods.IncreaseAndSum(ref a, ref b);
            Console.WriteLine(result2);

            int summary = nonStaticMethods.IncreaseAndSum(ref a, ref b);
            nonStaticMethods.PrintScreen(summary.ToString());

            nonStaticMethods.PrintScreen(Summary(a, b).ToString());
            
            nonStaticMethods.PrintScreen(result.ToString());
            
            nonStaticMethods.PrintScreen(result2.ToString());
        }

        public static int Summary(int x, int y)
        {
            return (x + y);
        }
    }

    public class nonStaticMethods
    {
        public void PrintScreen(string input)
        {
            Console.WriteLine(input);
        }

        public int IncreaseAndSum(ref int x, ref int y)
        {
            x += 1;
            y += 1;
            return x + y;
        }
    }
}