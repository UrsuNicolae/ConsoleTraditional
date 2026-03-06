using System.Xml.Linq;

namespace ConsoleAppTraditional.Class
{

    // Clasa care încalcă principiul SRP
    public class EmployeeSRP
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public class PayCalculator
    {
        public void CalculatePay(EmployeeSRP employee)
        {
            // Logica pentru calcularea salariului
            Console.WriteLine($"Calculating pay for {employee.Name}...");
        }
    }

}
