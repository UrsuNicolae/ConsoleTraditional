using ConsoleAppTraditional.Class;
using ConsoleAppTraditional.Class.Employee;
using ConsoleAppTraditional.LogImplementations;
using System.Numerics;

namespace ConsoleAppTraditional
{

    class Program
    {

        static async Task Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Jon", 1, 10000);
            ParTimeEmployee parTime = new ParTimeEmployee("Partime Jon", 1, 5000);
            EmployeeManager manager = new EmployeeManager();
            manager.AddEmployee(parTime);
            manager.AddEmployee(fullTimeEmployee);
            manager.DisplayAll();
        }
    }
}
