using ConsoleAppTraditional.Class;

namespace ConsoleAppTraditional
{

    class Program
    {

        static async Task Main(string[] args)
        {
            var artists = new List<Artist>
            {
                new SoloMusician("Jhon Doe", "Pop", "Guitar"),
                new Band("The Band", "Rock", 4),
                new DJ("DJMAx", "Electro", "House")
            };

            var events = new List<Event>
            {
                new MainConcert("Main Stage", DateTime.Parse("2026-08-10"), artists[0]),
                new AcousticSession("Acoustic Room", DateTime.Parse("2026-10-10"), artists[1]),
                new AfterParty("CLUB XYZ", DateTime.Parse("2026-12-10"), artists[2])
            };
            foreach(var concretEvent in events)
            {
                concretEvent.DisplayDetails();
            }
        }
    }
}
