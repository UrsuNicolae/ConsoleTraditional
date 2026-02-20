namespace ConsoleAppTraditional.Class
{
    public class Counter
    {
        public static int Count = 0;
        private int currentNr;

        public Counter()
        {
            Count++;
            currentNr = Count;
        }
        public void ShowNr()
        {
            Console.WriteLine($"My number is: {currentNr}");
        }

        public void ShowTotalNr()
        {
            Console.WriteLine($"Total number is {Count}");

        }
    }
}
