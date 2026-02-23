namespace ConsoleAppTraditional.LogImplementations.GenericLogger
{
    public class Logger<T>
    {
        public void Log(T data)
        {
            Console.WriteLine($"[LOG]: {data}");
        }
    }

}
