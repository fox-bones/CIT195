using System;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public Book() 
        { 
            _Id = 0;
            _Title = string.Empty;
            _Author = string.Empty;
        }
        public Book(int i, string title, string author)
        {
            _Id = i;
            _Title = title;
            _Author = author;
        }
        public int GetId()
        {
            return _Id;
        }
        public void SetId(int identification)
        {
            _Id = identification;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public void SetTitle(string bookTitle)
        {
            _Title = bookTitle;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public void SetAuthor(string bookAuthor)
        {
            _Author = bookAuthor;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetId(1);
            book1.SetAuthor("David and Leigh Eddings");
            book1.SetTitle("Polgara the Sorceress");

            Book book2 = new Book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the author's full name: ");
            book2.SetAuthor(Console.ReadLine());
            Console.WriteLine("Please enter the book's title: ");
            book2.SetTitle(Console.ReadLine());

            Book book3 = new Book(3, "Fairy Tale", "Steven King");

            Console.WriteLine("Please enter the book ID: ");
            int bookID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book's title: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author of the title: ");
            string author = Console.ReadLine();
            Book book4 = new Book(bookID, bookTitle, author);

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }
        static void displayBooks(Book book)
        {
            Console.WriteLine($"ID: {book.GetId()}");
            Console.WriteLine($"Title: {book.GetTitle()}");
            Console.WriteLine($"Author: {book.GetAuthor()}");
        }
    }
}