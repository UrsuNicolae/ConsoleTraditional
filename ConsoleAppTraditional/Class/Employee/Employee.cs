namespace ConsoleAppTraditional.Class.Employee
{
    public interface IEmployee
    {
        void Work();
        void TakeBrake();
        void DisplayInfo();
    }

    public abstract class Employee : IEmployee
    {
        private string name;
        private int id;
        private double salary;

        public int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public double Salary   
        {
            get { return salary; }
            protected set { salary = value; }
        }

        protected Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
        }

        public abstract void TakeBrake();

        public abstract void Work();
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int id, double salary) : base(name, id, salary)
        {
        }

        public override void TakeBrake()
        {
            Console.WriteLine($"{Name} is taking a break for 1 hour");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working fulltime for 8 hours");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Type: FullTime employee");
        }
    }

    public class ParTimeEmployee : Employee
    {
        public ParTimeEmployee(string name, int id, double salary) : base(name, id, salary)
        {
        }

        public override void TakeBrake()
        {
            Console.WriteLine($"{Name} is taking a break for half hour");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working partime for 4 hours");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Type: ParTime employee");
        }
    }

    public class EmployeeManager
    {
        private List<IEmployee> employees;
        public EmployeeManager()
        {
            employees = new List<IEmployee>();
        }
        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            employees.Remove(employee);
        }

        public void DisplayAll()
        {
            foreach(var employee in employees)
            {
                employee.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
