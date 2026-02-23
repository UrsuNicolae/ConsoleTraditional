using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace ConsoleAppTraditional.Class
{
    public abstract class Event
    {
        public string  Location{ get;}
        public DateTime Date{ get;}
        public Artist Artist { get; }


        protected Event(string location, DateTime date, Artist artist)
        {
            Location = location;
            Date = date;
            Artist = artist;
        }

        public abstract void DisplayDetails();
    }

    public class MainConcert : Event
    {
        public MainConcert(string location, DateTime date, Artist mainArtist) : base(location, date, mainArtist)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Main Concert: {Location}, Date: {Date}");
            Artist.DisplayDetails();
        }
    }

    public class AcousticSession : Event
    {
        public AcousticSession(string location, DateTime date, Artist artist) : base(location, date, artist)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Acoustic Session: {Location}, Date: {Date}");
            Artist.DisplayDetails();
        }
    }

    public class AfterParty : Event
    {
        public AfterParty(string location, DateTime date, Artist artist) : base(location, date, artist)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"AfterParty: {Location}, Date: {Date}");
            Artist.DisplayDetails();
        }
    }


}
