namespace inheritance;

public class Bios
{
    protected void Nutrition()
    {
        Console.WriteLine("Bios are fed");
    }

    protected void Respiration()
    {
        Console.WriteLine("Bios are breathing");
    }

    protected void Defecation()
    {
        Console.WriteLine("Bios are defecate");
    }

    public virtual void Reflection()
    {
        Console.WriteLine("Bios react");
    }
}