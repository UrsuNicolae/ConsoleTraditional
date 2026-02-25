namespace ConsoleAppTraditional.Class
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public int Age => age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;//werwer
        }

        public int CompareTo(Person? other)
        {
            if(other == null)
            {
                return 1;
            }
            return this.age.CompareTo(other.age);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name is:{name} age is:{age}");
        }
        public override string ToString()
        {
            return $"Name is:{name} age is:{age}";
        }
    }
}
