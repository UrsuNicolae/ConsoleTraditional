namespace ConsoleAppTraditional.Class
{
    public class Calculator
    {
        public static int Number;

        static Calculator()
        {
            Number = 0;
            Console.WriteLine("Calling static construct from Calculator");
        }

        public Calculator()
        {
            Console.WriteLine("Simple calculator ctor");
        }
        public Calculator(int nr)
        {
            Console.WriteLine("Ctor with params");
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
