class creator_methods
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("Fatih", "Yapici", 3296, "Human Resources Department");

        employee1.EmployeeInformation();

        Employee employee2 = new Employee();
        // if method takes no parameters
        employee2.Name = "Burak";
        employee2.No = 5996;
        employee2.Department = "Purchasing Department";

        employee2.EmployeeInformation();

        Employee employee3 = new Employee("Baran");

        employee3.EmployeeInformation();
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public Employee(string name, string surname, int no, string department)
        {
            Name = name;
            Surname = surname;
            No = no;
            Department = department;
        }

        public Employee()
        {
        }

        public Employee(string name)
        {
            Name = name;
        }

        public void EmployeeInformation()
        {
            Console.WriteLine("Employee Name:{0}", Name);
            Console.WriteLine("Employee Surname:{0}", Surname);
            Console.WriteLine("Employee Surname:{0}", No);
            Console.WriteLine("Employee Surname:{0}", Department);
        }
    }
}