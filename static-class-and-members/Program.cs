class static_class_and_members
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Employee.EmployeeCounter);
        Employee worker01 = new Employee("Fatih","Yapici","Software Developer");
        Console.WriteLine(Employee.EmployeeCounter);
    }
}

class Employee
{
    private static int employeeCounter;

    private string Name;
    private string Surname;
    private string Departmant;

    public Employee(string name, string surname, string departmant)
    {
        Name = name;
        Surname = surname;
        Departmant = departmant;
        employeeCounter++;
    }

    static Employee()
    {
        employeeCounter = 0;
    }

    public static int EmployeeCounter
    {
        get => employeeCounter;
    }
}