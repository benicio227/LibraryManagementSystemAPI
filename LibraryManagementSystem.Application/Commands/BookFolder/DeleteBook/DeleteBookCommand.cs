using LibraryManagementSystem.Application.Models;
using MediatR;

namespace LibraryManagementSystem.Application.Commands.BookFolder.DeleteBook;
public class DeleteBookCommand : IRequest<ResultViewModel>
{
    public DeleteBookCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
