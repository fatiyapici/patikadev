namespace interfaceSample;

public class Focus:IAutomobile
{
    public int HowManyHasWhell()
    {
        return 4;
    }

    public Brand WhichBrand()
    {
        return Brand.Ford;
    }

    public Color WhatIsTheStandartColor()
    {
        return Color.White;
    }
}