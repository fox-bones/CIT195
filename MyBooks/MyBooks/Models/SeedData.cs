using Microsoft.EntityFrameworkCore;
using MyBooks.Data;

namespace MyBooks.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyBooksContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyBooksContext>>()))
        {
            if (context == null || context.Book == null)
            {
                throw new ArgumentNullException("Null MyBooksContext");
            }

            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "Red Rising",
                    Author = "Pierce Brown",
                    Genre = "Sci-fi",
                    Pages = 382,
                    ReleaseDate = DateTime.Parse("2014-1-28")
                },

                new Book
                {
                    Title = "Outer Dark ",
                    Author = "Cormac Mc Carthy",
                    Genre = "Fiction",
                    Pages = 242,
                    ReleaseDate = DateTime.Parse("1968-1-1")
                },

                new Book
                {
                    Title = "The Girl with the Dragon Tattoo",
                    Author = "Stieg Larsson",
                    Genre = "Thriller",
                    Pages = 480,
                    ReleaseDate = DateTime.Parse("2011-12-1")
                },

                new Book
                {
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    Genre = "Sci-fi",
                    Pages = 268,
                    ReleaseDate = DateTime.Parse("1932-1-1")
                }
            );
            context.SaveChanges();
        }
    }
}