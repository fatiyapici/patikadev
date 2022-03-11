namespace interfaceSample;

public class Civic:IAutomobile
{
    public int HowManyHasWhell()
    {
        return 4;
    }

    public Brand WhichBrand()
    {
        return Brand.Honda;
    }

    public Color WhatIsTheStandartColor()
    {
        return Color.Black;
    }
}