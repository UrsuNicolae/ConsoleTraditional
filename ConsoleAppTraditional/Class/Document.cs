namespace ConsoleAppTraditional.Class
{
    public abstract class Document
    {
        public abstract string DocType { get; set; }
        public abstract void Open();
        public abstract void Save();

        public void Print()
        {
            Console.WriteLine("This document is of type: {0}", DocType);
        }
    }

    public class WordDocument : Document
    {
        public override string DocType { get; set; } = "Word";

        public override void Open()
        {
            Console.WriteLine($"Open {DocType}");
        }

        public override void Save()
        {
            Console.WriteLine($"Save {DocType}");
        }
    }

    public class PdfDocument : Document
    {
        public override string DocType { get; set; } = "PDF";

        public override void Open()
        {
            Console.WriteLine($"Open {DocType}");
        }

        public override void Save()
        {
            Console.WriteLine($"Save {DocType}");
        }
    }
}
