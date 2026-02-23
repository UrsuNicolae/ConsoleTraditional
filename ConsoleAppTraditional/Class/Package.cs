namespace ConsoleAppTraditional.Class
{
    public abstract class Package
    {
        public double Weight { get; }
        public double Distance { get; }

        public Package(double weight, double distance)
        {
            Weight = weight;
            Distance = distance;
        }

        public abstract double CalculateShippingCost();
    }

    public class StandartPackage : Package
    {
        public StandartPackage(double weight, double distance) : base(weight, distance)
        {
        }

        public override double CalculateShippingCost()
        {
            return 0.5 * Weight + 0.1 * Distance;
        }
    }

    public class PriorityPackage : Package
    {
        public PriorityPackage(double weight, double distance) : base(weight, distance)
        {
        }

        public override double CalculateShippingCost()
        {
            return 0.8 * Weight + 0.2 * Distance;
        }
    }

    public class FragilePackage : Package
    {
        public FragilePackage(double weight, double distance) : base(weight, distance)
        {
        }

        public override double CalculateShippingCost()
        {
            return 1.2 * (0.5 * Weight + 0.1 * Distance);
        }
    }
}
