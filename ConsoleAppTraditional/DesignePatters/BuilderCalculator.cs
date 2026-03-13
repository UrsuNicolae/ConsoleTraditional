using System.Net.Http.Headers;

namespace ConsoleAppTraditional.DesignePatters
{
    public class Calculator
    {
        public string ScreenColor { get; set; }
        public List<string> Functions { get; set; } = new();

        public void ShowDetails()
        {
            Console.WriteLine($"Screen color: {ScreenColor}");
            Console.WriteLine($"Functions: " + string.Join(", ", Functions));
        }
    }

    public abstract class CalculatorBuilder
    {
        protected Calculator _calculator = new Calculator();
        public abstract void BuildScreen();
        public abstract void BuildFunctions();

        public Calculator GetCalculator() => _calculator;
    }

    public class ScientificCalculator : CalculatorBuilder
    {
        public override void BuildFunctions()
        {
            _calculator.Functions.AddRange(new[] { "Add", "Subtract", "Multiply", "Devide", "Square Root" });
        }

        public override void BuildScreen()
        {
            _calculator.ScreenColor = "Black";
        }
    }

    public class BasicCalculator : CalculatorBuilder
    {
        public override void BuildFunctions()
        {
            _calculator.Functions.AddRange(new[] { "Add", "Subtract", "Multiply"});
        }

        public override void BuildScreen()
        {
            _calculator.ScreenColor = "White";
        }
    }

    public class CalculatorFactory
    {

        public Calculator Construct(string type)
        {
            switch (type)
            {
                case "basic":
                    var basicBuilder = new BasicCalculator();
                    basicBuilder.BuildScreen();
                    basicBuilder.BuildFunctions();
                    return basicBuilder.GetCalculator();
                case "sientific":
                    var scientificBuilder = new ScientificCalculator();
                    scientificBuilder.BuildScreen();
                    scientificBuilder.BuildFunctions();
                    return scientificBuilder.GetCalculator();
                default:
                    throw new ArgumentException("Invalid calculator type");
            }
        }
    }
}
