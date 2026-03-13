namespace ConsoleAppTraditional.DesignePatters
{
    public interface ISmartPhone
    {
        void GetDetails();
    }

    public interface ITablet
    {
        void GetDetails();
    }

    public class AppleSmartPhone : ISmartPhone
    {
        public void GetDetails() => Console.WriteLine("Apple IPhone17");
    }

    public class AppleTablet : ITablet
    {
        public void GetDetails()
        {
            Console.WriteLine("Apple Tables - iPad Prod");
        }
    }

    public class SamsungSmartPhone : ISmartPhone
    {
        public void GetDetails() => Console.WriteLine("Samsung Galaxy 26");
    }

    public class SamsungTablet : ITablet
    {
        public void GetDetails()
        {
            Console.WriteLine("Samsung GalaxyTab 9");
        }
    }

    public interface IElectronicFactory
    {
        ISmartPhone CreateSmartPhone();

        ITablet CreateTablet();
    }

    public class AppleFactory : IElectronicFactory
    {
        public ISmartPhone CreateSmartPhone()
        {
            return new AppleSmartPhone();
        }

        public ITablet CreateTablet()
        {
            return new AppleTablet();
        }
    }

    public class SamsungFactory : IElectronicFactory
    {
        public ISmartPhone CreateSmartPhone()
        {
            return new SamsungSmartPhone();
        }

        public ITablet CreateTablet()
        {
            return new SamsungTablet();
        }
    }

    public class ElectronicStore
    {
        private readonly IElectronicFactory _factory;

        public ElectronicStore(IElectronicFactory factory)
        {
            _factory = factory;
        }

        public void ShowProducts()
        {
            var smartphone = _factory.CreateSmartPhone();
            var tablet = _factory.CreateTablet();
            smartphone.GetDetails();
            tablet.GetDetails();
        }
    }
}
