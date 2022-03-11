namespace interfaceSample;

public class NewCivic : Automobile
{
    public override Brand WhichBrand()
    {
        return Brand.Honda;
    }

    public override Color WhatIsTheStandartColor()
    {
        return Color.Gray;
    }
}