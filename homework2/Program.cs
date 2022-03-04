using System.Collections;

namespace homework2;

public class Program
{
    public static void Main(string[] args)
    {
        Koleksiyonlar_Soru_1 col1 = new Koleksiyonlar_Soru_1();
        col1.question1();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~");
        Koleksiyonlar_Soru_2 col2 = new Koleksiyonlar_Soru_2();
        col2.question2();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~");
        Koleksiyonlar_Soru_3 col3 = new Koleksiyonlar_Soru_3();
        col3.question3();
    }
}