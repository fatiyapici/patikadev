namespace Project02;

public class Board
{
    public void ListBoard()
    {
        foreach (var line in Enum.GetValues(typeof(Line)))
        {
            Console.WriteLine(Enum.GetName(typeof(Line), line) + " Line\n" +
                              "************************");

            //Foreach içinde listeyi sayıp boş mu diye kontrol etmek
            //biraz saçma geldi
            if (Card.Cards.Count <= 0)
            {
                Console.WriteLine("~BOS~");
                Program.Homepage();
                return;
            }

            //Filter Cards list
            //(Line) for casting
            var filteredCards = Card.Cards.Where(x => x.LineProp == (Line)line);
            if (filteredCards == null)
            {
                Program.Homepage();
                return;
            }

            foreach (var card in Card.Cards)
            {
                card.WriteCardInfo();
            }

            Program.Homepage();
        }
    }

    public void AddCardToBoard()
    {
        //Readibility is important
        Card card = new Card();
        Console.WriteLine("Başlık Giriniz                                  : ");
        card.Title = InputHelper.ValidStringInput();

        Console.WriteLine("İçerik Giriniz                                  :");
        card.Content = InputHelper.ValidStringInput();

        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        int sizeInput = InputHelper.ValidIntInput(1, 5);
        card.Size = (Size)sizeInput;

        Console.WriteLine("Kişi Seçiniz                                    : ");
        bool idValidation = false;
        int idToBeAssigned;
        do
        {
            idToBeAssigned = InputHelper.ValidIntInput();
            idValidation = !Person.Persons.Any(x => x.Id == idToBeAssigned);
        } while (!idValidation);

        card.PersonId = idToBeAssigned;
        card = Card.AddCard(card);

        Program.Homepage();
    }

    public void DeleteCardToBoard()
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n" +
                          "Lütfen kart başlığını yazınız:  ");

        //Burada input'un dolu geldiğini doğrulayana kadar kullanıcıdan alman gerekirdi
        //Ben sadece kontrolü yaparak bıraktım
        string input = InputHelper.ValidStringInput();
        input = input.Trim().ToLower();

        var matchedCard = Card.Cards.FirstOrDefault(x => x.Title.ToLower().Equals(input));
        if (matchedCard != null)
        {
            Card.Cards.Remove(matchedCard);
            Console.WriteLine("Başarıyla silindi.");
            Program.Homepage();
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                                  "* Silmeyi sonlandırmak için : (1)\n" +
                                  "* Yeniden denemek için : (2)");
            int selection = InputHelper.ValidIntInput(1, 2);
            if (selection == 1)
                Program.Homepage();
            else
                DeleteCardToBoard();
        }

        //Bu kısımda çok fazla sorun vardı
        //Döngüde sadece ilk elemana göre işlem yapmak mantıken çok yanlış
        //Bütün elemanlar arasında eşleşen var mı diye bakıp ona göre işlem yapman gerekirdi
        //Ayrıca yazdığın kod ile kullanıcı sürekli farklı metodları çağırarak kendi metodunu erişebiliyor
        //Yani recursive metod olarak çalıştırılabilir
    }

    public void MoveCardOnBoard()
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n" +
                          "Lütfen kart başlığını yazınız:  ");

        string input = InputHelper.ValidStringInput();
        input = input.Trim().ToLower();

        var matchedCard = Card.Cards.FirstOrDefault(x => x.Title.ToLower().Equals(input));
        if (matchedCard != null)
        {
            // kullanıcının girdiği title için kendi listendeki kart'ın başlığını değiştirerek
            // kontrol etmek çok yanlış olmuş
            // card gibi objelere getter setter koymak bunu önlemek içinken
            // sen kasıtlı olarak title'ını değiştirerek kontrol ediyorsun
            // card'ın title'ını bir değişkene kopyalayıp orada işlem yapmak
            // çok daha mantıklı değil mi?

            matchedCard.WriteCardInfo();

            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: \n" +
                              "(1) TODO \n" +
                              "(2) IN PROGRESS \n" +
                              "(3) DONE ");

            int selection = InputHelper.ValidIntInput(1, 3);
            //Enumu değerinden direkt cast edebilirsin
            //Enum'lar mantıken sadece okunabilir sayılardır
            matchedCard.LineProp = (Line)(selection - 1);
            Program.Homepage();
        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                                  "* İşlemi sonlandırmak için : (1)\n" +
                                  "* Yeniden denemek için : (2)");

            int selection = InputHelper.ValidIntInput(1, 2);
            if (selection == 1)
                Program.Homepage();
            else
                MoveCardOnBoard();
        }

        //Burada kurduğun döngüde de yukarıdaki metoddaki döngündeki mantık hatasının aynısı vardı
        //Çok temel bi mantık hatası, burada yaptığın hatayı bence iyice anlaman lazım
    }
}