namespace ConsoleAppTraditional.Class.OnlineStore
{
    public interface Identifier
    {
        public int Id { get; set; }
    }
    public class Product : Identifier
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }

    public class Client : Identifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Order : Identifier
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class DatabaseTable<T> where T : Identifier
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }

        public T? GetById(int id)
        {
            return items.FirstOrDefault(i => i.Id == id);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public void Remove(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                throw new KeyNotFoundException($"Item with id: {id} not found!");
            }
        }
    }

    public class Database
    {
        private Dictionary<string, DatabaseTable<Identifier>> tables = new Dictionary<string, DatabaseTable<Identifier>>
        {
            {nameof(Product), new DatabaseTable<Identifier>() },
            {nameof(Order), new DatabaseTable<Identifier>() },
            {nameof(Client), new DatabaseTable<Identifier>() }
        };

        public void AddOrder(Order order)
        {
            tables[nameof(Order)].Add(order);
        }
        public void AddClient(Client client)
        {
            tables[nameof(Client)].Add(client);
        }
        public void AddProduct(Product product)
        {
            tables[nameof(Product)].Add(product);
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return tables[nameof(Product)].GetAll().Select(p => (Product)p).Where(p => p.Category == category).ToList();
        }
    }
}
