namespace inheritance;

public class Animals:Bios
{
    protected void Adaptation()
    {
        Console.WriteLine("Animals can adapt");
    }

    public override void Reflection()
    {
        base.Reflection();
        Console.WriteLine("Animals react to contact");
    }
}

class Reptiles:Animals
{
    public Reptiles()
    {
        base.Adaptation();
    }
    public void Crawl()
    {
        Console.WriteLine("Reptiles are crawling");
    }
}

class Birds:Animals
{
    public Birds()
    {
        base.Adaptation();
        base.Nutrition();
        base.Defecation();
        base.Respiration();
        base.Reflection();
    }
    public void Fly()
    {
        Console.WriteLine("Birds are fly");
    }
}