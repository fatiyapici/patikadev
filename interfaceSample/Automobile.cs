namespace interfaceSample;

public abstract class Automobile
{
    public int HowManyHasWhell()
    {
        return 4;
    }

    public virtual Color WhatIsTheStandartColor()
    {
        return Color.White;
    }

    public abstract Brand WhichBrand();
}