namespace ConsoleAppTraditional.SOLID
{
    public interface IBird
    {
        void Move();
    }

    class Sparrow : IBird
    {
        public void Move()
        {
            Console.WriteLine("The sparrow is flying.");
        }
    }

    class Penguin : IBird
    {

        public void Move()
        {
            Console.WriteLine("The penguin is swimming");
        }
    }

    class Strut : IBird
    {

        public void Move()
        {
            Console.WriteLine("The bird is running");
        }
    }

    //class Program
    //{
    //    static void MakeBirdFly(Bird bird)
    //    {
    //        bird.Fly();
    //    }

    //    static void Main()
    //    {
    //        Bird sparrow = new Sparrow();
    //        Bird penguin = new Penguin();

    //        MakeBirdFly(sparrow);  // OK
    //        MakeBirdFly(penguin);  // ❌ Runtime error
    //    }
    //}
}
