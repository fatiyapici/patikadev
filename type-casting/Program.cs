using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //~~~~~ Implicit Conversion (Bilinçsiz Dönüşüm) ~~~~~

            byte b1 = 5;
            sbyte sb1 = 10;
            short s1 = 15;

            int i1 = b1 + sb1 + s1;
            System.Console.WriteLine("i1: " + i1);

            long l1 = i1;
            System.Console.WriteLine("l1: " + l1);

            float f1 = l1;
            System.Console.WriteLine("f1: " + f1);

            string st1 = "fati";
            char c1 = 'c';
            object o1 = st1 + c1;
            System.Console.WriteLine("o1: " + o1);

            //~~~~~ Explicit Conversion(Bilinçli Dönüşüm) ~~~~~

            int i2 = 4;
            byte b2 = (byte)i2;
            System.Console.WriteLine("b2: " + b2);

            int i3 = 100;
            byte b3 = (byte)i3;
            System.Console.WriteLine("i3: " + i3);

            float f2 = 10.3f;
            byte b4 = (byte)f2;
            System.Console.WriteLine("b4: " + b4);

            //~~~~~ ToString Methodları ~~~~~

            int i4 = 6;
            string st2 = i4.ToString();
            System.Console.WriteLine("st2: " + st2);

            string st3 = f2.ToString();
            System.Console.WriteLine("st3: " + st3);

            //~~~~~ System Convert ~~~~~

            string st4 = "10", st5 = "20";
            int i5, i6;
            int sum;

            i5 = Convert.ToInt32(st4);
            i6 = Convert.ToInt32(st5);

            sum = i5 + i6;
            System.Console.WriteLine("sum: " + sum);

            //~~~~~ Parse ~~~~~
            parseMethod();

        }

        public static void parseMethod()
        {
            string metin1 = "10";
            string metin2 = "20";
            int sayi1;
            double sayi2;
            sayi1 = Int32.Parse(metin1);
            sayi2 = double.Parse(metin2);

            System.Console.WriteLine("sayi1: " + sayi1);
            System.Console.WriteLine("sayi2: " + sayi2);

        }
    }
}