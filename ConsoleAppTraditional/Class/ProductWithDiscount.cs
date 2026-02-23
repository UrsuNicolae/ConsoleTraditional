namespace ConsoleAppTraditional.Class
{
    public class ProductWithDiscount
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public decimal DiscountRate { get; private set; }
        public bool IsDiscounted { get; private set; }

        public ProductWithDiscount(string name, decimal price)
        {
            Name = name;
            Price = price;
            DiscountRate = 0;
            IsDiscounted = false;
        }

        public void ApplyDiscount(decimal discount)
        {
            if (!IsDiscounted)
            {

                DiscountRate = discount;
                Price = Price * (1 - DiscountRate);
                IsDiscounted = true;
            }
        }

        public void RemoveDiscount()
        {
            if (IsDiscounted)
            {
                Price = Price / (1 - DiscountRate);
                DiscountRate = 0;
                IsDiscounted = false;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Price}";
        }
    }
}
