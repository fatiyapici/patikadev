class Constructors
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee();
        employee1.Name = "Fatih";
        employee1.Surname = "Yapıcı";
        employee1.No = 3296;
        employee1.Department = "Human Resources Depatment";
        employee1.EmployeeInformation();

        Employee employee2 = new Employee();
        employee2.Name = "Burak";
        employee2.No = 5996;
        employee2.Department = "Purchasing Department";

        employee2.EmployeeInformation();
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInformation()
        {
            Console.WriteLine("Employee Name:{0}", Name);
            Console.WriteLine("Employee Surname:{0}", Surname);
            Console.WriteLine("Employee Surname:{0}", No);
            Console.WriteLine("Employee Surname:{0}", Department);
        }
    }
}