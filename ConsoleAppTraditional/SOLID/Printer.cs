namespace ConsoleAppTraditional.SOLID
{
    // Interfață pentru imprimante
    interface IPrinter
    {
        void Print(string document);
    }


    // Interfață pentru scanere
    interface IScanner
    {
        void Scan(string document);
    }


    // Interfață pentru copiatoare
    interface ICopier
    {
        void Copy(string document);
    }


    // Clasă care implementează toate cele trei interfețe (încalcă ISP)
    class AllInOnePrinter : IPrinter, IScanner, ICopier
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }


        public void Scan(string document)
        {
            Console.WriteLine($"Scanning: {document}");
        }


        public void Copy(string document)
        {
            Console.WriteLine($"Copying: {document}");
        }
    }


    // Clasă care implementează doar interfeța IPrinter (respectă ISP)
    class BasicPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }
    }

}
