namespace ConsoleAppTraditional.Class
{
    public class MathOperation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Adding two integers{a} + {b} = {a + b}");
        }
        
        public void Add(double a, double b)
        {
            Console.WriteLine($"Adding two doubles {a} + {b} = {a + b}");
        }
    }
}
