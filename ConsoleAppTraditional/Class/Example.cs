namespace ConsoleAppTraditional.Class
{
    interface IExample1
    {
        void Method1();
    }

    interface IExample2
    {
        void Method1();
    }
    class Example : IExample1, IExample2
    {
        public void Method1()
        {
        }
    }
}
