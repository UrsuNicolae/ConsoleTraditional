using ConsoleAppTraditional.SOLID;

namespace ConsoleAppTraditional
{

    class Program
    {
        static void MakeBirdMove(IBird bird)
        {
            bird.Move();
        }
        static async Task Main(string[] args)
        {
            IBird sparrow = new Sparrow();
            IBird penguin = new Penguin();
            IBird strut = new Strut();

            MakeBirdMove(sparrow); 
            MakeBirdMove(penguin);
            MakeBirdMove(strut);

        }
    }
}
