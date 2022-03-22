namespace Project02;

public class Board
{
    private Line line;

    public Line Line
    {
        get => line;
        set => line = value;
    }

    public void ListBoard()
    {
        foreach (var line in Enum.GetValues(typeof(Line)))
        {
            Console.WriteLine(Enum.GetName(typeof(Line), line) + " Line\n" +
                              "************************");
            int boardHasNotCardCounter = 0;

            foreach (var card in Card.Cards)
            {
                if (card.LineProp.Equals(line))
                {
                    Console.WriteLine("Başlık      : " + card.Title + "\n" +
                                      "İçerik      : " + card.Content + "\n" +
                                      "Atanan Kişi : " + card.PersonId + "\n" +
                                      "Büyüklük    : " + card.Size + "\n" +
                                      "-");
                    boardHasNotCardCounter++;
                }
            }

            if (boardHasNotCardCounter == 0)
                Console.WriteLine("~BOS~");
        }
    }

    public void AddCardToBoard()
    {
        Card card = new Card();
        Console.WriteLine("Başlık Giriniz                                  : ");
        card.Title = Console.ReadLine();
        Console.WriteLine("İçerik Giriniz                                  :");
        card.Content = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        int sizeInput = Program.ValidInput(1, 5);
        card.Size = (Size) sizeInput;
        Console.WriteLine("Kişi Seçiniz                                    : ");
        bool idValidation = false;
        int idToBeAssigned;
        do
        {
            idToBeAssigned = Program.ValidInput();

            foreach (var person in Person.Persons)
            {
                if (person.Id.Equals(idToBeAssigned))
                    idValidation = false;
                else
                {
                    idValidation = true;
                    break;
                }
            }
        } while (!idValidation);

        card.PersonId = idToBeAssigned;
        Card.Cards.Add(card);
        Program.Homepage();
    }

    public void DeleteCardToBoard()
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n" +
                          "Lütfen kart başlığını yazınız:  ");
        string input = Console.ReadLine();
        input = input.ToLower();
        foreach (var card in Card.Cards)
        {
            card.Title.ToLower();
            if (input.Equals(card.Title))
            {
                Card.Cards.Remove(card);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                                  "* Silmeyi sonlandırmak için : (1)\n" +
                                  "* Yeniden denemek için : (2)");
                int selection = Program.ValidInput(1, 2);
                if (selection == 1)
                    Program.Homepage();
                else
                    DeleteCardToBoard();
            }
        }
    }

    public void MoveCardOnBoard()
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n" +
                          "Lütfen kart başlığını yazınız:  ");
        string input = Console.ReadLine();
        input = input.ToLower();
        foreach (var card in Card.Cards)
        {
            card.Title = card.Title.ToLower();
            if (card.Title.Equals(input))
            {
                card.Title = Program.UppercaseFirst(card.Title);
                Console.WriteLine("Başlık      : " + card.Title + "\n" +
                                  "İçerik      : " + card.Content + "\n" +
                                  "Atanan Kişi : " + card.PersonId + "\n" +
                                  "Büyüklük    : " + card.Size);
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: \n" +
                                  "(1) TODO \n" +
                                  "(2) IN PROGRESS \n" +
                                  "(3) DONE ");

                int selection = Program.ValidInput(1, 3);
                if (selection == 1)
                    card.LineProp = Line.TODO;
                else if (selection == 2)
                    card.LineProp = Line.INPROGRESS;
                else
                    card.LineProp = Line.DONE;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                                  "* İşlemi sonlandırmak için : (1)\n" +
                                  "* Yeniden denemek için : (2)");

                int selection = Program.ValidInput(1, 2);
                if (selection == 1)
                    Program.Homepage();
                else
                    MoveCardOnBoard();
            }
        }
        Program.Homepage();
    }
}