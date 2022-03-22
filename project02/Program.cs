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
                          "(1) Board Listelemek\n" +
                          "(2) Board'a Kart Eklemek\n" +
                          "(3) Board'dan Kart Silmek\n" +
                          "(4) Kart Taşımak");
        switch (ValidInput(1, 4))
        {
            case 1:
                Board.ListBoard();
                Homepage();
                break;
            case 2:
                Board.AddCardToBoard();
                Homepage();
                break;
            case 3:
                Board.DeleteCardToBoard();
                Homepage();
                break;
            case 4:
                Board.MoveCardOnBoard();
                Homepage();
                break;
        }
    }

    public static int ValidInput(int lowerLimit, int higherLimit)
    {
        string input;
        int output;
        bool isValidInput;
        do
        {
            input = Console.ReadLine();
            isValidInput = int.TryParse(input, out output);
            if (!isValidInput)
            {
                Console.WriteLine("Geçersiz giriş yaptınız. Lütfen " + lowerLimit + " ile " + higherLimit +
                                  " sayıları arasında seçim yapınız.");
            }
        } while (!isValidInput && !(output >= lowerLimit && output <= higherLimit));

        return output;
    }

    public static int ValidInput()
    {
        string input;
        int output;
        bool isValidInput;
        do
        {
            input = Console.ReadLine();
            isValidInput = int.TryParse(input, out output);
        } while (!isValidInput);

        return output;
    }

    public static string UppercaseFirst(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }

        return char.ToUpper(s[0]) + s.Substring(1);
    }
}