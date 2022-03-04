public class Program
{
    public static void Main(string[] args)
    {
        fourthQ();
    }

    public static void firstQ()
    {
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var i in arr)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void secondQ()
    {
        // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var i in arr)
        {
            if (i == m || i % m == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void thirdQ()
    {
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new String[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Array.Reverse(arr);

        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }

    public static void fourthQ()
    {
        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        string str = Console.ReadLine();
        string[] strSplit = str.Split(' ');
        Console.WriteLine(strSplit.Length);
        
        int letterCounter = 0;
        foreach (var word in strSplit)
        {
            letterCounter += word.Length;
        }

        Console.WriteLine(letterCounter);
    }
}