using System.Diagnostics.Metrics;

namespace ConsoleAppTraditional.Class
{
    public abstract class Artist
    {
        public string Name { get; }
        public string Genre { get;}

        protected Artist(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public abstract void DisplayDetails();
    }

    public class SoloMusician : Artist
    {
        public string Instrument { get; }
        public SoloMusician(string name, string genre, string instrument) : base(name, genre)
        {
            Instrument = instrument;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Solo Musician: {Name}, Genre: {Genre}, Instrument: {Instrument}");
        }
    }

    public class DJ : Artist
    {
        public string Syle { get; set; }
        public DJ(string name, string genre, string syle) : base(name, genre)
        {
            Syle = syle;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"DJ: {Name}, Genre: {Genre}, Syte: {Syle}");
        }
    }

    public class Band : Artist
    {
        public int NumberOfMembers { get; }

        public Band(string name, string genre, int numberOfMembers) : base(name, genre)
        {
            NumberOfMembers = numberOfMembers;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Band: {Name}, Genre: {Genre}, NrOfMembers: {NumberOfMembers}");
        }
    }
}
