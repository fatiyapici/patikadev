using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Assign

            int a = 5;
            int b = 10;

            a += 5;
            b += 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 15;
            int d = 20;

            c *=2;
            d /=2;

            Console.WriteLine(c);
            Console.WriteLine(d);

            //Logical Operators

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if (isSuccess || isCompleted)
            {
                System.Console.WriteLine("Great");
            }
            if (isSuccess && !isCompleted)
            {
                System.Console.WriteLine("Fine");
            }

            // Relational Operators

            

            int x = 1;
            int y = 2;

            bool result = x<y;
            System.Console.WriteLine(result);

            result = x>y;
            System.Console.WriteLine(result);

            result = x>=y;
            System.Console.WriteLine(result);

            result = x<=y;
            System.Console.WriteLine(result);

            result = x==y;
            System.Console.WriteLine(result);

            result = x!=y;
            System.Console.WriteLine(result);


            System.Console.WriteLine("Please press 'ENTER' to close this window");
            Console.ReadLine();
        }
    }
}