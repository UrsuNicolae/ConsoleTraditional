namespace ConsoleAppTraditional.Class
{
    public interface IMovable
    {
        void Move();
    }

    public class MovingCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bycicle is moving");
        }
    }
}
