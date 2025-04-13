using LibraryManagementSystem.Core.Entities;

namespace LibraryManagementSystem.Application.Models;
public class BookViewModel
{
    public BookViewModel(int id, string title, string author, string isbn, int published)
    {
        Id = id;
        Title = title;
        Author = author;
        Isbn = isbn;
        Published = published;
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string Isbn { get; private set; }
    public int Published { get; private set; }

    public static BookViewModel FromEntity(Book book)
    {
        return new BookViewModel(book.Id, book.Title, book.Author, book.Isbn, book.Published);
    }
}
