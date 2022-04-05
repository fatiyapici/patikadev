namespace Project02;

class Program
{
    public static void Main(string[] args)
    {
        Homepage();
    }

    public static void Homepage()
    {
        Board Board = new Board();
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                          "*******************************************\n" +
                          "(1) Board'a Kart Eklemek\n" +
                          "(2) Board'dan Kart Silmek\n" +
                          "(3) Board Listelemek\n" +
                          "(4) Kart Taşımak");

        //Homepage'e vb. yönlendirmeleri hem metodların
        //içinde yapmışsın hem de burada yapmışsın.
        //Bu kullanıcı farklı bir giriş yapsa bile istemeden fazladan metodları tekrar
        //çalıştırıp kullanıcının önüne bilgi getirecek
        //kullandığın board metodları başka sayfalara da yönlendirmediği için
        //buradaki her case'de Homepage() metodunu çağıracaksan
        
        //ana metodlara yönlendirmeler vs. gerçek uygulamalarda farklı çalışır
        //sende sadece 2 sayfa var şu anda aslında, Homepage ve Board
        //bu yüzden çok anlaşılmıyor ama bir sayfaya yönlendirme yapacaksan şu an yazdığım gibi
        //metod içerisinden yapmak daha sağlıklıdır
        //çünkü ikiden fazla sayfa olan bir proje olsaydı birbirlerinin arasında hangi sayfaya
        //gideceğine mevcut çalışan metodun karar vermesi gerekecekti.

    
        switch (InputHelper.ValidIntInput(1, 4))
        {
            case 1:
                Board.AddCardToBoard();
                break;
            case 2:
                Board.DeleteCardToBoard();
                break;
            case 3:
                Board.ListBoard();
                break;
            case 4:
                Board.MoveCardOnBoard();
                break;
        }
    }
}