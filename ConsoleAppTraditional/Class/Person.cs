namespace ConsoleAppTraditional.Class
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;//werwer
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name is:{name} age is:{age}");
        }
    }
}
