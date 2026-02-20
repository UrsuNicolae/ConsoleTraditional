namespace ConsoleAppTraditional.Class
{
    public class Resource
    {
        private string path;
        private bool resourceUsed;

        public Resource(string path)
        {
            this.path = path;
            Console.WriteLine($"Resource allocated");
            resourceUsed = false;   
        }

        public void ConsumeResource()
        {
            if (!resourceUsed)
            {
                Console.WriteLine("Consuming resource!");
                resourceUsed = true;
            }
            else
            {
                Console.WriteLine("Resource consumed!");
            }
        }

        ~Resource()
        {
            if (resourceUsed)
            {
                Console.WriteLine("Resource cleaned!");
            }
        }
    }
}
