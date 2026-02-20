using System.Reflection;

namespace ConsoleAppTraditional.Class
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make:{Make}, Model: {Model}, Year: {Year}");
        }
    }

    public class Car : Vehicle
    {
        private int internalSpeed = 0;
        public Car(string make, string model, int year, int nrOfDors) : base(make, model, year)
        {
            NrOfDors = nrOfDors;
        }

        public int GetCarAge()
        {
            return DateTime.UtcNow.Year - Year;
        }

        public Car(Car car) : base(car.Make, car.Model, car.Year)
        {
            NrOfDors = car.NrOfDors;
            Speed = car.Speed;
        }

        ~Car()
        {
            Console.WriteLine("Destroying car");
        }

        public int Speed
        {
            get => internalSpeed;
            set
            {
                if (value < 0)
                    internalSpeed = 0;
                else internalSpeed = value;
            }
        }
        public int NrOfDors { get; set; }


        public override void DisplayInfo()
        {
            Console.WriteLine($"This is a car with {NrOfDors} and speed: {Speed} has {GetCarAge()} years");
            base.DisplayInfo();
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string make, string model, int year) : base(make, model, year)
        {
        }

        public string Color { get; set; }

        public new void DisplayInfo()
        {
            Console.WriteLine($"This is a {Color} bike");
            base.DisplayInfo();
        }
    }
}
