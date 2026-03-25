using System.Diagnostics;

namespace ConsoleAppTraditional.Delegates
{
    public class DelegateProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public static bool IsCheap(DelegateProduct product) => product.Price < 100;
        public static bool IsElectornics(DelegateProduct product)
        {
            return product.Category == "Electronics";
        }
    }


}
