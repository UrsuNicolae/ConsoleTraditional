namespace ConsoleAppTraditional.Class
{
    public class Outer
    {
        public class Inner
        {
            public void ShowMessage()
            {
                Console.WriteLine("Message from inner class");
            }
        }

        public void UseInner()
        {
            var inner = new Inner();
            inner.ShowMessage();
        }
    }
}
