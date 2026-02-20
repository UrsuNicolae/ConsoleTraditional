namespace ConsoleAppTraditional.Class
{
    public class Product
    {
        public string Name;
        public double Price;
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Price}");
        }
    }
    public class Inventory
    {
        private List<Product> products = new List<Product>();
        public int Count => products.Count;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product this[int index]
        {
            get
            {
                if(index >= 0 && index < Count)
                {
                    return products[index];
                }else
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range");
                }
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    products[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range");
                }
            }
        }
    }
}
