namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore(int Id, string Title, string Author, double Price);
        static void Main(string[] args)
        {
            Bookstore AGT = new Bookstore(1, "A Game of Thrones", "George R. R. Martin", 12.99);
            Bookstore TGWDT = new Bookstore(2, "The Girl with the Dragon Tattoo", "Stieg Larson", 14.99);
            Bookstore LITM = new Bookstore(3, "Latro in the Mist", "Gene Wolfe", 13.99);

            Console.WriteLine("ID: " + AGT.Id);
            Console.WriteLine("Title: " + AGT.Title);
            Console.WriteLine("Author: " + AGT.Author);
            Console.WriteLine("Price: " + AGT.Price);
            Console.WriteLine("ID: " + TGWDT.Id);
            Console.WriteLine("Title: " + TGWDT.Title);
            Console.WriteLine("Author: " + TGWDT.Author);
            Console.WriteLine("Price: " + TGWDT.Price);
            Console.WriteLine("ID: " + LITM.Id);
            Console.WriteLine("Title: " + LITM.Title);
            Console.WriteLine("Author: " + LITM.Author);
            Console.WriteLine("Price: " + LITM.Price);
        }
    }
}
