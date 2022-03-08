namespace inheritance;

public class Plants : Bios
{
    protected void Photosynthesis()
    {
        Console.WriteLine("Plants do photosynthesis");
    }

    public override void Reflection()
    {
        // base.Reflection();
        Console.WriteLine("Plants react to sun");
    }
}

class SeedPlants : Plants
{
    public SeedPlants()
    {
        base.Photosynthesis();
        base.Nutrition();
        base.Defecation();
        base.Respiration();
        base.Reflection();
    }

    public void SeededReproduction()
    {
        Console.WriteLine("Seeded plants reproduction with seeds");
    }
}

class SeedlessPlants : Plants
{
    public SeedlessPlants()
    {
        base.Photosynthesis();
    }

    public void SporeReproduction()
    {
        Console.WriteLine("Seedless plants reproduction with spore");
    }
}