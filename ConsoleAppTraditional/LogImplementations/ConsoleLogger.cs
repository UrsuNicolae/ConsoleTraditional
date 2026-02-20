namespace ConsoleAppTraditional.LogImplementations
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"ERR: {message}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"WARNING:{message}");
        }
    }
}
