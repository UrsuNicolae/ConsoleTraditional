using ConsoleAppTraditional.Delegates;
using ConsoleAppTraditional.SOLID;
using System;
using System.Diagnostics.Contracts;

namespace ConsoleAppTraditional
{

    class Program
    {
        public delegate int MathOperations(int x, int y);
        //public delegate bool StringFilter(string srt);
        public delegate bool ProductFilter(DelegateProduct product);

        public static bool StartsWithLetter(string srt, char letter) => srt.StartsWith(letter);
        public static bool ContainsSubstring(string srt, string substring) => srt.Contains(substring);
        public static bool LongerThan(string srt, int length) => srt.Length > length;

        public static List<string> FilterStrings(List<string> strings, Predicate<string> filter)
        {
            var results = new List<string>();
            foreach (var str in strings)
            {
                if (filter(str))
                {
                    results.Add(str);
                }
            }
            return results;
        }

        public static List<DelegateProduct> FilterProducts(List<DelegateProduct> products, ProductFilter filter)
        {
            Predicate<DelegateProduct> testPredicate = DelegateProduct.IsElectornics;
            Func<DelegateProduct, bool> testFunc = DelegateProduct.IsElectornics;


            var result = new List<DelegateProduct>();
            foreach (var product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static int Multiply(int x, int y) => x * y;
        public static int Divide(int x, int y) => x / y;

        static async Task Main(string[] args)
        {
            var products = new List<DelegateProduct>
            {
                new DelegateProduct {Name = "Mouse", Price = 89, Category = "Electronics"},
                new DelegateProduct {Name = "Chair", Price = 300, Category = "Furniture"},
                new DelegateProduct {Name = "Leptop", Price = 2000, Category = "Electronics"},
                new DelegateProduct {Name = "Pen", Price = 2, Category = "Stationary"},
                new DelegateProduct {Name = "Phone", Price = 599, Category = "Electronics"},
            };

            var cheapProducts = FilterProducts(products, DelegateProduct.IsCheap);
            Console.WriteLine("Cheap products");
            cheapProducts.ForEach(p => Console.WriteLine($"Product: {p.Name}, Price: {p.Price}, Category: {p.Category}"));
            var electronicProducts = products.Where(p =>
            {
                return p.Category == "Electronics";
            });

            //FilterProducts(products, );
            Console.WriteLine("Electronic products");
        }
    }
}
