namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore
        {
            public int Id { get; init; }
            public string Title { get; init; }
            public string Author { get; init; }
            public double Price { get; init; }
            public Bookstore()
            {
                Id = 0;
                Title = string.Empty;
                Author = string.Empty;
                Price = 0;
            }
            public Bookstore(int id, string title, string author, double price)
            {
                Id = id;
                Title = title;
                Author = author;
                Price = price;
            }
            public void Display()
            {
                Console.WriteLine(Id);
                Console.WriteLine(Title);
                Console.WriteLine(Author);
                Console.WriteLine("$" + Price);
            }
        }
        static void Main(string[] args)
        {
            Bookstore AGT = new Bookstore(1, "A Game of Thrones", "George R. R. Martin", 12.99);
            Bookstore TGWDT = new Bookstore(2, "The Girl with the Dragon Tattoo", "Stieg Larson", 14.99);
            Bookstore LITM = new Bookstore(3, "Latro in the Mist", "Gene Wolfe", 13.99);

            AGT.Display();
            TGWDT.Display();
            LITM.Display();
        }
    }
}
