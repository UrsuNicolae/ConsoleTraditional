namespace ConsoleAppTraditional.DesignePatters
{
    public interface IMotorBike
    {
        void GetDetails();
    }

    public interface ICar
    {
        void GetDetails();
    }

    public class ToyotaMotorcyle : IMotorBike
    {
        public void GetDetails() => Console.WriteLine("Toyota bike");
    }

    public class ToyotaCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Landcrusier");
        }
    }

    public class HondaMotorcycle : IMotorBike
    {
        public void GetDetails() => Console.WriteLine("Hoda bike");
    }

    public class HondaCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Honda Civic");
        }
    }

    public interface ICarFactory
    {
        IMotorBike CreateBike();

        ICar CreateCar();
    }

    public class ToyotaFactory : ICarFactory
    {
        public IMotorBike CreateBike()
        {
            return new ToyotaMotorcyle();
        }

        public ICar CreateCar()
        {
            return new ToyotaCar();
        }
    }

    public class HondaFactory : ICarFactory
    {
        public IMotorBike CreateBike()
        {
            return new HondaMotorcycle();
        }

        public ICar CreateCar()
        {
            return new HondaCar();
        }
    }

    public class CarDilership
    {
        private readonly ICarFactory _factory;

        public CarDilership(ICarFactory factory)
        {
            _factory = factory;
        }

        public void ShowCars()
        {
            var bike = _factory.CreateBike();
            var car = _factory.CreateCar();
            bike.GetDetails();
            car.GetDetails();
        }
    }
}
