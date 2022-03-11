using interfaceSample;

class Program
{
    public static void Main(string[] args)
    {
        Focus focus = new Focus();
        Console.WriteLine(focus.WhichBrand().ToString());
        Console.WriteLine(focus.HowManyHasWhell());
        Console.WriteLine(focus.WhatIsTheStandartColor().ToString());

        Civic civic = new Civic();
        Console.WriteLine(civic.WhichBrand().ToString());
        Console.WriteLine(civic.HowManyHasWhell());
        Console.WriteLine(civic.WhatIsTheStandartColor().ToString());

        NewFocus newFocus = new NewFocus();
        Console.WriteLine(newFocus.WhichBrand().ToString());
        Console.WriteLine(newFocus.HowManyHasWhell());
        Console.WriteLine(newFocus.WhatIsTheStandartColor().ToString());

        NewCivic newCivic = new NewCivic();
        Console.WriteLine(newCivic.WhichBrand().ToString());
        Console.WriteLine(newCivic.HowManyHasWhell());
        Console.WriteLine(newCivic.WhatIsTheStandartColor().ToString());
        
    }
}