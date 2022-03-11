namespace interfaceSample;

public class Corolla:IAutomobile
{
    public int HowManyHasWhell()
    {
        return 4;
    }

    public Brand WhichBrand()
    {
        return Brand.Toyota;
    }

    public Color WhatIsTheStandartColor()
    {
        return Color.White;
    }
}