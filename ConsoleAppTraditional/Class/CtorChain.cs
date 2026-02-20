namespace ConsoleAppTraditional.Class
{

    class Parent
    {
        static Parent()
        {
            Console.WriteLine("Parent: static ctor");//1
        }

        public Parent()
        {
            Console.WriteLine("Parent: parameterless instance ctor");//3
        }

        public Parent(string msg) : this()
        {
            Console.WriteLine($"Parent: instance ctor(string) msg={msg}");//4
        }
    }

    class Child : Parent
    {
        static Child()
        {
            Console.WriteLine("Child: static ctor");//2
        }

        public Child() : this(42)
        {
            Console.WriteLine("Child: parameterless instance ctor");//6
        }

        public Child(int n) : base("called from Child(int) via base(...)")//5
        {
            Console.WriteLine($"Child: instance ctor(int) n={n}");
        }
    }
}
//