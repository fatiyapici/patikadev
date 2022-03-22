namespace Project02;

public class Person
{
    private int id;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public static List<Person> Persons = new List<Person>()
    {
        new Person()
        {
            Id = 1
        },
        new Person()
        {
            Id = 2
        },
        new Person()
        {
            Id = 3
        }
    };
}