namespace ConsoleAppTraditional.Class
{
    class Punct
    {
        protected int x;
        protected int y;
        public Punct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Scrie()
        {
            Console.Write("({0}, {1})", x, y);
        }
    }
    class Linie : Punct
    {
        public int xEnd;
        public int yEnd;
        public new void Scrie()
        {
            Console.Write("Segment: ");
            base.Scrie();
            Console.WriteLine(" - ({0}, {1})", xEnd, yEnd);
        }
        public Linie(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            xEnd = x2; yEnd = y2;
        }
    }

}
