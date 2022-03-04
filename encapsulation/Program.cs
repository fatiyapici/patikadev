class encapsulation
{
    public static void Main(string[] args)
    {
        Students student01 = new Students();
        student01.Name = "Fatih";
        student01.Surname = "Yapici";
        student01.No = 123;
        student01.Grade = 5;
        student01.StudentInformation();
        student01.IncreaseGrade();
        student01.StudentInformation();
        Students student02 = new Students("Burak", "Alm", 321, 1);
        student02.DecreaseGrade();
        student02.StudentInformation();
    }
}

class Students
{
    private string name;
    private string surname;
    private int no;
    private int grade;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Surname
    {
        get => surname;
        set => surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int No
    {
        get => no;
        set => no = value;
    }

    public int Grade
    {
        get => grade;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Class cannot be less than '1'.");
                grade = 1;
            }
            else
                grade = value;
        }
    }

    public Students(string name, string surname, int no, int grade)
    {
        this.name = name;
        this.surname = surname;
        this.no = no;
        this.grade = grade;
    }

    public Students()
    {
    }

    public void StudentInformation()
    {
        Console.WriteLine("Student name: {0}", Name);
        Console.WriteLine("Student surname: {0}", Surname);
        Console.WriteLine("Student no: {0}", No);
        Console.WriteLine("Student grade: {0}", Grade);
    }

    public void IncreaseGrade()
    {
        this.Grade = this.Grade + 1;
    }

    public void DecreaseGrade()
    {
        this.Grade = this.Grade - 1;
    }
}