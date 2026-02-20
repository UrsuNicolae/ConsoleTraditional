using System.Reflection;
using System.Runtime.InteropServices;

namespace ConsoleAppTraditional.LogImplementations
{
    public class FileLogger : ILogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void LogError(string message)
        {
            LogToFile($"ERR: {message}");
        }

        public void LogInformation(string message)
        {
            LogToFile($"INFO: {message}");
        }

        public void LogWarning(string message)
        {
            LogToFile($"WARNING: {message}");
        }

        private void LogToFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{DateTime.Now}:{message}");
            }

        }
    }
}
