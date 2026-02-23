namespace ConsoleAppTraditional.Class
{
    public class Produs
    {
        public string Nume { get; set; }

        public double Pret { get; set; }

        public virtual void Afisare()
        {
            Console.WriteLine($"Produs: {Nume}, Pret:{Pret}");
        }
    }


    class Carte : Produs
    {
        public string  Author { get; set; }

        public override void Afisare()
        {
            Console.WriteLine($"Carte: {Nume}, Author: {Author}, Pret: {Pret} lei");
        }
    }

    class Electrocasnic : Produs
    {
        public string Producator { get; set; }

        public new void Afisare()
        {
            Console.WriteLine($"Electrocasnic: {Nume}, Producator: {Producator}, Pret: {Pret} lei");
        }
    }
}
