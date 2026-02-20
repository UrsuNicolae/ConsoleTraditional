namespace ConsoleAppTraditional.Class
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public override double CalculateArea()
        {
            return Length * Width; 
        }
    }
}
