namespace ConsoleAppTraditional.DesignePatters
{
    public class Car
    {
        public string Engine { get; set; }
        public string Wheels { get; set; }
        public string Color { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Wheels: {Wheels}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    public interface ICarBuilder
    {
        void SetEngine(string engine);
        void SetWheels(string wheels);
        void SetColor(string color);
        Car GetCar();
    }

    public class CarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void SetEngine(string engine)
        {
            car.Engine = engine;
        }

        public void SetWheels(string wheels)
        {
            car.Wheels = wheels;
        }

        public void SetColor(string color)
        {
            car.Color = color;
        }

        public Car GetCar()
        {
            return car;
        }
    }

    public class CarDirector
    {
        public void BuildSportsCar(ICarBuilder builder)
        {
            builder.SetEngine("V8 Engine");
            builder.SetWheels("Sport Wheels");
            builder.SetColor("Red");
        }
    }
}
