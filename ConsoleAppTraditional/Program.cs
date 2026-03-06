using ConsoleAppTraditional.Class;
using ConsoleAppTraditional.Class.Employee;

namespace ConsoleAppTraditional
{

    class Program
    {

        static async Task Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new FullTimeEmployee("nic", 1, 20000, Department.IT, 20),
                new FullTimeEmployee("ion", 1, 75000, Department.TD, 45),
                new FullTimeEmployee("vasilse", 1, 30000, Department.BA, 17),
                new FullTimeEmployee("criss", 1, 50500, Department.TD, 21),
                new FullTimeEmployee("maria", 1, 2000, Department.IT, 60),
            };

            Console.WriteLine($"At least one older than 50: {employees.Any(e => e.Age > 50)}");
            Console.WriteLine($"All older than 18: {employees.All(e => e.Age > 18)}");
        }
    }
}
