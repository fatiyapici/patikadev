using inheritance;

class Program
{
    public static void Main(string[] args)
    {
        SeedPlants seedPlant = new SeedPlants();
        
        seedPlant.SeededReproduction();

        Birds seagull = new Birds();
        
        seagull.Fly();
    }
}