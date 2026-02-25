namespace ConsoleAppTraditional.LogImplementations.GenericLogger
{
    public class Logger<T>
    {
        public int MyProperty { get; set; }
        public void Log(T data)
        {
            MyProperty.CompareTo(1);
            Console.WriteLine($"[LOG]: {data}");
        }
    }

}
