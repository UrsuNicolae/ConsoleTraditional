namespace ConsoleAppTraditional.DesignePatters
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player is ON");
        }

        public void PlayMovie()
        {
            Console.WriteLine("Movie is playing...");
        }
    }

    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is ON");
        }
    }

    public class SoundSystem
    {
        public void On()
        {
            Console.WriteLine("Sound System is ON");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Volume set to {level}");
        }
    }

    public class HomeTheaterFacade
    {
        private DVDPlayer dvd;
        private Projector projector;
        private SoundSystem sound;

        public HomeTheaterFacade(DVDPlayer dvd, Projector projector, SoundSystem sound)
        {
            this.dvd = dvd;
            this.projector = projector;
            this.sound = sound;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Starting Home Theater...");

            projector.On();
            sound.On();
            sound.SetVolume(10);
            dvd.On();
            dvd.PlayMovie();
        }
    }
}
