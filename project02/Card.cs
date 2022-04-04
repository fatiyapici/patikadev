using System.Collections;

namespace Project02;

public class Card
{
    private int id;
    private string title;
    private string content;
    private int personId;
    private Size size;
    private Line Line;


    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Content
    {
        get => content;
        set => content = value;
    }


    public int PersonId
    {
        get => personId;
        set => personId = value;
    }

    public Size Size
    {
        get => size;
        set => size = value;
    }

    public Line LineProp
    {
        get => Line;
        set => Line = value;
    }

    public static Card AddCard(Card card)
    {
        int validId = Cards.Count > 0 ? Cards.Max(x => x.id) + 1 : 0; 
        card.id = validId;

        Cards.Add(card);

        return card;
    }

    public static List<Card> Cards = new List<Card>();

    public void WriteCardInfo()
    {
        Console.WriteLine("Baslik      : " + Title + "\n" +
            "Icerik      : " + Content + "\n" +
            "Atanan Kisi : " + PersonId + "\n" +
            "Buyukluk    : " + Size + "\n");
    }
}