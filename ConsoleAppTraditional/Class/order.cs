using System.Numerics;

namespace ConsoleAppTraditional.Class
{
    public class AgregatedOrders
    {
        public string Product { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string Product{ get; set; }
        public int Quantity{ get; set; }
        public decimal Price{ get; set; }
    }

    public static class OrderManager
    {
        public static List<AgregatedOrders> GroupByProduct(List<Order> orders)
        {
            return orders.
                GroupBy(o => o.Product)
                .Select(g => new AgregatedOrders
                {
                    Product = g.Key,
                    TotalQuantity = g.Sum(o => o.Quantity),
                    TotalPrice = g.Sum(o => o.Price * o.Quantity)
                }).ToList();
        }
    }
}
