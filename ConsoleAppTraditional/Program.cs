using ConsoleAppTraditional.Class;

namespace ConsoleAppTraditional
{

    class Program
    {

        static async Task Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            tree.Insert(23);
            tree.Insert(27);
            tree.Insert(56);
            Console.WriteLine($"Tree has value 5: {tree.Search(5)}");
            Console.WriteLine($"Tree has value 56: {tree.Search(56)}");
        }
    }
}
