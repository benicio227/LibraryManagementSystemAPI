namespace LibraryManagementSystem.Core.Entities;
public class Book
{
    private Book() { }
    public Book(string title, string author, string isbn, int published)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        Published = published;
    }
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author {  get; private set; }
    public string Isbn { get; private set; }
    public int Published { get; private set; }
}
