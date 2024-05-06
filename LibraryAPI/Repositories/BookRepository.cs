namespace LibraryAPI.Repositories
{
    public class BookRepository
    {
        public List<Book> Books { get; } = new List<Book>();
    }
}

public class Book
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateOnly PublishDate { get; set; }
}
