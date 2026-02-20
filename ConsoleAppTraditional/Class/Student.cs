namespace ConsoleAppTraditional.Class
{
    public class Student
    {
        public string Name { get; init; }
        public string Specializare { get; set; }
        public int Varsta { get; set; }

        public Student(string name, string specializare, int varsta)
        {
            Name = name;
            Specializare = specializare;
            Varsta = varsta;
        }

        public Student (Student student)
        {
            Name = student.Name;
            Varsta = student.Varsta;
            Specializare = student.Specializare;
        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Nume: {Name}, Varsta: {Varsta}, Specializare: {Specializare}");
        }
    }
}
