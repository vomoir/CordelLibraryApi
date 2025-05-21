namespace CordelLibraryApi.Models;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string Publisher { get; set; }
    public required int NumberOfPages { get; set; }
    public DateTime PublishedDate { get; set; }
    public required string Blurb { get; set; }
    public required string CoverUrl { get; set; }
    }
