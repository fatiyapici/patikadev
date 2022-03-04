class class_concept
{
    public static void Main(string[] args)
    { 
        /*
         Notes
        class ClassName {
        [Access
        Decisive(

        public,private,internal,protected)] [Value
        Type(int, string, bool, char..)] Name;

        [Access
        Decisive(public,private,internal,protected)] [Return
        Type(int, string, bool, char..)] Method Name
        [Parameter List(named, ref, out, default, dynamic, value, params)] {
        Method Commands
        }
        }
        */

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

    class Hackerrank
    {
        public void InitialAge()
        {
            int T = Int32.Parse(Console.ReadLine());
            int age;
            for (int i = 0; i < T; i++)
            {
                age = Int32.Parse(Console.ReadLine());

                if (age < 13)
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Age is not valid, setting age to 0.");
                        age = 0;
                    }

                    Console.WriteLine("You are young.");
                    if (age + 3 < 13)
                        Console.WriteLine("You are young.");
                    else if (age + 3 >= 13)
                        Console.WriteLine("You are a teenager.");
                    else
                        Console.WriteLine("You are old.");
                }

                if (age >= 13)
                {
                    Console.WriteLine("You are a teenager.");
                    if (age + 3 <= 18)
                        Console.WriteLine("You are a teenager.");
                    else if (age + 3 >= 18)
                        Console.WriteLine("You are old.");
                }

                Console.WriteLine();
            }
        }
    }