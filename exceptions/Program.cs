namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Bir sayı giriniz.");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayı: " + sayi1);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                System.Console.WriteLine("İşlem tamamlandı.");
                //Hata olsun veya olmasın her durumda yapılacak olan işlem
            }

            try
            {
                int a = int.Parse("100");
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Boş bir değer girdiniz.");
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Girdiğiniz değer -2,147,483,648 ile 2,147,483,647 arasında olmalıdır.");
            }
        }
    }
}
