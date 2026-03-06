namespace ConsoleAppTraditional.SOLID
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Cirlce : Shape
    {
        public  double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
