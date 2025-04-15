using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Core.Entities;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.InsertBook;
public class InsertBookCommand : IRequest<ResultViewModel<BookViewModel>>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
    public int Published { get; set; }

    public Book ToEntity()
    {
        return new Book(Title, Author, Isbn, Published);
    }
}
