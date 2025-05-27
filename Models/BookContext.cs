using Microsoft.EntityFrameworkCore;

namespace CordelLibraryApi.Models;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.Entity<Book>().HasData(new Book()
        {
            Id = 1,
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Publisher = "Scribner",
            NumberOfPages = 180,
            PublishedDate = new DateOnly(1925, 4, 10),
            Blurb = "A novel about the American dream and the disillusionment of the Jazz Age.",
            CoverUrl = "https=//covers.openlibrary.org/b/id/22-M.jpg"
        });
        _ = modelBuilder.Entity<Book>().HasData(new Book()
        {
            Id = 2,
            Title = "To Kill a Mockingbird",
            Author = "Harper Lee",
            Publisher = "J.B. Lippincott & Co.",
            NumberOfPages = 281,
            PublishedDate = new DateOnly(1960, 7, 11),
            Blurb = "A novel about the serious issues",
            CoverUrl = "https=//covers.openlibrary.org/b/id/24-M.jpg"
        });
        _ = modelBuilder.Entity<Book>().HasData(new Book()
        {
            Id = 3,
            Title = "1984",
            Author = "George Orwell",
            Publisher = "Secker & Warburg",
            NumberOfPages = 328,
            PublishedDate = new DateOnly(1949, 6, 8),
            Blurb = "A dystopian novel set in a totalitarian society ruled by Big Brother.",
            CoverUrl = "https=//covers.openlibrary.org/b/id/14-M.jpg"
        });
        _ = modelBuilder.Entity<Book>().HasData(new Book()
        {
            Id = 4,
            Title = "Pride and Prejudice",
            Author = "Jane Austen",
            Publisher = "T. Egerton",
            NumberOfPages = 432,
            PublishedDate = new DateOnly(1813, 1, 28),
            Blurb = "A romantic novel that critiques the British landed gentry at the end of the 18th century.",
            CoverUrl = "https=//covers.openlibrary.org/b/id/1-M.jpg"
        });
        base.OnModelCreating(modelBuilder);
    }
}