namespace ConsoleAppTraditional.SOLID
{
    public class Book
    {
        private decimal discount;
        private string isbn;
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public decimal Discount
        {
            get => discount;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid discount value!");
                }
                discount = value;
            }
        }
        public string ISBN
        {
            get => isbn; 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid isbn value!");
                }
                isbn = value;
            }
        }
    }

    public static class BookDisplayer
    {
        public static void DisplayBook(Book book)
        {
            Console.WriteLine("=== BOOK INFO ===");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Price: {book.Price:C}");
            Console.WriteLine($"Discount: {book.Discount}%");
            Console.WriteLine($"Discounted Price: {BookPriceCalculator.CalculateDiscount(book):C}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine("=================");
        }
    }

    public static class BookPriceCalculator
    {
        public static decimal CalculateDiscount(Book book)
        {
            return book.Price - (book.Price * book.Discount / 100);
        }
    }

    public static class BookRepository
    {
        public static void SaveBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));

            Console.WriteLine("Saving book data to database...");
        }
        public static Book LoadByIsbn(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) throw new ArgumentException("ISBN invalid.");

            Console.WriteLine("Loading book data from database...");
            return new Book();//book from data base
        }
    }
}
