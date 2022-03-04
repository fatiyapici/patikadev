using System.Collections;

namespace homework2;

public class Koleksiyonlar_Soru_3
{
    public void question3()
    {
        string input = Console.ReadLine();
        ArrayList vowel = new ArrayList();
        foreach (var letter in input)
        {
            if (letter.ToString().Contains("a") ||
                letter.ToString().Contains("e") ||
                letter.ToString().Contains("i") ||
                letter.ToString().Contains("o") ||
                letter.ToString().Contains("u"))
                vowel.Add(letter);
        }

        vowel.Sort();
        foreach (var letter in vowel)
        {
            Console.WriteLine(letter);
        }
    }
}